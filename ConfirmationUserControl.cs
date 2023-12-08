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
    public partial class ConfirmationUserControl : UserControl
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

        int viewPasscodeCount = 1;

        int viewPasswordCount = 1;

        //Used for when user clicks the back button. (Save the state of the last panel)
        DetailsUserControl detailsPanel;

        //Used for when user clicks the back button. (Save the state of the last panel)
        PasscodeUserControl passcodeUserControl;

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

        public ConfirmationUserControl(String Username, string Password, string FirstName, string MiddleName, string LastName,
            string EmailAddress, string MobileNumber, string AccountNumber, string AccountAlias,
            string Passcode, int Savings, int Deposit, string encryptedPassword,
            DetailsUserControl detailsPanel,
            PasscodeUserControl passcodeUserControl,
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
            InitializeComponent();

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

            this.detailsPanel = detailsPanel;
            this.passcodeUserControl = passcodeUserControl;
            this.parentRegistrationPanel = parentRegistrationPanel;

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


            InitializeLabelConfirmation();
        }

        private void InitializeLabelConfirmation()
        {
            lblUsername.Text = Username;

            txtBxPasswordFill.Text = Password;

            lblFirstName.Text = FirstName;
            lblMiddleName.Text = MiddleName;
            lblLastName.Text = LastName;
            lblEmailAddress.Text = EmailAddress;
            lblMobileNumber.Text = MobileNumber;
            lblAccountNumber.Text = AccountNumber;
            lblAccountAlias.Text = AccountAlias;

            txtBxPasscodeFill.Text = Passcode;

            if (Savings == 1)
            {
                btnSavingsOrDeposit.Text = "Savings Account";
                btnSavingsOrDeposit.ForeColor = Color.White;
            }
            else
            {
                btnSavingsOrDeposit.Text = "Deposit Account";
                btnSavingsOrDeposit.ForeColor = Color.White;
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
            removePanel(this);
            repaintParentPanel();


            colorProgressBar(LINE3, prtBtn4, lblVerification);

            VerificationUserControl verificationUserControl = new VerificationUserControl(Username, Password, FirstName, MiddleName, LastName,
                EmailAddress, MobileNumber, AccountNumber, AccountAlias, Passcode, Savings, Deposit, encryptedPassword,
                detailsPanel,
                passcodeUserControl,
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


            verificationUserControl.Show();
            parentRegistrationPanel.Controls.Add(verificationUserControl);

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
            parentRegistrationPanel.Controls.Add(passcodeUserControl);
            //Unhide it
            passcodeUserControl.Show();
            //Repaint the parent registration panel
            repaintParentPanel();

            removeColorProgressBar(LINE2, prtBtn3, lblConfirmation);
        }

        private void removeColorProgressBar(Panel LINE, ReaLTaiizor.Controls.ParrotButton prtBtn, Label lbl)
        {
            prtBtn.BackgroundColor = Color.FromArgb(149, 149, 149);
            lbl.ForeColor = Color.FromArgb(149, 149, 149);

            LINE.BackColor = Color.FromArgb(149, 149, 149);
        }

        private void btnShowPasscode_Click(object sender, EventArgs e)
        {
            viewPasscodeCount += 1;

            if (viewPasscodeCount % 2 == 0)
            {
                txtBxPasscodeFill.PasswordChar = '\0';
                btnShowPasscode.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                txtBxPasscodeFill.PasswordChar = '\u2022';
                btnShowPasscode.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            viewPasswordCount += 1;

            if (viewPasswordCount % 2 == 0)
            {
                txtBxPasswordFill.PasswordChar = '\0';
                btnViewPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                txtBxPasswordFill.PasswordChar = '\u2022';
                btnViewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

    }
}
