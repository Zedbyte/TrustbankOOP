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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trustbank
{
    public partial class EnrolledContactsMainUserControl : UserControl
    {

        string? contactName { get; set; }

        string? contactAccountNumber { get; set; }

        string? contactEmailAddress { get; set; }

        string? contactBankAccount { get; set; }

        string? id { get; set; }

        public EnrolledContactsMainUserControl(string id)
        {
            InitializeComponent();

            this.id = id;

            //ViewContacts(); //Uncomment for automatic viewing of contacts
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!containsCharacters(txtBxAccountNumber) && !containsDigits(txtBxName) && txtBxName.Text != "" && txtBxAccountNumber.Text != "" && txtBxEmailAddress.Text != "" && txtBxBankName.Text != "")
            {
                if (!contactExistsAlready())
                {
                    contactName = txtBxName.Text;
                    contactAccountNumber = txtBxAccountNumber.Text;
                    contactEmailAddress = txtBxEmailAddress.Text;
                    contactBankAccount = txtBxBankName.Text;

                    AddtoDatabase(id, contactName, contactAccountNumber, contactEmailAddress, contactBankAccount);
                    ViewContacts();
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
                string query = "SELECT COUNT(*) FROM EnrolledContacts WHERE account_number = @account_number OR email_address = @email_address";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

        //Overload the method for strings
        private bool containsCharacters(String input)
        {
            bool hasChars = Regex.IsMatch(input, "[A-Za-z]");

            if (hasChars)
            {
                return true;
            }

            return false;
        }



        //If textbox contains Digits (numbers) return true, else false.
        private bool containsDigits(TextBox txtbx)
        {
            bool hasDigits = Regex.IsMatch(txtbx.Text, "[0-9]");

            if (hasDigits)
            {
                return true;
            }

            return false;
        }






        private void btnView_Click(object sender, EventArgs e)
        {
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
                    contactsDataGrid.DataSource = dt;

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Center the input box
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string input = Microsoft.VisualBasic.Interaction.InputBox("NOTE:\nYOU ARE DELETING A CONTACT. DELETING A CONTACT IS IRREVERSIBLE.\n\n\nEnter Contact ID.",
                       "Enter Contact ID",
                       "Contact ID",
                       x,
                       y);
            if (!containsCharacters(input))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand cmd = new SqlCommand(@"DELETE FROM EnrolledContacts WHERE contact_id = @contact_id", connection))
                    {
                        cmd.Parameters.AddWithValue("@contact_id", input);
                        connection.Open();
                        cmd.ExecuteNonQuery();


                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        contactsDataGrid.DataSource = dt;
                        ViewContacts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }
    }
}
