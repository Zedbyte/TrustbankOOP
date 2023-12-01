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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class RegisterForm : Form
    {

        bool validData = true;


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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[AccountsTB] 
            (
            [Username], 
            [Password], 
            [FirstName], 
            [MiddleName], 
            [LastName],
            [EmailAddress], 
            [MobileNumber], 
            [Savings],
            [Deposit],
            [AccountNumber],
            [AccountAlias]
            )
            VALUES
                ('" + txtBxUsername.Text + "', '" + txtBxPassword.Text + "', '" + 
                txtBxFirstName.Text + "', '" + txtBxMiddleName.Text + "', '" + txtBxLastName.Text + "', '" + 
                txtBxEmailAddress.Text + "', '" + txtBxMobileNumber.Text + "', '" + 1 + "', '" + 0 + "', '" + txtBxAccountNumber.Text + "', '" + txtBxAccountAlias.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered");
        }

        private void IsBlankTextBox(object sender, EventArgs e)
        {
            TextBox txtBx = (TextBox) sender;

            if (txtBx.Text == "")
            {   
                //Chance the border style
                txtBx.BorderStyle = BorderStyle.FixedSingle;

                //Change font and font color
                txtBx.Font = new Font("Gothic A1", 11, FontStyle.Italic);
                txtBx.ForeColor = Color.Red;

                //Invalidate input
                txtBx.Text = "This field is required.";

                validData = false;
            }
        }

        private void EnterText(object sender, EventArgs e)
        {
            TextBox txtBx = (TextBox)sender;

            //If text is invalid, when user clicked, clear the textbox and change font to regular.
            if (txtBx.Text.Equals("This field is required."))
            {
                txtBx.Clear();
                txtBx.Font = new Font("Gothic A1", 12, FontStyle.Regular);
                txtBx.ForeColor = Color.Black;
            }
        }
    }
}
