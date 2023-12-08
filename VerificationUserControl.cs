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
        }


        private void SendOTPToEmai()
        {

        }


    }
}
