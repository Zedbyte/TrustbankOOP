using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vonage;
using Vonage.Request;
using System.Text.RegularExpressions;

namespace Trustbank
{
    public partial class VerificationUserControl : UserControl
    {

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

        string? Passcode { get; set; }

        //Used for when user clicks the back button. (Save the state of the last panel)
        DetailsUserControl detailsPanel;

        //Used for when user clicks the back button. (Save the state of the last panel)
        PasscodeUserControl passcodeUserControl;

        //Used for when user clicks the back button. (Save the state of the last panel)
        ConfirmationUserControl confirmationUserControl;

        Panel parentRegistrationPanel;

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

        int timeCount;
        int expirationEmail;

        //For show OTP button
        int count;

        string? generatedOTPEmail;

        public VerificationUserControl(String Username, string Password, string FirstName, string MiddleName, string LastName,
            string EmailAddress, string MobileNumber, string AccountNumber, string AccountAlias,
            string Passcode, int Savings, int Deposit, string encryptedPassword,
            DetailsUserControl detailsPanel,
            PasscodeUserControl passcodeUserControl,
            ConfirmationUserControl confirmationUserControl,
            Panel parentRegistrationPanel,
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
            Label lblDone
            )
        {
            //Save the details
            this.Username = Username;
            this.Password = Password;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.MobileNumber = MobileNumber;
            this.AccountNumber = AccountNumber;
            this.AccountAlias = AccountAlias;
            this.Passcode = Passcode;
            this.Savings = Savings;
            this.Deposit = Deposit;
            this.encryptedPassword = encryptedPassword;

            //Save the panels
            this.detailsPanel = detailsPanel;
            this.passcodeUserControl = passcodeUserControl;
            this.confirmationUserControl = confirmationUserControl;
            this.parentRegistrationPanel = parentRegistrationPanel;

            //Save the lines of the registration form
            this.LINE1 = LINE1;
            this.LINE2 = LINE2;
            this.LINE3 = LINE3;
            this.LINE4 = LINE4;

            this.prtBtn1 = prtBtn1;
            this.prtBtn2 = prtBtn2;
            this.prtBtn3 = prtBtn3;
            this.prtBtn4 = prtBtn4;
            this.prtBtn5 = prtBtn5;

            this.lblPasscode = lblPasscode;
            this.lblConfirmation = lblConfirmation;
            this.lblVerification = lblVerification;
            this.lblDone = lblDone;

            InitializeComponent();
            setEmailPlaceholder();
            btnNextDisable();

            SendOTPToEmai();
        }

        private void setEmailPlaceholder()
        {
            char[] emailArray = EmailAddress.ToCharArray();
            string censoredEmail = "";
            for (int i = 0; i < emailArray.Length; i++)
            {
                if (i >= 3 && i <= emailArray.Length - 5)
                {
                    censoredEmail += "*";
                }
                else
                {
                    censoredEmail += emailArray[i];
                }
            }

            lblEmailPlaceholder.Text = censoredEmail;
        }

        private void lblSendAnotherOTP_Click(object sender, EventArgs e)
        {
            MobileVerification mobileVerification = new MobileVerification();
            mobileVerification.ShowDialog();
        }

        private void SendOTPToEmai()
        {

            generatedOTPEmail = $"{DateTime.Now.Second:D2}{DateTime.Now.Millisecond:D4}";

            timerEmail.Stop();
            string to, from, pass, mail;
            to = EmailAddress;
            from = "senseiintelli@gmail.com";
            mail = timerEmail.ToString();
            pass = "pzqy ezsz cirh zsrn";

            MailMessage msg = new MailMessage();
            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = "Thank you for choosing TrustBank. Your One-Time Password (OTP) for a secure transaction is: " + generatedOTPEmail + " Please use this OTP within the next 10 minutes.\n" +
                "For security reasons, DO NOT share this OTP with anyone, including TrustBank representatives. We will never ask for your OTP over the phone, via email, or through any other means.\n\nIf you suspect any unauthorized access or activity, please contact our customer support immediately at www.trustbank.com/costumersupport.";
            msg.Subject = "TrustBank One-Time Password (OTP)";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Email does not exist.");
            }
        }



        private void timerEmail_Tick(object sender, EventArgs e)
        {
            timeCount += 10;
            if (timeCount == 9999)
            {
                timeCount = 1000;
            }
        }

        private void expiration_Tick(object sender, EventArgs e)
        {
            expirationEmail += 1;

            if (expirationEmail == 600)
            {
                generatedOTPEmail = null;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string userInputOTP = txtBxOTP1.Text + txtBxOTP2.Text + txtBxOTP3.Text + txtBxOTP4.Text + txtBxOTP5.Text + txtBxOTP6.Text;
            if (generatedOTPEmail != null && userInputOTP.Equals(generatedOTPEmail))
            {
                //Done Form

            }
            else
            {
                MessageBox.Show("Your input might not match the OTP generated or has already expired. Please try again.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

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
            if (containsDigits(txtBxOTP1) && containsDigits(txtBxOTP2) && containsDigits(txtBxOTP3) &&
                containsDigits(txtBxOTP4) && containsDigits(txtBxOTP5) && containsDigits(txtBxOTP6))
            {
                btnNextEnable();
            }
            else
            {
                btnNextDisable();
            }
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

        private void removePanel(Control panel)
        {
            parentRegistrationPanel.Controls.Remove(panel);
        }

        private void repaintParentPanel()
        {
            parentRegistrationPanel.Refresh();
        }

        private void btnShowOTP_Click_1(object sender, EventArgs e)
        {
            count += 1;

            if (count % 2 == 0)
            {
                foreach (TextBox txtbx in passcodeTextboxesPanel.Controls)
                {
                    txtbx.PasswordChar = '\0';
                }
            }
            else
            {
                foreach (TextBox txtbx in passcodeTextboxesPanel.Controls)
                {
                    txtbx.PasswordChar = '\u2022';
                }
            }
        }


    }
}
