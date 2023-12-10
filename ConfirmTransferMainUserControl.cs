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

        public ConfirmTransferMainUserControl(string id, string contact_id, string completeName, string accountNumber, string emailAddress, double amount, double chargeFee,
            string recipientName,
            string recipientBankName,
            string recipientAccountNumber,
            string recipientEmailAddress,
            string purpose)
        {
            InitializeComponent();

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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OTPConfirmTransaction confirmTransaction = new OTPConfirmTransaction(id, EmailAddress);
            var result = confirmTransaction.ShowDialog();

            if (result == DialogResult.OK) 
            {
                MessageBox.Show("NICE WAN LODICAKEZ!!!!");
            }
            else
            {
                MessageBox.Show("OTP did not match");
            }
        }





        private void AddtoTransactionHistory(string id, string contactName, string contactAccountNumber, string contactEmailAddress, string contactBankAccount)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[EnrolledContacts] 
                   (
                   [owner_id], 
                   [name],
                   [account_number],
                   [email_address],
                   [bank_name]
                   )
                   VALUES
                   (@id, @name, @account_number, @email_address, @bank_name)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", contactName);
            cmd.Parameters.AddWithValue("@account_number", contactAccountNumber);
            cmd.Parameters.AddWithValue("@email_address", contactEmailAddress);
            cmd.Parameters.AddWithValue("@bank_name", contactBankAccount);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void UpdateUserBalance()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT name, account_number, email_address, bank_name FROM EnrolledContacts WHERE owner_id = @id AND contact_id = @contact_id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@contact_id", EditInputContactID);
                    connection.Open();


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtBxName.Text = reader.GetValue(0).ToString();
                        txtBxAccountNumber.Text = reader.GetValue(1).ToString();
                        txtBxEmailAddress.Text = reader.GetValue(2).ToString();
                        txtBxBankName.Text = reader.GetValue(3).ToString();

                    }

                }
            }
        }

        private void UpdateRecipientBalance()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT name, account_number, email_address, bank_name FROM EnrolledContacts WHERE owner_id = @id AND contact_id = @contact_id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@contact_id", EditInputContactID);
                    connection.Open();


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtBxName.Text = reader.GetValue(0).ToString();
                        txtBxAccountNumber.Text = reader.GetValue(1).ToString();
                        txtBxEmailAddress.Text = reader.GetValue(2).ToString();
                        txtBxBankName.Text = reader.GetValue(3).ToString();

                    }

                }
            }
        }












    }







    }
}
