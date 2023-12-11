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

            btnNextDisable();
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


        private void btnNextDisable()
        {
            btnParrotLogin.Enabled = false;
            btnParrotLogin.BackgroundColor = Color.DimGray;
            btnParrotLogin.TextColor = Color.White;
        }

        private void btnNextEnable()
        {
            btnParrotLogin.Enabled = true;
            btnParrotLogin.BackgroundColor = Color.FromArgb(0, 26, 136);
            btnParrotLogin.TextColor = Color.White;
        }

        //For keypresses, every time user presses a key on the textboxes, check for button validation.
        private void btnNextIsValid(object sender, KeyEventArgs e)
        {
            if (keyPressDataValidation())
            {
                btnNextEnable();
            }
            else
            {
                btnNextDisable();
            }
        }

        private bool keyPressDataValidation()
        {
            txtBxUsername.Text = txtBxUsername.Text.Replace("\n", "");
            txtBxPassword.Text = txtBxPassword.Text.Replace("\n", "");
            if (txtBxUsername.Text != "" && txtBxPassword.Text != "" && !txtBxUsername.Text.Contains("\n") && !txtBxPassword.Text.Contains("\n"))
            {
                return true;
            }
            return false;
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

        private void AddtoDatabase(string id, string date)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[LoginHistory] 
                   (
                   [id], 
                   [date]
                   )
                   VALUES
                   (@Id, @Date)", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Date", date);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
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

                        //This can be a string as I added username verification (existing username error)
                        List<string> ids = new List<string>();

                        //I used a list when there was no username verification, the command returns a list of ids that matches the username.

                        //Select the ID from Table where Username matches the Username input by user.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ids.Add(reader["id"].ToString());
                            }
                        }

                        if (ids.Count == 0)
                        {
                            MessageBox.Show("Username/Password does not exist.");
                            return false;
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
                try
                {
                    //Select all passwords in table where ID matches the IDS given by the CheckCredentials method
                    string getEncryptedPassword = "SELECT Password FROM AccountsTable WHERE id = @id";


                    using (SqlCommand command = new SqlCommand(getEncryptedPassword, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();

                        //This can be a string as I added username verification (existing username error)
                        List<string> passwords = new List<string>();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                passwords.Add(reader["Password"].ToString());
                            }
                        }

                        // Verify the retrieved Password
                        foreach (string pass in passwords)
                        {
                            bool passMatch = BCrypt.Net.BCrypt.EnhancedVerify(password, pass);

                            if (passMatch)
                            {

                                string lastLogin = getLastLoginFromDB(id);
                                MainForm mainForm = new MainForm(id, lastLogin);
                                mainForm.Show();

                                DateTime now = DateTime.Now;
                                string formattedDateTime = now.ToString("MMMM dd, yyyy hh:mm:ss tt");

                                AddtoDatabase(id, formattedDateTime);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Username/Password does not exist.");
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Username/Password does not exist.");
                }


            }
            return false;
        }

        private string getLastLoginFromDB(string id)
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            string lastLogin = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //Select all passwords in table where ID matches the IDS given by the CheckCredentials method
                    string getEncryptedPassword = "SELECT date FROM LoginHistory WHERE id = @id";


                    using (SqlCommand command = new SqlCommand(getEncryptedPassword, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();

                        //Add all the dates of the ID here
                        List<string> dates = new List<string>();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                dates.Add(reader["date"].ToString());
                            }
                        }

                        //Get the last login date of the ID
                        try
                        {
                            lastLogin = dates[dates.Count - 1];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Your first login! Yay!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong when adding your login history to the database");
                }


            }
            return lastLogin;
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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TrustBank is a secure, user-friendly, and extensive online banking system that is built with Object-Oriented Programming (OOP) principles such as encapsulation, inheritance, polymorphism, and abstraction. These principles ensure an efficient banking platform that not only fortifies its security but also contributes to a modular and extensible codebase. \r\n\r\nThis system provides users with secure money transfers between accounts, contact enrollment for seamless transactions, and real-time access to account balances.  The system guarantees the preservation of transaction records, which promotes transparency and effortless tracking of financial activities. \r\n\r\nIn the settings function, the users are given the ability to tailor their banking experience through allowing them to change their account information (username, password, email, and mobile number). The system  provides a user-centric approach that aligns to our goal, delivering a secure and user-friendly banking experience.\r\n\r\nStaying true to its name, TrustBank upholds its commitment to security and user satisfaction through the integration of cutting-edge technology. The system features a 2-step verification process, to safeguard all transactions and user data within the application. This advanced security protocol strengthens the defense of the system against any attack that may happen. This ensures that all data within the application are secured, fortifying user privacy and building customer confidence and trust in our system.\r\n");
        }
    }
}
