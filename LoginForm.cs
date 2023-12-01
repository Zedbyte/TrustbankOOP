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
    }
}
