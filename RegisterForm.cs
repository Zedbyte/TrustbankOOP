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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            setParent();
        }

        //Set the parent property of the label and picture box above. This is for the transparent property.
        private void setParent()
        {
            TRUSTBANKLBLONLY.Parent = signUpHeaderImage;
            HEADERLBLONLY.Parent = signUpHeaderImage;
            TRUSTBANKLOGO.Parent = signUpHeaderImage;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Height = 790;
        }
    }
}
