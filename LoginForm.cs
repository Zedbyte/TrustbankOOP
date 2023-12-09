using Microsoft.VisualBasic;
using ReaLTaiizor.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class LoginForm : Form
    {

        string? Username { get; set; }
        string? Password { get; set; }

        int viewPasswordCount = 1;
        public LoginForm()
        {
            InitializeComponent();

            //Remove automatic focus to child controls (textbox)
            this.ActiveControl = HEADERLBLONLY;
        }

        private void setFocusToOther(object sender, EventArgs e)
        {
            this.ActiveControl = HEADERLBLONLY;
        }

        //For the shutdown symbol at the top right
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void btnLblSignUp_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Close();
        }

        private void btnParrotLogin_Click(object sender, EventArgs e)
        {
            Username = txtBxUsername.Text;
            Password = txtBxPassword.Text;
            CheckCredentials(txtBxUsername.Text, txtBxPassword.Text);
        }

        public bool CheckCredentials(string username, string password)
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               try
                {
                    string query = "SELECT id FROM AccountsTable WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        connection.Open();

                        List<string> ids = new List<string>();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ids.Add(reader["id"].ToString());
                            }
                        }

                        // Do something with the retrieved IDs
                        foreach (string id in ids)
                        {
                            CheckPassword(id, password);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Username/Password does not exist.");
                }
            }


           // Credentials are incorrect or user doesn't exist
           return false;
        }


        public bool CheckPassword(string id, string password)
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string getEncryptedPassword = "SELECT Password FROM AccountsTable WHERE id = @id";


                using (SqlCommand command = new SqlCommand(getEncryptedPassword, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    List<string> passwords = new List<string>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            passwords.Add(reader["Password"].ToString());
                        }
                    }

                    // Verify the retrieved Passwords
                    foreach (string pass in passwords)
                    {
                        bool passMatch = BCrypt.Net.BCrypt.EnhancedVerify(password, pass);

                        if (passMatch)
                        {
                            MainForm mainForm = new MainForm(id);
                        }
                    }
                }


            }
            return false;
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            viewPasswordCount += 1;
            //If count is even, unhide password
            if (viewPasswordCount % 2 == 0)
            {
                txtBxPassword.PasswordChar = '\0';
                btnViewPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            //else hide it
            else
            {
                txtBxPassword.PasswordChar = '\u2022';
                btnViewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }
    }
}
