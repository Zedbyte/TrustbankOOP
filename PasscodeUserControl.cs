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
    public partial class PasscodeUserControl : UserControl
    {

        int count = 1;

        string? Passcode { get; set; }


        //Used for when user clicks the back button. (Save the state of the last panel)
        DetailsUserControl detailsPanel;

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


        //Last Panel data
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


        public PasscodeUserControl(DetailsUserControl detailsPanel, Panel parentRegistrationPanel, string Username, string Password, string FirstName, 
            string MiddleName, string LastName, string EmailAddress, string MobileNumber, string AccountNumber, string AccountAlias, int Savings, int Deposit, string encryptedPassword,
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
            InitializeComponent();
            btnNextDisable();

            this.detailsPanel = detailsPanel;

            this.parentRegistrationPanel = parentRegistrationPanel;

            this.Username = Username;
            this.Password = Password;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.MobileNumber = MobileNumber;
            this.AccountNumber = AccountNumber;
            this.AccountAlias = AccountAlias;
            this.Savings = Savings;
            this.Deposit = Deposit;
            this.encryptedPassword = encryptedPassword;

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
            if (containsDigits(txtBxPasscode1) && containsDigits(txtBxPasscode2) && containsDigits(txtBxPasscode3) &&
                containsDigits(txtBxPasscode4) && containsDigits(txtBxPasscode5) && containsDigits(txtBxPasscode6))
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

        private void btnShowPasscode_Click(object sender, EventArgs e)
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

        private void removePanel(Control panel)
        {
            parentRegistrationPanel.Controls.Remove(panel);
        }

        private void repaintParentPanel()
        {
            parentRegistrationPanel.Refresh();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Passcode = txtBxPasscode1.Text + txtBxPasscode2.Text + txtBxPasscode3.Text + txtBxPasscode4.Text + txtBxPasscode5.Text + txtBxPasscode6.Text;

            removePanel(this);
            repaintParentPanel();


            colorProgressBar(LINE2, prtBtn3, lblConfirmation);

            ConfirmationUserControl confirmationUserControl = new ConfirmationUserControl(Username, Password, FirstName, MiddleName, LastName, 
                EmailAddress, MobileNumber, AccountNumber, AccountAlias, Passcode, Savings, Deposit, encryptedPassword, 
                detailsPanel,
                this,
                parentRegistrationPanel,
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
                lblDone
                );

            confirmationUserControl.Show();
            parentRegistrationPanel.Controls.Add(confirmationUserControl);

            //Hide this panel, so if user went back from confirmation to passcode, the state will not be removed.
            this.Hide();
        }

        private void colorProgressBar(Panel LINE, ReaLTaiizor.Controls.ParrotButton prtBtn, Label lbl)
        {
            prtBtn.BackgroundColor = Color.FromArgb(7, 166, 234);
            lbl.ForeColor = Color.FromArgb(7, 166, 234);

            LINE.BackColor = Color.FromArgb(7, 166, 234);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            removePanel(this);
            //Dispose this panel and any state
            this.Dispose();

            //Add the previous detail panel
            parentRegistrationPanel.Controls.Add(detailsPanel);
            //Unhide it
            detailsPanel.Show();
            //Repaint the parent registration panel
            repaintParentPanel();

            removeColorProgressBar(LINE1, prtBtn2, lblPasscode);
        }

        private void removeColorProgressBar(Panel LINE, ReaLTaiizor.Controls.ParrotButton prtBtn, Label lbl)
        {
            prtBtn.BackgroundColor = Color.FromArgb(149, 149, 149);
            lbl.ForeColor = Color.FromArgb(149, 149, 149);

            LINE.BackColor = Color.FromArgb(149, 149, 149);
        }
    }
}
