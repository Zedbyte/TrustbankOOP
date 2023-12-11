using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trustbank
{
    public partial class ConfirmTransferMainUserControl : UserControl
    {
        string? id { get; set; }

        string? Contact_ID { get; set; }

        string? CompleteName { get; set; }

        string? AccountNumber { get; set; }
        
        string? EmailAddress { get; set; }

        double Amount { get; set; }

        double ChargeFee { get; set; }

        string? RecipientName { get; set; }

        string? RecipientBankName { get; set; }

        string? RecipientAccountNumber { get; set; }

        string? RecipientEmailAddress { get; set; }

        string? Purpose { get; set; }






        double? UserBalance {  get; set; }

        double? UserBalanceUpdated {  get; set; }

        double? RecipientBalance {  get; set; }


        Panel parentContainerPanel;

        public ConfirmTransferMainUserControl(Panel parentContainerPanel, string id, string contact_id, string completeName, string accountNumber, string emailAddress, double amount, double chargeFee,
            string recipientName,
            string recipientBankName,
            string recipientAccountNumber,
            string recipientEmailAddress,
            string purpose)
        {
            InitializeComponent();

            this.parentContainerPanel = parentContainerPanel;

            this.id = id;

            this.Contact_ID = contact_id;

            this.CompleteName = completeName;

            this.AccountNumber = accountNumber;

            this.EmailAddress = emailAddress;

            this.Amount = amount;

            this.ChargeFee = chargeFee;

            this.RecipientName = recipientName;

            this.RecipientBankName = recipientBankName;

            this.RecipientAccountNumber = recipientAccountNumber;

            this.RecipientEmailAddress = recipientEmailAddress;

            this.Purpose = purpose;


            setUserLabelDetails();
            setAmountAndChargeLabelDetails();
            setRecipientLabelDetails();

        }


        private void setUserLabelDetails()
        {
            lblNamePlaceholder.Text = CompleteName;
            lblAccountNumberPlaceholder.Text = AccountNumber;
            lblPurposePlaceholder.Text = Purpose;
        }

        private void setAmountAndChargeLabelDetails()
        {
            lblAmountPlaceholder.Text = Amount.ToString();
            lblChargeFee.Text = ChargeFee.ToString();
        }

        private void setRecipientLabelDetails()
        {
            lblRecipientNamePlaceholder.Text = RecipientName;
            lblRecipientBankPlaceholder.Text = RecipientBankName;
            lblRecipientAccountNumber.Text = RecipientAccountNumber;
            lblRecipientEmailAddress.Text = RecipientEmailAddress;

        }

        private void removePanel(Control panel)
        {
            parentContainerPanel.Controls.Remove(panel);
        }

        private void repaintParentPanel()
        {
            parentContainerPanel.Refresh();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OTPConfirmTransaction confirmTransaction = new OTPConfirmTransaction(id, EmailAddress);


            var result = confirmTransaction.ShowDialog();


            if (result == DialogResult.OK) 
            {
                try
                {
                    //Give value to Balance before deduction
                    getUserBalanceBeforeDeduction();

                    //Give value to RecipientBalance before addition
                    getRecipientBalanceBeforeAddition();

                    //Update User Balance
                    UpdateUserBalance();

                    //Update Recipient Balance
                    UpdateRecipientBalance();

                    //Get user balance after the deduction
                    getUserBalanceAfterDeduction();

                    //Add the transaction
                    AddtoTransactionHistory();

                    removePanel(this);

                    repaintParentPanel();

                    TransactionHistoryMainUserControl transactionHistory = new TransactionHistoryMainUserControl(id);
                    transactionHistory.Show();

                    parentContainerPanel.Controls.Add(transactionHistory);

                    this.Dispose();

                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("OTP did not match");
            }
        }





        private void AddtoTransactionHistory()
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("MMMM dd, yyyy hh:mm:ss tt");

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[TransactionHistoryTable] 
                   (
                   [user_id], 
                   [UserAccountNumber],
                   [TransactDate],
                   [TransactType],
                   [TransactPurpose],
                   [recipient_id],
                   [RecipientName],
                   [RecipientAccountNumber],
                   [UserBalance]
                   )
                   VALUES
                   (@id, @account_number, @date, @type, @purpose, @recipient_id, @recipient_name, @recipient_accountNum, @user_balance)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@account_number", AccountNumber);
            cmd.Parameters.AddWithValue("@date", formattedDateTime);
            cmd.Parameters.AddWithValue("@type", "Transfer");
            cmd.Parameters.AddWithValue("@purpose", Purpose);
            cmd.Parameters.AddWithValue("@recipient_id", Contact_ID);
            cmd.Parameters.AddWithValue("@recipient_name", RecipientName);
            cmd.Parameters.AddWithValue("@recipient_accountNum", RecipientAccountNumber);
            cmd.Parameters.AddWithValue("@user_balance", UserBalanceUpdated);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void getUserBalanceBeforeDeduction()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"SELECT balance FROM AccountsBalance WHERE user_id = @id", con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            con.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    UserBalance = reader.GetDouble(reader.GetOrdinal("balance"));
                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void getUserBalanceAfterDeduction()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"SELECT balance FROM AccountsBalance WHERE user_id = @id", con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            con.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    UserBalanceUpdated = reader.GetDouble(reader.GetOrdinal("balance"));
                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void UpdateUserBalance()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(@"UPDATE AccountsBalance SET balance = @balance WHERE user_id = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@balance", UserBalance - (Amount + ChargeFee));
                    connection.Open();


                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Close();
                }
            }
        }



        private void getRecipientBalanceBeforeAddition()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT balance FROM AccountsBalance WHERE account_number = @account_number", con);
                cmd.Parameters.AddWithValue("@account_number", RecipientAccountNumber);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        RecipientBalance = reader.GetDouble(reader.GetOrdinal("balance"));
                    }
                }


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transfer Success! Note: Recipient is not from Trustbank, please contact the recipient's bank for inquiries.");
            }
        }


        private void UpdateRecipientBalance()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE AccountsBalance SET balance = @balance WHERE account_number = @account_number", connection))
                    {
                        cmd.Parameters.AddWithValue("@account_number", RecipientAccountNumber);
                        cmd.Parameters.AddWithValue("@balance", (RecipientBalance + Amount));
                        connection.Open();


                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Transfer Success! Note: Recipient is not from Trustbank, please contact the recipient's bank for inquiries.");
                }
            }
        }












    }
}
