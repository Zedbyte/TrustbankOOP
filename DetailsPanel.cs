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
    public partial class DetailsPanel : UserControl
    {

        Panel detailsPanel;

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


        public DetailsPanel(Panel detailsPanel, Panel parentRegistrationPanel)
        {
            InitializeComponent();

            this.detailsPanel = detailsPanel;

            this.parentRegistrationPanel = parentRegistrationPanel;

            setSavingsValueDefault();
        }

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
                MessageBox.Show("Registered");

                removePanel(this.detailsPanel);
                repaintParentPanel();

                passcodeUserControl passcodePanel = new passcodeUserControl();
                parentRegistrationPanel.Controls.Add(passcodePanel);
            }
            else
            {
                MessageBox.Show("You need to fill all the details above!");
            }
        }

        private void isDataValid()
        {
            validData = true;

            if (txtBxUsername.Text != null && txtBxUsername.Text.Length > 3 && txtBxUsername.Text.Length < 20)
            {
                Username = txtBxUsername.Text;
            }
            else { validData = false; }

            if (txtBxPassword.Text != null && txtBxPassword.Text.Length > 12 && isPasswordValid)
            {
                Password = txtBxPassword.Text;
            }
            else { validData = false; }

            if (txtBxFirstName.Text != null)
            {
                FirstName = txtBxFirstName.Text;
            }
            else { validData = false; }

            if (txtBxLastName.Text != null)
            {
                LastName = txtBxLastName.Text;
            }
            else { validData = false; }

            if (txtBxEmailAddress.Text != null)
            {
                EmailAddress = txtBxEmailAddress.Text;
            }
            else { validData = false; }

            if (txtBxMobileNumber.Text != null && txtBxMobileNumber.Text.Length > 1 && isMobileNumberValid())
            {
                MobileNumber = mobileNumberPrefix.Text + txtBxMobileNumber.Text;
            }
            else { validData = false; }

            if (txtBxAccountNumber.Text != null && txtBxAccountNumber.Text.Length > 3)
            {
                AccountNumber = txtBxAccountNumber.Text;
            }
            else { validData = false; }

            if (txtBxAccountAlias.Text != null && txtBxAccountAlias.Text.Length > 1)
            {
                AccountAlias = txtBxAccountAlias.Text;
            }
            else { validData = false; }

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

        private bool isMobileNumberValid()
        {

            if (txtBxMobileNumber.Text.StartsWith("0"))
            {
                return false;
            }

            return true;
        }

        //Checks if password meets the requirements
        private void txtBxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Regular expressions to check for at least one uppercase, one number, and one special character
            bool hasUppercase = Regex.IsMatch(txtBxPassword.Text, "[A-Z]");
            bool hasNumber = Regex.IsMatch(txtBxPassword.Text, "[0-9]");
            bool hasSpecialChar = Regex.IsMatch(txtBxPassword.Text, "[^A-Za-z0-9]");

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
    }
}
