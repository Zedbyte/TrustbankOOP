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
    public partial class DetailsUserControl : UserControl
    {
        Panel parentRegistrationPanel;

        bool validData = true;

        //? stands for non-null, these variables must not have a null value (but I am also validating them before applying any values in isDataValid() method)
        string? Username { get; set; }

        string? Password { get; set; }

        string? FirstName { get; set; }

        string? MiddleName { get; set; }

        string? LastName { get; set; }

        string? EmailAddress { get; set; }

        string? MobileNumber { get; set; }

        string? AccountNumber { get; set; }

        string? AccountAlias { get; set; }


        int Savings { get; set; }
        int Deposit { get; set; }


        string? encryptedPassword { get; set; }

        //Check if password has one uppercase, number, and a special character
        bool isPasswordValid = false;


        public DetailsUserControl(Panel parentRegistrationPanel, Label HEADERLBLONLY)
        {
            InitializeComponent();

            this.parentRegistrationPanel = parentRegistrationPanel;

            setSavingsValueDefault();
        }

        //Set the parent property of the label and picture box above. This is for the transparent property.

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Check if data is valid, if it is, set all the variables and set validData to [true] else, [false]
            isDataValid();

            if (validData)
            {
                encryptedPassword = hashPassword(Password);


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[AccountsTB] 
                (
                [Username], 
                [Password], 
                [FirstName], 
                [MiddleName], 
                [LastName],
                [EmailAddress], 
                [MobileNumber], 
                [Savings],
                [Deposit],
                [AccountNumber],
                [AccountAlias]
                )
                VALUES
                ('" + Username + "', '" + encryptedPassword + "', '" +
                    FirstName + "', '" + MiddleName + "', '" + LastName + "', '" +
                    EmailAddress + "', '" + MobileNumber + "', '" + Savings + "', '" + Deposit + "', '" + AccountNumber + "', '" + AccountAlias + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Loading.. Next.");

                removePanel(this);
                repaintParentPanel();

                PasscodeUserControl passcodeUserControl = new PasscodeUserControl();
                parentRegistrationPanel.Controls.Add(passcodeUserControl);

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please make sure your details are correct.");
            }
        }

        private void isDataValid()
        {
            validData = true;

            if (txtBxUsername.Text != null && txtBxUsername.Text.Length > 3 && txtBxUsername.Text.Length < 20 && checkIsBlankTextBox(txtBxUsername))
            {
                Username = txtBxUsername.Text;
            }
            else
            {
                validData = false;
                MessageBox.Show("U Invalid");
            }

            if (txtBxPassword.Text != null && txtBxPassword.Text.Length >= 12 && isPasswordValid && checkIsBlankTextBox(txtBxPassword))
            {
                Password = txtBxPassword.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("P Invalid");
            }

            if (txtBxFirstName.Text != null && checkIsBlankTextBox(txtBxFirstName) && !containsDigits(txtBxFirstName))
            {
                FirstName = txtBxFirstName.Text;
            }
            else { validData = false; MessageBox.Show("Invalid F Name"); }


            if (txtBxMiddleName.Text != null)
            {
                if (containsDigits(txtBxMiddleName))
                {
                    MessageBox.Show("Invalid Middle Name");
                }
                else
                {
                    MiddleName = txtBxMiddleName.Text;
                }
            }


            if (txtBxLastName.Text != null && checkIsBlankTextBox(txtBxLastName) && !containsDigits(txtBxLastName))
            {
                LastName = txtBxLastName.Text;
            }
            else { validData = false; MessageBox.Show("Invalid L Name"); }

            if (txtBxEmailAddress.Text != null && txtBxEmailAddress.Text.Contains("@") && checkIsBlankTextBox(txtBxEmailAddress))
            {
                EmailAddress = txtBxEmailAddress.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("@ Invalid");
            }

            if (txtBxMobileNumber.Text != null && txtBxMobileNumber.Text.Length > 1 && isMobileNumberValid() && checkIsBlankTextBox(txtBxMobileNumber))
            {
                MobileNumber = mobileNumberPrefix.Text + txtBxMobileNumber.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("Mobile Invalid");
            }

            if (txtBxAccountNumber.Text != null && txtBxAccountNumber.Text.Length > 3 && checkIsBlankTextBox(txtBxAccountNumber) && !containsCharacters(txtBxAccountNumber))
            {
                AccountNumber = txtBxAccountNumber.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("AcN Invalid");
            }

            if (txtBxAccountAlias.Text != null && txtBxAccountAlias.Text.Length > 1 && checkIsBlankTextBox(txtBxAccountAlias))
            {
                AccountAlias = txtBxAccountAlias.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("AcL Invalid");
            }

            if (!checkBxMetroTermsAndService.Checked)
            {
                MessageBox.Show("CHKBX Invalid");
                validData = false;
            }

        }

        private string hashPassword(string? password)
        {
            string encryptedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);

            return encryptedPassword;
        }

        private void setSavingsValueDefault()
        {
            Savings = 1;
        }

        private void removePanel(Control panel)
        {
            parentRegistrationPanel.Controls.Remove(panel);
        }

        private void repaintParentPanel()
        {
            parentRegistrationPanel.Refresh();
        }

        private void IsBlankTextBox(object sender, EventArgs e)
        {
            TextBox txtBx = (TextBox)sender;

            //If textbox is empty
            if (txtBx.Text == "")
            {
                //Chance the border style
                txtBx.BorderStyle = BorderStyle.FixedSingle;

                //Change font and font color
                txtBx.Font = new Font("Gothic A1", 11, FontStyle.Italic);
                txtBx.ForeColor = Color.Red;

                //Invalidate input
                txtBx.Text = "This field is required.";

                validData = false;
            }
        }

        private void EnterText(object sender, EventArgs e)
        {
            TextBox txtBx = (TextBox)sender;

            //If text is invalid, when user clicked, clear the textbox and change font to regular.
            if (txtBx.Text.Equals("This field is required."))
            {
                txtBx.Clear();
                txtBx.Font = new Font("Gothic A1", 12, FontStyle.Regular);
                txtBx.ForeColor = Color.Black;
            }
        }

        private bool checkIsBlankTextBox(TextBox txtbx)
        {
            if (txtbx.Text.Equals("This field is required."))
            {
                return false;
            }
            return true;
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            Savings = 1;
            Deposit = 0;
            btnSavings.BackColor = Color.FromArgb(0, 26, 136);
            btnSavings.ForeColor = Color.White;

            btnDeposit.BackColor = Color.White;
            btnDeposit.ForeColor = Color.FromArgb(0, 26, 136);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Savings = 0;
            Deposit = 1;

            btnDeposit.BackColor = Color.FromArgb(0, 26, 136);
            btnDeposit.ForeColor = Color.White;

            btnSavings.BackColor = Color.White;
            btnSavings.ForeColor = Color.FromArgb(0, 26, 136);
        }

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

        private bool isMobileNumberValid()
        {
            bool hasLetters = Regex.IsMatch(txtBxMobileNumber.Text, "[A-Za-z]");
            if (txtBxMobileNumber.Text.StartsWith("0") || hasLetters)
            {
                return false;
            }

            return true;
        }

        private void doesPasswordMeetRequirements()
        {
            // Regular expressions to check for at least one uppercase, one number, and one special character
            bool hasUppercase = Regex.IsMatch(txtBxPassword.Text, "[A-Z]");
            bool hasNumber = Regex.IsMatch(txtBxPassword.Text, "[0-9]");
            bool hasSpecialChar = Regex.IsMatch(txtBxPassword.Text, "[@$&#/~^]");

            if (txtBxPassword.Text.Length >= 12)
            {
                lblNumberOfCharactersReq.ForeColor = Color.Green;
            }

            if (hasUppercase)
            {
                lblUppercaseReq.ForeColor = Color.Green;
            }

            if (hasNumber)
            {
                lblDigitReq.ForeColor = Color.Green;
            }

            if (hasSpecialChar)
            {
                lblSpecialCharacterReq.ForeColor = Color.Green;
            }

            if (txtBxPassword.Text.Length >= 12 && hasUppercase && hasNumber && hasSpecialChar)
            {
                isPasswordValid = true;
            }
        }

        //Checks if password meets the requirements
        /*        private void txtBxPassword_KeyPress(object sender, KeyPressEventArgs e)
                {
                    doesPasswordMeetRequirements();
                }*/

        private void txtBxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            doesPasswordMeetRequirements();
        }

        private void txtBxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            doesPasswordMeetRequirements();
        }
    }
}
