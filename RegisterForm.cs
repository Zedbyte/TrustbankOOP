using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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

            DetailsUserControl detailPanel = new DetailsUserControl(parentRegistrationPanel, HEADERLBLONLY, this);
            parentRegistrationPanel.Controls.Add(detailPanel);
            parentRegistrationPanel.Refresh();
        }

        //Set the parent property of the label and picture box above. This is for the transparent property.
        private void setParent()
        {
            TRUSTBANKLBLONLY.Parent = signUpHeaderImage;
            HEADERLBLONLY.Parent = signUpHeaderImage;
            TRUSTBANKLOGO.Parent = signUpHeaderImage;
        }

        private void setFocusToOther(object sender, EventArgs e)
        {
            this.ActiveControl = HEADERLBLONLY;
        }

    }
}
