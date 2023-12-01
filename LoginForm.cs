using ReaLTaiizor.Forms;

namespace Trustbank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //Remove automatic focus to child controls (textbox)
            this.ActiveControl = HEADERLBLONLY;
        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
            //Remove focus from the textbox when clicked
            this.ActiveControl = HEADERLBLONLY;
        }

        private void LoginPanel_Click(object sender, EventArgs e)
        {
            //Remove focus from the textbox when clicked
            this.ActiveControl = HEADERLBLONLY;
        }

        //For the shutdown symbol at the top right
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //When hovering the Sign Up label, change the color.
        private void btnLblSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnLblSignUp.ForeColor = Color.FromArgb(102, 117, 183);
            btnLblSignUp.Font = new Font(btnLblSignUp.Font.FontFamily, btnLblSignUp.Font.SizeInPoints, FontStyle.Underline);
        }

        private void btnLblSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnLblSignUp.ForeColor = Color.FromArgb(0, 26, 136);
            btnLblSignUp.Font = new Font(btnLblSignUp.Font.FontFamily, btnLblSignUp.Font.SizeInPoints, FontStyle.Regular);
        }

        //======================================================


        //When hovering the Recover Access label, change the color.
        private void btnLblRecoverAccess_MouseEnter(object sender, EventArgs e)
        {
            btnLblRecoverAccess.ForeColor = Color.FromArgb(102, 117, 183);
            btnLblRecoverAccess.Font = new Font(btnLblRecoverAccess.Font.FontFamily, btnLblRecoverAccess.Font.SizeInPoints, FontStyle.Underline);
        }

        private void btnLblRecoverAccess_MouseLeave(object sender, EventArgs e)
        {
            btnLblRecoverAccess.ForeColor = Color.FromArgb(0, 26, 136);
            btnLblRecoverAccess.Font = new Font(btnLblRecoverAccess.Font.FontFamily, btnLblRecoverAccess.Font.SizeInPoints, FontStyle.Regular);
        }

    }
}