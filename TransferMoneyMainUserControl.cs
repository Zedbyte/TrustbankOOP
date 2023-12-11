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
    public partial class TransferMoneyMainUserControl : UserControl
    {
        Panel parentContainerPanel;

        string? id { get; set; }

        double Amount { get; set; }

        string? Purpose { get; set; }







        string? FirstName { get; set; }

        string? MiddleName { get; set; }

        string? LastName { get; set; }

        string? AccountNumber { get; set; }

        string? EmailAddress {  get; set; }


        string contact_id { get; set; }



        string? contactName { get; set; }

        string? contactAccountNumber { get; set; }

        string? contactEmailAddress { get; set; }

        string? contactBankName { get; set; }

        public TransferMoneyMainUserControl(Panel parentContainerPanel, string id, double amount, string purpose, string contact_id)
        {
            InitializeComponent();

            this.parentContainerPanel = parentContainerPanel;

            this.id = id;

            this.Amount = amount;

            this.Purpose = purpose;

            //There are callers to this class that sets the contact_id to 0 only SelectContactUC can give this variable a value 
            if (contact_id != "")
            {
                //Set the contact_id given by SelectContactUC
                this.contact_id = contact_id;
                //Query
                getContactID();
                //Set the details
                setContactLabelDetailByContact_ID();

            }


            setAmountAndPurposeLabel();

            //Initialize the variables
            getUserDataByID();

            //Set the labels using the variables
            setLabelDetailByID();
        }

        private void btnSelectRecipients_Click(object sender, EventArgs e)
        {
            //This is the culprit why when going back from selectContactPanel to here become messed up. This panel does not want to be cleared for some reason.
            //removePanel(this);

            repaintParentPanel();

            //If the amount and purpose are already filled, pass them to the constructor
            getAmountAndPurpose();

            SelectRecipientMainUserControl selectRecipientMainUserControl = new SelectRecipientMainUserControl(parentContainerPanel, this, id, Amount, Purpose);
            selectRecipientMainUserControl.Show();

            parentContainerPanel.Controls.Add(selectRecipientMainUserControl);




            this.Hide();
        }


        private void getAmountAndPurpose()
        {
            if (txtBxAmount.Text != "")
            {
                Amount = Convert.ToDouble(txtBxAmount.Text);
            }
            else
            {
                Amount = 0;
            }

            if (txtBxPurpose.Text != "")
            {
                Purpose = txtBxPurpose.Text;
            }
            else
            {
                Purpose = "";
            }
        }

        private void getUserDataByID()
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM AccountsTable WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                MiddleName = reader.GetString(reader.GetOrdinal("MiddleName"));
                                LastName = reader.GetString(reader.GetOrdinal("LastName"));
                                AccountNumber = reader.GetString(reader.GetOrdinal("AccountNumber"));
                                EmailAddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void getContactID()
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM EnrolledContacts WHERE owner_id = @id AND contact_id = @contact_id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@contact_id", contact_id);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                contactName = reader.GetString(reader.GetOrdinal("name"));
                                contactAccountNumber = reader.GetString(reader.GetOrdinal("account_number"));
                                contactEmailAddress = reader.GetString(reader.GetOrdinal("email_address"));
                                contactBankName = reader.GetString(reader.GetOrdinal("bank_name"));
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void setLabelDetailByID()
        {
            string completeName = FirstName + " " + MiddleName + " " + LastName;
            lblNamePlaceholder.Text = completeName;

            lblAccountNumPlaceholder.Text = AccountNumber;
        }

        private void setContactLabelDetailByContact_ID()
        {
            lblRecipientNamePlaceholder.Text = contactName;
            lblRecipientAccountNumberPlaceholder.Text = contactAccountNumber;
        }

        private void setAmountAndPurposeLabel()
        {
            txtBxAmount.Text = Amount.ToString();
            txtBxPurpose.Text = Purpose;
        }

        private void removePanel(Control panel)
        {
            parentContainerPanel.Controls.Remove(panel);
        }

        private void repaintParentPanel()
        {
            parentContainerPanel.Refresh();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //If the previous instance has no amount and purpose, get the current instance's amount and purpose.
            //If the previous has amount and purpose, it doesn't matter since the textbox will have their text and will be assigned here again (the first assignment is in the constructor).
            Amount = Convert.ToDouble(txtBxAmount.Text);
            Purpose = txtBxPurpose.Text;

            if (((Amount > 0 && Purpose != "" && FirstName != "" && MiddleName != "" && LastName != "" &&
                AccountNumber != "" && contact_id != "" && contactName != "" && contactAccountNumber != "" && contactEmailAddress != "" && contactBankName != "")) && (metroRBtnInstaPay.Checked || metroRBtnPesonet.Checked))
            {

                string completeName = FirstName + " " + MiddleName + " " + LastName;
                double chargeFee = 0;

                if (metroRBtnInstaPay.Checked)
                {
                    chargeFee = 25.00;
                }
                else
                {
                    chargeFee = 50.00;
                }

                removePanel(this);

                repaintParentPanel();

                string InstaOrPESO = "";

                if (metroRBtnInstaPay.Checked)
                {
                    InstaOrPESO = "InstaPay";
                }
                else
                {
                    InstaOrPESO = "PESONet";
                }

                ConfirmTransferMainUserControl confirmTransferMainUserControl = new ConfirmTransferMainUserControl(parentContainerPanel, id, contact_id, completeName, AccountNumber, EmailAddress,
                    Amount, chargeFee, contactName, contactBankName, contactAccountNumber, contactEmailAddress, Purpose, InstaOrPESO);

                //For debugging
                //MessageBox.Show(id + " " + contact_id + " " + completeName + " " + AccountNumber + " " + Amount + " " + chargeFee + " " + contactName + " " + contactBankName + " " + contactAccountNumber + " " + contactEmailAddress + " " + Purpose);

                confirmTransferMainUserControl.Show();

                parentContainerPanel.Controls.Add(confirmTransferMainUserControl);


                this.Dispose();
            }
            else
            {       
                //Debugging purposes
                //MessageBox.Show(id + " " + contact_id + " " + FirstName + " " + AccountNumber + " " + Amount + " " + " " + contactName + " " + contactBankName + " " + contactAccountNumber + " " + contactEmailAddress + " " + Purpose);
                MessageBox.Show("There is an invalid data");
            }
        }

        private void txtBxAmount_Click(object sender, EventArgs e)
        {
            if (txtBxAmount.Text == "0")
            {
                txtBxAmount.Text = "";
            }
        }
    }
}
