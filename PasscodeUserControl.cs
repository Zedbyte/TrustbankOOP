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


        public PasscodeUserControl(DetailsUserControl detailsPanel, Panel parentRegistrationPanel, String Username, String Password, String FirstName, 
            String MiddleName, String LastName, String EmailAddress, String MobileNumber, String AccountNumber, String AccountAlias, int Savings, int Deposit, String encryptedPassword)
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
                    txtbx.PasswordChar = '\u2022';
                }
            }
            else
            {
                foreach (TextBox txtbx in passcodeTextboxesPanel.Controls)
                {
                    txtbx.PasswordChar = '\0';
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
        }
    }
}
