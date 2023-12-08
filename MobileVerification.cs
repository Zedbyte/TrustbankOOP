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

namespace Trustbank
{
    public partial class MobileVerification : Form
    {
        public MobileVerification()
        {
            InitializeComponent();
            sendOTPToPhoneNumber();
        }

        private void sendOTPToPhoneNumber()
        {
            var credentials = Credentials.FromApiKeyAndSecret(
           "46914d6a",
           "M4l0APmsj2Ulc8Qs"
           );

            var VonageClient = new VonageClient(credentials);

            var response = VonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
            {
                To = "639459739188",
                From = "Vonage APIs",
                Text = "TrustBank: Your One-Time Password (OTP) for a secure transaction is: " + generatedOTPSMS +
                " Use this OTP within 10 mins. DO NOT share this code with anyone, including TrustBank representatives. Contact us at www.trustbank.com/costumersupport for assistance."
            });
        }
    }
}
