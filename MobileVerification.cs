using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vonage.Request;
using Vonage;
using System.Text.RegularExpressions;

namespace Trustbank
{
    public partial class MobileVerification : Form
    {

        string? generatedOTPSMS;

        public bool IsUserMatchOTP { get; set; }

        string? MobileNumber { get; set; }

        string filteredMobileNumber = "";

        int SMSCount = 0;
        public MobileVerification(string MobileNumber)
        {
            InitializeComponent();

            this.MobileNumber = MobileNumber;

            btnNextDisable();
            setMobileNumberPlaceholder();
            //sendOTPToPhoneNumber();
        }

        /*  private async void sendOTPToPhoneNumber()
          {
              getMobileNumber();
              generatedOTPSMS = $"{DateTime.Now.Second:D2}{DateTime.Now.Millisecond:D4}";

              var credentials = Credentials.FromApiKeyAndSecret(
             "46914d6a",
             "M4l0APmsj2Ulc8Qs"
             );

              var VonageClient = new VonageClient(credentials);

              var response = VonageClient.SmsClient.SendAnSmsAsync(new Vonage.Messaging.SendSmsRequest()
              {
                  To = filteredMobileNumber,
                  From = "Vonage APIs",
                  Text = generatedOTPSMS 
              });
          }*/

        //This method must be async or else the GUI will freeze with no errors.
        private async Task SendOTPToPhoneNumber()
        {
            await GetMobileNumberAsync();

            generatedOTPSMS = $"{DateTime.Now.Second:D2}{DateTime.Now.Millisecond:D4}";

            var credentials = Credentials.FromApiKeyAndSecret("46914d6a", "M4l0APmsj2Ulc8Qs");

            var VonageClient = new VonageClient(credentials);

            var response = await VonageClient.SmsClient.SendAnSmsAsync(new Vonage.Messaging.SendSmsRequest()
            {
                To = filteredMobileNumber,
                From = "Trustbank",
                Text = generatedOTPSMS
            });
        }

        /*  private void getMobileNumber()
          {
              filteredMobileNumber = MobileNumber.Substring(1);
              MessageBox.Show(filteredMobileNumber);
          }*/

        private async Task GetMobileNumberAsync()
        {
            filteredMobileNumber = MobileNumber.Substring(1);
            MessageBox.Show(filteredMobileNumber);
            await Task.Yield(); // Simulating an asynchronous operation
        }

        private void setMobileNumberPlaceholder()
        {
            char[] numArray = MobileNumber.ToCharArray();
            string censoredMobileNumber = "";

            for (int i = 0; i < numArray.Length; i++)
            {
                if (i >= 3 && i <= numArray.Length - 5)
                {
                    censoredMobileNumber += "*";
                }
                else
                {
                    censoredMobileNumber += numArray[i];
                }
            }

            lblMobileNumPlaceholder.Text = censoredMobileNumber;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userInputOTP = txtBxOTP1.Text + txtBxOTP2.Text + txtBxOTP3.Text + txtBxOTP4.Text + txtBxOTP5.Text + txtBxOTP6.Text;
            if (generatedOTPSMS != null && userInputOTP.Equals(generatedOTPSMS))
            {
                IsUserMatchOTP = true;
                this.Close();
            }
            else
            {
                SMSCount += 1;
                MessageBox.Show("Your input might not match the OTP generated or has already expired. Please try again.");

                if (SMSCount == 3)
                {
                    MessageBox.Show("You reached the limit of attempts. Please try again later.");
                    this.Dispose();
                }
            }
        }

        private void btnNextDisable()
        {
            btnSubmit.Enabled = false;
            btnSubmit.BackColor = Color.DimGray;
            btnSubmit.ForeColor = Color.White;
        }

        private void btnNextEnable()
        {
            btnSubmit.Enabled = true;
            btnSubmit.BackColor = Color.FromArgb(0, 26, 136);
            btnSubmit.ForeColor = Color.White;
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

        private async void lblSendAnotherOTP_Click(object sender, EventArgs e)
        {
            await SendOTPToPhoneNumber();
        }

        private void lblSendAnotherOTP_MouseEnter(object sender, EventArgs e)
        {
            lblSendAnotherOTP.ForeColor = Color.DarkBlue;
        }

        private void lblSendAnotherOTP_MouseLeave(object sender, EventArgs e)
        {
            lblSendAnotherOTP.ForeColor = Color.FromArgb(7, 166, 234);
        }
    }
}
