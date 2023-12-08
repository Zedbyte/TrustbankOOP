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
    public partial class DoneUserControl : UserControl
    {
        RegisterForm registerForm;

        public DoneUserControl(RegisterForm registerForm)
        {
            InitializeComponent();

            this.registerForm = registerForm;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            registerForm.Dispose();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
