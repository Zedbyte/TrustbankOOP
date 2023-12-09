using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class EnrolledContactsMainUserControl : UserControl
    {

        string? contactName {  get; set; }

        string? contactAccountNumber { get; set; }

        string? contactEmailAddress {  get; set; }

        string? contactBankAccount {  get; set; }

        public EnrolledContactsMainUserControl(string id)
        {
            InitializeComponent();
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


                    //Create the new row first and get the index of the new row
                    int rowIndex = contactsDataGrid.Rows.Add();

                    //Obtain a reference to the newly created DataGridViewRow 
                    var row = contactsDataGrid.Rows[rowIndex];

                    //Now this won't fail since the row and columns exist 
                    row.Cells["colName"].Value = contactName;
                    row.Cells["colAccountNumber"].Value = contactAccountNumber;
                    row.Cells["colEmailAddress"].Value = contactEmailAddress;
                    row.Cells["colBankName"].Value = contactBankAccount;

                    //OR

                    //contactsDataGrid.Rows.Add(txtBxName.Text, txtBxAccountNumber.Text, txtBxEmailAddress.Text, txtBxBankName.Text);
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

        private bool contactExistsAlready()
        {
            string[] searchStrings = { txtBxName.Text, txtBxAccountNumber.Text, txtBxEmailAddress.Text, txtBxBankName.Text };

            foreach (DataGridViewRow row in contactsDataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool nameMatch = row.Cells[0].Value != null && row.Cells[0].Value.ToString() == searchStrings[0];
                    bool accNumMatch = row.Cells[1].Value != null && row.Cells[1].Value.ToString() == searchStrings[1];
                    bool emailMatch = row.Cells[2].Value != null && row.Cells[2].Value.ToString() == searchStrings[2];
                    bool bankNameMatch = row.Cells[3].Value != null && row.Cells[3].Value.ToString() == searchStrings[3];

                    // Debugging statements
                    MessageBox.Show($"Row {row.Index}: NameMatch: {nameMatch}, AccNumMatch: {accNumMatch}, EmailMatch: {emailMatch}, BankNameMatch: {bankNameMatch}");

                    // If account number and email match, return true
                    if (accNumMatch || emailMatch)
                    {
                        Console.WriteLine("Account number and email matched in this row.");
                        return true;
                    }

                    // If all strings match, return true
                    if (nameMatch && accNumMatch && emailMatch && bankNameMatch)
                    {
                        Console.WriteLine("All strings matched in this row.");
                        return true;
                    }
                }
            }

            // Strings not found in any row
            return false;
            /*string[] searchStrings = {txtBxName.Text, txtBxAccountNumber.Text, txtBxEmailAddress.Text, txtBxBankName.Text };

            int currentCell = 0;

            foreach (DataGridViewRow row in contactsDataGrid.Rows)
            {
                if (!row.IsNewRow) // Skip the new row if present
                {
                    int stringMatches = 0;

                    foreach (string searchString in searchStrings)
                    {
                        bool found = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            //If a string matches in the account number and email address cell, immediately return true.
                            currentCell += 1;
                            if (currentCell == 2)
                            {
                                if (cell.Value != null && cell.Value.ToString() == searchString)
                                {
                                    return true;
                                }
                            }

                            if (currentCell == 3)
                            {
                                if (cell.Value != null && cell.Value.ToString() == searchString)
                                {
                                    return true;
                                }
                            }

                            if (cell.Value != null && cell.Value.ToString() == searchString)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            stringMatches++;
                        }
                    }

                    if (stringMatches == searchStrings.Length)
                    {
                        // All strings found in this row
                        return true;
                    }
                }
                //Reset the current cell number after a row
                currentCell = 0;
            }
            // Strings not found in any row
            return false;*/
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
    }
}
