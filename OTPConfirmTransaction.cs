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
using System.Text.RegularExpressions;

namespace Trustbank
{
    public partial class OTPConfirmTransaction : Form
    {
        bool OTPMatch { get; set; }

        string? id { get; set; }

        string? EmailAddress { get; set; }


        string? generatedOTPEmail;

        int timeCount;
        int expirationEmail;

        public OTPConfirmTransaction(string id, string EmailAddress)
        {
            InitializeComponent();

            this.id = id;
            this.EmailAddress = EmailAddress;
            setEmailLabel();
            SendOTPToEmail();
        }

        private void setEmailLabel()
        {
            lblEmailAddressPlaceholder.Text = EmailAddress;
        }

        private void isOTPValid(object sender, KeyEventArgs e)
        {
            if (containsDigits(txtBxOTP1) && containsDigits(txtBxOTP2) && containsDigits(txtBxOTP3) && containsDigits(txtBxOTP4) && containsDigits(txtBxOTP5) && containsDigits(txtBxOTP6))
            {
                string userOTP = txtBxOTP1.Text + txtBxOTP2.Text + txtBxOTP3.Text + txtBxOTP4.Text + txtBxOTP5.Text + txtBxOTP6.Text;

                if (userOTP.Equals(generatedOTPEmail))
                {
                    this.OTPMatch = true;
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Verification Success!");
                    this.Close();
                }
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



        private void SendOTPToEmail()
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
    }
}
