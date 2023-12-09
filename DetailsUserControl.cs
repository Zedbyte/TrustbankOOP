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
    public partial class DetailsUserControl : UserControl
    {
        Panel parentRegistrationPanel;

        RegisterForm registerForm;

        ReaLTaiizor.Controls.ParrotButton prtBtn1;

        ReaLTaiizor.Controls.ParrotButton prtBtn2;

        ReaLTaiizor.Controls.ParrotButton prtBtn3;

        ReaLTaiizor.Controls.ParrotButton prtBtn4;

        ReaLTaiizor.Controls.ParrotButton prtBtn5;

        Label lblPasscode;

        Label lblConfirmation;

        Label lblVerification;

        Label lblDone;

        Panel LINE1;
        Panel LINE2;
        Panel LINE3;
        Panel LINE4;

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

        int viewPasswordCount = 1;


        public DetailsUserControl(Panel parentRegistrationPanel, Label HEADERLBLONLY,
            Panel LINE1,
            Panel LINE2,
            Panel LINE3,
            Panel LINE4,
            ReaLTaiizor.Controls.ParrotButton prtBtn1,
            ReaLTaiizor.Controls.ParrotButton prtBtn2,
            ReaLTaiizor.Controls.ParrotButton prtBtn3,
            ReaLTaiizor.Controls.ParrotButton prtBtn4,
            ReaLTaiizor.Controls.ParrotButton prtBtn5,
            Label lblPasscode,
            Label lblConfirmation,
            Label lblVerification,
            Label lblDone,
            RegisterForm registerForm)
        {
            InitializeComponent();

            this.parentRegistrationPanel = parentRegistrationPanel;

            this.registerForm = registerForm;

            this.prtBtn1 = prtBtn1;

            this.prtBtn2 = prtBtn2;

            this.prtBtn3 = prtBtn3;

            this.prtBtn4 = prtBtn4;

            this.prtBtn5 = prtBtn5;

            this.lblPasscode = lblPasscode;

            this.lblConfirmation = lblConfirmation;

            this.lblVerification = lblVerification;

            this.lblDone = lblDone;

            this.LINE1 = LINE1;

            this.LINE2 = LINE2;

            this.LINE3 = LINE3;

            this.LINE4 = LINE4;

            setSavingsValueDefault();

            //The next button must be disabled first.
            btnNextDisable();

        }


        private void btnNextDisable()
        {
            btnNext.Enabled = false;
            btnNext.BackColor = Color.DimGray;
            btnNext.ForeColor = Color.White;
        }

        private void btnNextEnable()
        {
            btnNext.Enabled = true;
            btnNext.BackColor = Color.FromArgb(0, 26, 136);
            btnNext.ForeColor = Color.White;
        }

        //For keypresses, every time user presses a key on the textboxes, check for button validation.
        private void btnNextIsValid(object sender, KeyEventArgs e)
        {
            if (keyPressDataValidation())
            {
                btnNextEnable();
            }
            else
            {
                btnNextDisable();
            }
        }

        private bool keyPressDataValidation()
        {
            if (!CheckIfUsernameExists(txtBxUsername.Text) && txtBxUsername.Text != null && txtBxUsername.Text.Length > 3 && txtBxUsername.Text.Length < 20 && checkIsBlankTextBox(txtBxUsername) &&
                txtBxPassword.Text != null && txtBxPassword.Text.Length >= 12 && isPasswordValid && checkIsBlankTextBox(txtBxPassword) &&
                txtBxFirstName.Text != null && checkIsBlankTextBox(txtBxFirstName) && !containsDigits(txtBxFirstName) &&
                txtBxLastName.Text != null && checkIsBlankTextBox(txtBxLastName) && !containsDigits(txtBxLastName) &&
                txtBxEmailAddress.Text != null && txtBxEmailAddress.Text.Contains("@") && checkIsBlankTextBox(txtBxEmailAddress) &&
                txtBxMobileNumber.Text != null && txtBxMobileNumber.Text.Length > 1 && isMobileNumberValid() && checkIsBlankTextBox(txtBxMobileNumber) &&
                txtBxAccountNumber.Text != null && txtBxAccountNumber.Text.Length > 3 && checkIsBlankTextBox(txtBxAccountNumber) && !containsCharacters(txtBxAccountNumber) &&
                txtBxAccountAlias.Text != null && txtBxAccountAlias.Text.Length > 1 && checkIsBlankTextBox(txtBxAccountAlias) &&
                checkBxMetroTermsAndService.Checked)
            {
                return true;
            }
            return false;
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            //Check if data is valid, if it is, set all the variables and set validData to [true] else, [false]
            isDataValid();

            if (validData)
            {
                //Encrypts the password using SHA-384
                encryptedPassword = hashPassword(Password);

                //Add the details to the database

                //AddtoDatabase();
                MessageBox.Show("Loading.. Next.");

                //Remove the details panel
                removePanel(this);

                //Repaint Parent
                repaintParentPanel();

                //Register form progress line
                //=====================================================================
                colorProgressBar(LINE1, prtBtn2, lblPasscode);
                //=====================================================================

                //Generate passcode panel
                PasscodeUserControl passcodeUserControl = new PasscodeUserControl(this, parentRegistrationPanel, Username, Password, FirstName, MiddleName, LastName, EmailAddress, MobileNumber, AccountNumber, AccountAlias, Savings, Deposit, encryptedPassword,
                    LINE1,
                    LINE2,
                    LINE3,
                    LINE4,
                    prtBtn1,
                    prtBtn2, 
                    prtBtn3,
                    prtBtn4,
                    prtBtn5,
                    lblPasscode,
                    lblConfirmation,
                    lblVerification,
                    lblDone,
                    registerForm
                    );
                parentRegistrationPanel.Controls.Add(passcodeUserControl);

                //If user clicked the back button from passcode UC, the previous state will not be disposed.
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please make sure your details are correct.");
            }
        }

        private void colorProgressBar(Panel LINE, ReaLTaiizor.Controls.ParrotButton prtBtn, Label lbl)
        {
            prtBtn.BackgroundColor = Color.FromArgb(7, 166, 234);
            lbl.ForeColor = Color.FromArgb(7, 166, 234);

            LINE.BackColor = Color.FromArgb(7, 166, 234);
        }

        private void isDataValid()
        {
            //validData at first, is true, then execute conditions that CAN make validData to false.
            validData = true;

            if (txtBxUsername.Text != null && txtBxUsername.Text.Length > 3 && txtBxUsername.Text.Length < 20 && checkIsBlankTextBox(txtBxUsername))
            {
                Username = txtBxUsername.Text;
            }
            else
            {
                validData = false;
                MessageBox.Show("Username Invalid. Please try again.");
            }

            if (txtBxPassword.Text != null && txtBxPassword.Text.Length >= 12 && isPasswordValid && checkIsBlankTextBox(txtBxPassword))
            {
                Password = txtBxPassword.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("Password Invalid. Please try again.");
            }

            if (txtBxFirstName.Text != null && checkIsBlankTextBox(txtBxFirstName) && !containsDigits(txtBxFirstName))
            {
                FirstName = txtBxFirstName.Text;
            }
            else { validData = false; MessageBox.Show("Invalid First Name. Please try again."); }


            if (txtBxMiddleName.Text != null)
            {
                if (containsDigits(txtBxMiddleName))
                {
                    MessageBox.Show("Invalid Middle Name. Please try again.");
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
            else { validData = false; MessageBox.Show("Invalid Last Name. Please try again."); }

            if (txtBxEmailAddress.Text != null && txtBxEmailAddress.Text.Contains("@") && checkIsBlankTextBox(txtBxEmailAddress))
            {
                EmailAddress = txtBxEmailAddress.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("Invalid Email Address. Please try again.");
            }

            if (txtBxMobileNumber.Text != null && txtBxMobileNumber.Text.Length > 1 && isMobileNumberValid() && checkIsBlankTextBox(txtBxMobileNumber))
            {
                MobileNumber = mobileNumberPrefix.Text + txtBxMobileNumber.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("Invalid Mobile Number. Please try again.");
            }

            if (txtBxAccountNumber.Text != null && txtBxAccountNumber.Text.Length > 3 && checkIsBlankTextBox(txtBxAccountNumber) && !containsCharacters(txtBxAccountNumber))
            {
                AccountNumber = txtBxAccountNumber.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("Invalid Account Number. Please try again.");
            }

            if (txtBxAccountAlias.Text != null && txtBxAccountAlias.Text.Length > 1 && checkIsBlankTextBox(txtBxAccountAlias))
            {
                AccountAlias = txtBxAccountAlias.Text;

            }
            else
            {
                validData = false;
                MessageBox.Show("Invalid Account Alias. Please try again.");
            }

            if (!checkBxMetroTermsAndService.Checked)
            {
                MessageBox.Show("Terms and Service unchecked.");
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

                //Reveal the password box
                txtBxPassword.PasswordChar = '\0';

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
        //If savings button is clicked, set the savings property to 1 and deposit to 0
        private void btnSavings_Click(object sender, EventArgs e)
        {
            Savings = 1;
            Deposit = 0;
            btnSavings.BackColor = Color.FromArgb(0, 26, 136);
            btnSavings.ForeColor = Color.White;

            btnDeposit.BackColor = Color.White;
            btnDeposit.ForeColor = Color.FromArgb(0, 26, 136);
        }
        //If deposit button is clicked, set the deposit property to 1 and savings to 0
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Savings = 0;
            Deposit = 1;

            btnDeposit.BackColor = Color.FromArgb(0, 26, 136);
            btnDeposit.ForeColor = Color.White;

            btnSavings.BackColor = Color.White;
            btnSavings.ForeColor = Color.FromArgb(0, 26, 136);
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

            //==========================================================================
            if (txtBxPassword.Text.Length >= 12)
            {
                lblNumberOfCharactersReq.ForeColor = Color.Green;

                btnCheck.IconColor = Color.Green;
                btnCheck.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;

            }
            else
            {
                lblNumberOfCharactersReq.ForeColor = Color.Firebrick;

                btnCheck.IconColor = Color.Firebrick;
                btnCheck.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            }
            //==========================================================================



            //==========================================================================
            if (hasUppercase)
            {
                lblUppercaseReq.ForeColor = Color.Green;

                btnCheck2.IconColor = Color.Green;
                btnCheck2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            }
            else
            {
                lblUppercaseReq.ForeColor = Color.Firebrick;

                btnCheck2.IconColor = Color.Firebrick;
                btnCheck2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            }
            //==========================================================================



            //==========================================================================
            if (hasNumber)
            {
                lblDigitReq.ForeColor = Color.Green;

                btnCheck3.IconColor = Color.Green;
                btnCheck3.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            }
            else
            {
                lblDigitReq.ForeColor = Color.Firebrick;

                btnCheck3.IconColor = Color.Firebrick;
                btnCheck3.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            }
            //==========================================================================



            //==========================================================================
            if (hasSpecialChar)
            {
                lblSpecialCharacterReq.ForeColor = Color.Green;

                btnCheck4.IconColor = Color.Green;
                btnCheck4.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            }
            else
            {
                lblSpecialCharacterReq.ForeColor = Color.Firebrick;

                btnCheck4.IconColor = Color.Firebrick;
                btnCheck4.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            }
            //==========================================================================



            //==========================================================================
            if (txtBxPassword.Text.Length >= 12 && hasUppercase && hasNumber && hasSpecialChar)
            {
                isPasswordValid = true;
            }
        }

        //Checks if password meets the requirements
        private void txtBxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            doesPasswordMeetRequirements();
        }

        private void txtBxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            doesPasswordMeetRequirements();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            viewPasswordCount += 1;
            //If count is even, unhide password
            if (viewPasswordCount % 2 == 0)
            {
                txtBxPassword.PasswordChar = '\0';
                btnViewPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            //else hide it
            else
            {
                txtBxPassword.PasswordChar = '\u2022';
                btnViewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

        //For Checkbox click
        private void btnNextIsValid(object sender, EventArgs e)
        {
            if (keyPressDataValidation())
            {
                btnNextEnable();
            }
            else
            {
                btnNextDisable();
            }
        }
        //For Checkbox MouseClick
        private void btnNextIsValid(object sender, MouseEventArgs e)
        {
            if (keyPressDataValidation())
            {
                btnNextEnable();
            }
            else
            {
                btnNextDisable();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            registerForm.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }


        private bool CheckIfUsernameExists(string username)
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM AccountsTable WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    // If count > 0, username exists; otherwise, it doesn't
                    if (count > 0)
                    {
                        lblUserExist.Text = "Username exists already.";
                        return true;
                    }
                    lblUserExist.Text = "Username is unique.";
                    return false; 
                }
            }
        }
    }
}
