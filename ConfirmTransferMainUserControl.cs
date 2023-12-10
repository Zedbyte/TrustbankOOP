using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class ConfirmTransferMainUserControl : UserControl
    {
        string? id { get; set; }

        string? Contact_ID { get; set; }

        string? CompleteName { get; set; }

        string? AccountNumber { get; set; }
        
        string? EmailAddress { get; set; }

        double Amount { get; set; }

        double ChargeFee { get; set; }

        string? RecipientName { get; set; }

        string? RecipientBankName { get; set; }

        string? RecipientAccountNumber { get; set; }

        string? RecipientEmailAddress { get; set; }

        string? Purpose { get; set; }

        public ConfirmTransferMainUserControl(string id, string contact_id, string completeName, string accountNumber, string emailAddress, double amount, double chargeFee,
            string recipientName,
            string recipientBankName,
            string recipientAccountNumber,
            string recipientEmailAddress,
            string purpose)
        {
            InitializeComponent();

            this.id = id;

            this.Contact_ID = contact_id;

            this.CompleteName = completeName;

            this.AccountNumber = accountNumber;

            this.EmailAddress = emailAddress;

            this.Amount = amount;

            this.ChargeFee = chargeFee;

            this.RecipientName = recipientName;

            this.RecipientBankName = recipientBankName;

            this.RecipientAccountNumber = recipientAccountNumber;

            this.RecipientEmailAddress = recipientEmailAddress;

            this.Purpose = purpose;


            setUserLabelDetails();
            setAmountAndChargeLabelDetails();
            setRecipientLabelDetails();

        }


        private void setUserLabelDetails()
        {
            lblNamePlaceholder.Text = CompleteName;
            lblAccountNumberPlaceholder.Text = AccountNumber;
            lblPurposePlaceholder.Text = Purpose;
        }

        private void setAmountAndChargeLabelDetails()
        {
            lblAmountPlaceholder.Text = Amount.ToString();
            lblChargeFee.Text = ChargeFee.ToString();
        }

        private void setRecipientLabelDetails()
        {
            lblRecipientNamePlaceholder.Text = RecipientName;
            lblRecipientBankPlaceholder.Text = RecipientBankName;
            lblRecipientAccountNumber.Text = RecipientAccountNumber;
            lblRecipientEmailAddress.Text = RecipientEmailAddress;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OTPConfirmTransaction confirmTransaction = new OTPConfirmTransaction(id, EmailAddress);
            var result = confirmTransaction.ShowDialog();

            if (result == DialogResult.OK) 
            {
                MessageBox.Show("NICE WAN LODICAKEZ!!!!");
            }
            else
            {
                MessageBox.Show("OTP did not match");
            }
        }
    }
}
