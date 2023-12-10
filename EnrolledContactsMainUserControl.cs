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
using Vonage.Voice.EventWebhooks;
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


        string EditInputContactID = "";
        int editClickCount = 0;

        public EnrolledContactsMainUserControl(string id)
        {
            InitializeComponent();

            this.id = id;

            btnCancelEdit.Enabled = false;
            btnCancelEdit.Visible = false;

            //ViewContacts(); //Uncomment for automatic viewing of contacts
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!containsCharacters(txtBxAccountNumber) && !containsDigits(txtBxName) && txtBxName.Text != "" && txtBxAccountNumber.Text != "" && txtBxEmailAddress.Text != "" && txtBxBankName.Text != "")
            {
                //Make sure the contact is not already in your contact and it is not your own account number and email address
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



        private void clearTextbox()
        {
            txtBxName.Clear();
            txtBxAccountNumber.Clear();
            txtBxEmailAddress.Clear();
            txtBxBankName.Clear();
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

        private bool doesInputExist(string input)
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM EnrolledContacts WHERE owner_id = @id AND contact_id = @contact_id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@contact_id", input);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    // If count > 0, username exists; otherwise, it doesn't
                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            editClickCount = 0;
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Center the input box
            int x = this.Left + (this.Width / 2);
            int y = this.Top + (this.Height / 2) + 50;
            string input = Microsoft.VisualBasic.Interaction.InputBox("NOTE:\nYOU ARE DELETING A CONTACT. DELETING A CONTACT IS IRREVERSIBLE.\n\n\nEnter Contact ID.",
                       "Enter Contact ID",
                       "",
                       x,
                       y);

            if (!containsCharacters(input) && doesInputExist(input))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand cmd = new SqlCommand(@"DELETE FROM EnrolledContacts WHERE contact_id = @contact_id", connection))
                    {
                        cmd.Parameters.AddWithValue("@contact_id", input);
                        connection.Open();
                        /*cmd.ExecuteNonQuery();*/

                        SqlDataReader dr = cmd.ExecuteReader();

                        ViewContacts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Center the input box

            editClickCount++;

            if (editClickCount == 1)
            {
                int x = this.Left + (this.Width / 2);
                int y = this.Top + (this.Height / 2) + 50;
                EditInputContactID = Microsoft.VisualBasic.Interaction.InputBox("NOTE:\nYou are editing contact details. \n\n\nEnter Contact ID.",
                            "Enter Contact ID",
                            "",
                            x,
                            y);

                if (!containsCharacters(EditInputContactID) && doesInputExist(EditInputContactID))
                {

                    btnAdd.Enabled = false;
                    btnAdd.BackColor = Color.DimGray;


                    btnDelete.Enabled = false;
                    btnDelete.BackColor = Color.DimGray;


                    btnEdit.Text = "Save";
                    btnEdit.ForeColor = Color.Black;
                    btnEdit.BackColor = Color.LightGreen;

                    btnCancelEdit.Enabled = true;
                    btnCancelEdit.Visible = true;

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
                else
                {
                    MessageBox.Show("Your input might be invalid or empty!");
                }
            }
            else if (editClickCount == 2)
            {
                if (!containsCharacters(txtBxAccountNumber) && !containsDigits(txtBxName) && txtBxName.Text != "" && txtBxAccountNumber.Text != "" && txtBxEmailAddress.Text != "" && txtBxBankName.Text != "")
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
                    {
                        using (SqlCommand cmd = new SqlCommand(@"UPDATE EnrolledContacts SET name = @name, account_number = @account_number, email_address = @email_address, bank_name = @bank_name WHERE owner_id = @id AND contact_id = @contact_id", connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@contact_id", EditInputContactID);
                            cmd.Parameters.AddWithValue("@name", txtBxName.Text);
                            cmd.Parameters.AddWithValue("@account_number", txtBxAccountNumber.Text);
                            cmd.Parameters.AddWithValue("@email_address", txtBxEmailAddress.Text);
                            cmd.Parameters.AddWithValue("@bank_name", txtBxBankName.Text);
                            connection.Open();

                            SqlDataReader reader = cmd.ExecuteReader();

                            MessageBox.Show("Contact: " + EditInputContactID + "Update Successfully!");

                            ViewContacts();
                        }
                    }

                    clearTextbox();
                }
                else
                {
                    MessageBox.Show("Invalid Data!");
                }

                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(0, 147, 68);


                btnDelete.Enabled = true;
                btnDelete.BackColor = Color.Firebrick;

                btnEdit.Text = "Edit";
                btnEdit.ForeColor = Color.White;
                btnEdit.BackColor = Color.FromArgb(0, 26, 136);

                btnCancelEdit.Enabled = false;
                btnCancelEdit.Visible = false;


                //Reset the count after saving
                editClickCount = 0;
            }

        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Discard Edits.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnCancelEdit.Enabled = false;
                btnCancelEdit.Visible = false;

                editClickCount = 0;

                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.FromArgb(0, 147, 68);


                btnDelete.Enabled = true;
                btnDelete.BackColor = Color.Firebrick;

                btnEdit.Text = "Edit";
                btnEdit.ForeColor = Color.White;
                btnEdit.BackColor = Color.FromArgb(0, 26, 136);

                clearTextbox();
            }
        }
    }
}
