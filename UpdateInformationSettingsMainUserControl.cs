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
    public partial class UpdateInformationSettingsMainUserControl : UserControl
    {

        Panel parentContainerPanel;
        string? id { get; set; }

        string? Username { get; set; }

        string? EncryptedPassword { get; set; }

        string? EmailAddress { get; set; }

        string? MobileNumber { get; set; }


        string? NewUserName { get; set; }

        string? NewPassword { get; set; }

        string? NewEmailAddress { get; set; }

        string? NewMobileNumber { get; set; }

        bool usernameChanged = false;

        bool passwordChanged = false;

        bool emailChanged = false;

        bool mobileChanged = false;

        int usernameChangeCount = 0;

        int passwordChangeCount = 0;

        int emailChangeCount = 0;

        int mobileChangeCount = 0;



        bool usernameValid = true;
        bool passwordValid = true;
        bool emailValid = true;
        bool mobileValid = true;

        public UpdateInformationSettingsMainUserControl(Panel parentContainerPanel, string id, string username, string encryptedPassword, string emailAddress, string mobileNumber)
        {
            InitializeComponent();
            this.ActiveControl = btnSave;

            this.parentContainerPanel = parentContainerPanel;
            this.id = id;
            this.Username = username;
            this.EncryptedPassword = encryptedPassword;
            this.EmailAddress = emailAddress;
            this.MobileNumber = mobileNumber;

            //If there are no changes just use the previous data
            this.NewUserName = Username;
            this.NewPassword = EncryptedPassword;
            this.NewEmailAddress = EmailAddress;
            this.NewMobileNumber = MobileNumber;

            //Disable these buttons when no changes are made
            btnSave.Enabled = false;
            btnSave.BackColor = Color.DimGray;
            btnSave.ForeColor = Color.White;
            btnUpdate.Enabled = false;

            setTextboxDetails();
        }



        private void setTextboxDetails()
        {
            txtBxUsernamePlaceholder.Text = Username;
            txtBxPasswordPlaceholder.Text = EncryptedPassword;
            txtBxEmailPlaceholder.Text = EmailAddress;
            txtBxMobileNumberPlaceholder.Text = MobileNumber;
        }

        private void btnEditUsername_Click(object sender, EventArgs e)
        {
            txtBxUsernamePlaceholder.ReadOnly = false;
            btnCancel.Visible = true;
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            txtBxPasswordPlaceholder.ReadOnly = false;
            txtBxPasswordPlaceholder.Text = "";
            btnCancel.Visible = true;
        }

        private void btnEditMobileNumber_Click(object sender, EventArgs e)
        {
            txtBxMobileNumberPlaceholder.ReadOnly = false;
            btnCancel.Visible = true;
        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            txtBxEmailPlaceholder.ReadOnly = false;
            btnCancel.Visible = true;
        }

        private void txtBxUsernamePlaceholder_TextChanged(object sender, EventArgs e)
        {
            //Initially username change is 0, when the constructor fills the texbtox with texts, this event is invoked so it becomes 1, then the next invocations will come now from the user.
            usernameChangeCount += 1;

            if (usernameChangeCount == 2)
            {
                usernameChanged = true;
                enableButtons();

                usernameChangeCount = 1;
            }
        }

        private void txtBxPasswordPlaceholder_TextChanged(object sender, EventArgs e)
        {
            passwordChangeCount += 1;

            if (passwordChangeCount == 2)
            {
                passwordChanged = true;
                enableButtons();

                passwordChangeCount = 1;
            }

        }

        private void txtBxMobileNumberPlaceholder_TextChanged(object sender, EventArgs e)
        {
            mobileChangeCount += 1;

            if (mobileChangeCount == 2)
            {
                mobileChanged = true;
                enableButtons();

                mobileChangeCount = 1;
            }
        }


        private void txtBxEmailPlaceholder_TextChanged(object sender, EventArgs e)
        {
            emailChangeCount += 1;

            if (emailChangeCount == 2)
            {
                emailChanged = true;
                enableButtons();

                emailChangeCount = 1;
            }
        }






















        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (usernameChanged)
            {
                if (keyPressDataValidationUsername())
                {
                    NewUserName = txtBxUsernamePlaceholder.Text;
                    usernameValid = true;

                    txtBxUsernamePlaceholder.ReadOnly = true;
                    btnSave.Enabled = true;
                }
                else
                {
                    txtBxUsernamePlaceholder.Text = Username;

                    usernameValid = false;
                    btnSave.Enabled = false;
                    txtBxUsernamePlaceholder.ReadOnly = true;
                    MessageBox.Show("Username Invalid");
                }
            }


            if (passwordChanged)
            {
                if (doesPasswordMeetRequirements())
                {
                    NewPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txtBxPasswordPlaceholder.Text);
                    passwordValid = true;
                    txtBxPasswordPlaceholder.ReadOnly = true;
                    btnSave.Enabled = true;
                }
                else
                {
                    txtBxPasswordPlaceholder.Text = EncryptedPassword;

                    passwordValid = false;
                    btnSave.Enabled = false;
                    txtBxPasswordPlaceholder.ReadOnly = true;
                    MessageBox.Show("Password Invalid!");
                }
            }

            if (mobileChanged)
            {
                if (keyPressValidationMobileNumber() && txtBxMobileNumberPlaceholder.Text.Contains("+63"))
                {
                    NewMobileNumber = txtBxMobileNumberPlaceholder.Text;
                    mobileValid = true;

                    txtBxMobileNumberPlaceholder.ReadOnly = true;
                    btnSave.Enabled = true;
                }
                else
                {
                    txtBxMobileNumberPlaceholder.Text = MobileNumber;

                    mobileValid = false;
                    btnSave.Enabled = false;
                    txtBxMobileNumberPlaceholder.ReadOnly = true;
                    MessageBox.Show("Mobile Invalid!");
                }
            }

            if (emailChanged)
            {
                if (keyPressDataValidationEmailAddress())
                {
                    NewEmailAddress = txtBxEmailPlaceholder.Text;
                    emailValid = true;
                    txtBxEmailPlaceholder.ReadOnly = true;
                    btnSave.Enabled = true;
                }
                else
                {
                    txtBxEmailPlaceholder.Text = EmailAddress;

                    emailValid = false;
                    btnSave.Enabled = false;
                    txtBxEmailPlaceholder.ReadOnly = true;
                    MessageBox.Show("Email Invalid!");
                }
            }

            disableButtons();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (usernameValid && passwordValid && mobileValid && emailValid)
            {
                OTPConfirmTransaction confirmTransaction = new OTPConfirmTransaction(id, EmailAddress);


                var result = confirmTransaction.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        UpdateData();
                        parentContainerPanel.Controls.Clear();

                        AccountsMainUserControl accountsMainUserControl = new AccountsMainUserControl(parentContainerPanel, id);
                        accountsMainUserControl.Show();


                        parentContainerPanel.Controls.Add(accountsMainUserControl);

                        this.Dispose();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Something went wrong with updating data.");
                    }
                }
                else
                {
                    MessageBox.Show("OTP did not match");
                }
            }
            else
            {
                MessageBox.Show("Username: " + usernameValid.ToString() + "Password: " + passwordValid.ToString() + "Mobile: " + mobileValid.ToString() + "Email: " + emailValid.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parentContainerPanel.Controls.Clear();
            UpdateInformationSettingsMainUserControl updateInformationSettingsMainUserControl = new UpdateInformationSettingsMainUserControl(parentContainerPanel, id, Username, EncryptedPassword, EmailAddress, MobileNumber);
            updateInformationSettingsMainUserControl.Show();

            parentContainerPanel.Controls.Add(updateInformationSettingsMainUserControl);
            parentContainerPanel.Refresh();

            this.Dispose();

        }





        private void enableButtons()
        {
            btnUpdate.Enabled = true;
            btnSave.Enabled = true;
        }

        private void disableButtons()
        {
            btnUpdate.Enabled = false;
            btnUpdate.ForeColor = Color.White;
            btnCancel.Visible = false;
        }



        private bool keyPressDataValidationUsername()
        {
            if (!txtBxUsernamePlaceholder.Text.Equals(Username) && txtBxUsernamePlaceholder.Text != "" && !CheckIfUsernameExists(txtBxUsernamePlaceholder.Text) && txtBxUsernamePlaceholder.Text.Length > 3 && txtBxUsernamePlaceholder.Text.Length < 20)
            {
                return true;
            }
            return false;
        }

        private bool keyPressDataValidationEmailAddress()
        {
            if (!txtBxEmailPlaceholder.Text.Equals(EmailAddress) && txtBxEmailPlaceholder.Text != "" && txtBxEmailPlaceholder.Text.Contains("@") && !AccountEmailExist(txtBxEmailPlaceholder.Text))
            {
                return true;
            }
            return false;
        }

        private bool keyPressValidationMobileNumber()
        {
            if (!txtBxMobileNumberPlaceholder.Text.Equals(MobileNumber) && txtBxMobileNumberPlaceholder.Text != "" && txtBxMobileNumberPlaceholder.Text.Length > 1 && isMobileNumberValid() && !MobileNumberExist(txtBxMobileNumberPlaceholder.Text))
            {
                return true;
            }
            return false;
        }

        private bool isMobileNumberValid()
        {
            bool hasLetters = Regex.IsMatch(txtBxMobileNumberPlaceholder.Text, "[A-Za-z$!@#%,^.`~]");
            if (txtBxMobileNumberPlaceholder.Text.StartsWith("0") || hasLetters)
            {
                return false;
            }

            return true;
        }


        private void UpdateData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(@"UPDATE AccountsTable SET Username = @username, Password = @password ,EmailAddress = @email_address, MobileNumber = @mobile_number WHERE id = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@username", NewUserName);
                    cmd.Parameters.AddWithValue("@password", NewPassword);
                    cmd.Parameters.AddWithValue("@email_address", NewEmailAddress);
                    cmd.Parameters.AddWithValue("@mobile_number", NewMobileNumber);
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show("Update Successfully!");
                }
            }
        }


        private bool doesPasswordMeetRequirements()
        {
            // Regular expressions to check for at least one uppercase, one number, and one special character
            bool hasUppercase = Regex.IsMatch(txtBxPasswordPlaceholder.Text, "[A-Z]");
            bool hasNumber = Regex.IsMatch(txtBxPasswordPlaceholder.Text, "[0-9]");
            bool hasSpecialChar = Regex.IsMatch(txtBxPasswordPlaceholder.Text, "[@$&#/~%*,^<>?!.:;']");

            if (txtBxPasswordPlaceholder.Text.Length >= 12 && hasUppercase && hasNumber && hasSpecialChar)
            {
                return true;
            }
            return false;

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
                        lblUserExist.ForeColor = Color.Firebrick;
                        return true;
                    }
                    lblUserExist.Text = "Username is unique.";
                    lblUserExist.ForeColor = Color.LimeGreen;
                    return false;
                }
            }
        }


        private bool MobileNumberExist(string mobileNumber)
        {

            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM AccountsTable WHERE MobileNumber = @mobile_number";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mobile_number", "+63" + mobileNumber);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    // If count > 0, username exists; otherwise, it doesn't
                    if (count > 0)
                    {
                        lblMobileNumberExist.Text = "Mobile Number exists already.";
                        lblMobileNumberExist.ForeColor = Color.Firebrick;
                        return true;
                    }
                }
            }

            // Strings not found in any row
            lblMobileNumberExist.Text = "Mobile Number is unique.";
            lblMobileNumberExist.ForeColor = Color.LimeGreen;
            return false;
        }


        private bool AccountEmailExist(string emailAddress)
        {

            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM AccountsTable WHERE EmailAddress = @email_address";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email_address", emailAddress);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    // If count > 0, username exists; otherwise, it doesn't
                    if (count > 0)
                    {
                        lblEmailExist.Text = "Email Address exists already.";
                        lblEmailExist.ForeColor = Color.Firebrick;
                        return true;
                    }
                }
            }

            // Strings not found in any row
            lblEmailExist.Text = "Email Address is ready to use.";
            lblEmailExist.ForeColor = Color.LimeGreen;
            return false;
        }


        int viewPassCount = 1;
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            viewPassCount += 1;

            if (viewPassCount % 2 == 0) 
            {
                txtBxPasswordPlaceholder.PasswordChar = '\0';
                btnShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                txtBxPasswordPlaceholder.PasswordChar = '\u2022';
                btnShowPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }


















        /*        private bool containsCharacters(TextBox txtbx)
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
                }*/

    }
}
