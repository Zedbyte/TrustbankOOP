using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class SelectRecipientMainUserControl : UserControl
    {
        Panel parentContainerPanel;

        TransferMoneyMainUserControl transferMoneyMainUserControl;

        bool permit = false;

        string? contactName { get; set; }

        string? contactAccountNumber { get; set; }

        string? contactEmailAddress { get; set; }

        string? contactBankAccount { get; set; }




        string? id { get; set; }

        public string? selectedContactID {  get; set; }

        public string? selectedContactName {  get; set; }
        public string? selectedContactAccountNumber { get; set; }

        public string? selectedContactEmailAddress {  get; set; }

        public string? selectedContactBankName {  get; set; }




        double Amount {  get; set; }

        string? Purpose {  get; set; }


        public SelectRecipientMainUserControl(Panel parentContainerPanel, TransferMoneyMainUserControl transferMoneyMainUserControl, string id, double amount, string purpose)
        {
            InitializeComponent();
            this.id = id;

            this.parentContainerPanel = parentContainerPanel;
            this.transferMoneyMainUserControl = transferMoneyMainUserControl;

            this.Amount = amount;
            this.Purpose = purpose;

            //Initialize the data grid view
            ViewContacts();
        }

        private void ViewContacts()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT contact_id AS 'Contact ID', name AS 'Name', account_number AS 'Account Number', email_address AS 'Email Address', bank_name AS 'Bank Name' FROM EnrolledContacts WHERE owner_id = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();


                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    selectContactGrid.DataSource = dt;

                }
            }
        }

        private void selectContactGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectContactGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //This essentially highlights/selects the entire row in the grid view.
                selectContactGrid.CurrentRow.Selected = true;

                selectedContactID = selectContactGrid.Rows[e.RowIndex].Cells["Contact ID"].FormattedValue.ToString();
                selectedContactName = selectContactGrid.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                selectedContactAccountNumber = selectContactGrid.Rows[e.RowIndex].Cells["Account Number"].FormattedValue.ToString();
                selectedContactEmailAddress = selectContactGrid.Rows[e.RowIndex].Cells["Email Address"].FormattedValue.ToString();
                selectedContactBankName = selectContactGrid.Rows[e.RowIndex].Cells["Bank Name"].FormattedValue.ToString();

                permit = true;
            }


        }

        private void btnSelectTheHighlightedRecipient_Click(object sender, EventArgs e)
        {
            if (permit)
            {
                //Remove this panel after a cell is clicked (a contact is selected)
                removePanel(this);

                //Dispose this panel
                this.Dispose();

                //New instance of transferMoney that has the previous Amount and Purpose (if filled out previously) and the selectedContactID from this panel
                TransferMoneyMainUserControl transferMoneyMainUser = new TransferMoneyMainUserControl(parentContainerPanel, id, Amount, Purpose, selectedContactID);

                //Add the hidden previous panel
                parentContainerPanel.Controls.Add(transferMoneyMainUser);

                //Show it
                transferMoneyMainUser.Show();

                //Repaint it
                repaintParentPanel();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!containsCharacters(txtBxAccountNumber) && !containsDigits(txtBxName) && txtBxName.Text != "" && txtBxAccountNumber.Text != "" && txtBxEmailAddress.Text != "" && txtBxBankName.Text != "")
            {
                //Check if contact exists already in your contact record and make sure it is not your own account number
                if (!contactExistsAlready() && !ownAccountNumber())
                {
                    contactName = txtBxName.Text;
                    contactAccountNumber = txtBxAccountNumber.Text;
                    contactEmailAddress = txtBxEmailAddress.Text;
                    contactBankAccount = txtBxBankName.Text;

                    AddtoDatabase(id, contactName, contactAccountNumber, contactEmailAddress, contactBankAccount);
                    ViewContacts();
                    clearTextbox();
                }
                else
                {
                    MessageBox.Show("Contact Exists Already!");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private bool ownAccountNumber()
        {

            string emailAddress = txtBxEmailAddress.Text;
            string accountNumber = txtBxAccountNumber.Text;

            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM AccountsTable WHERE id = @id AND AccountNumber = @account_number OR EmailAddress = @email_address";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@account_number", accountNumber);
                    command.Parameters.AddWithValue("@email_address", emailAddress);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    // If count > 0, username exists; otherwise, it doesn't
                    if (count > 0)
                    {
                        return true;
                    }
                }
            }

            // Strings not found in any row
            return false;
        }

        private void AddtoDatabase(string id, string contactName, string contactAccountNumber, string contactEmailAddress, string contactBankAccount)
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

        private bool contactExistsAlready()
        {
            string[] searchStrings = { txtBxName.Text, txtBxAccountNumber.Text, txtBxEmailAddress.Text, txtBxBankName.Text };

            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM EnrolledContacts WHERE owner_id = @id AND account_number = @account_number OR email_address = @email_address";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@account_number", searchStrings[1]);
                    command.Parameters.AddWithValue("@email_address", searchStrings[2]);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    // If count > 0, username exists; otherwise, it doesn't
                    if (count > 0)
                    {
                        return true;
                    }
                }
            }

            // Strings not found in any row
            return false;
        }

        //If textbox contains characters return true, else false.
        private bool containsCharacters(TextBox txtbx)
        {
            bool hasChars = Regex.IsMatch(txtbx.Text, "[A-Za-z]");

            if (hasChars)
            {
                return true;
            }

            return false;
        }

        private bool containsDigits(TextBox txtbx)
        {
            bool hasDigits = Regex.IsMatch(txtbx.Text, "[0-9]");

            if (hasDigits)
            {
                return true;
            }

            return false;
        }



        private void clearTextbox()
        {
            txtBxName.Clear();
            txtBxAccountNumber.Clear();
            txtBxEmailAddress.Clear();
            txtBxBankName.Clear();
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
