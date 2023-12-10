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

        double Amount {  get; set; }

        string? Purpose {  get; set; }


        




        string? FirstName {  get; set; }

        string? MiddleName { get; set; }

        string? LastName { get; set; }

        string? AccountNumber {  get; set; }


        int contact_id { get; set; }



        string? contactName { get; set; }

        string? contactAccountNumber {  get; set; }

        string? contactEmailAddress {  get; set; }

        string? contactBankName { get; set; }

        public TransferMoneyMainUserControl(Panel parentContainerPanel, string id, double amount, string purpose, int contact_id)
        {
            InitializeComponent();

            this.parentContainerPanel = parentContainerPanel;

            this.id = id;

            this.Amount = amount;

            this.Purpose = purpose;

            //There are callers to this class that sets the contact_id to 0 only SelectContactUC can give this variable a value 
            if (contact_id > 0)
            {
                //Set the contact_id give nby SelectContactUC
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
    }
}
