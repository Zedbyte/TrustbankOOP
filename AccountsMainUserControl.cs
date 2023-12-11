using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vonage.Accounts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trustbank
{
    public partial class AccountsMainUserControl : UserControl
    {

        Panel parentContainerPanel;

        string id { get; set; }


        string Username { get; set; }

        string EncryptedPassword { get; set; }

        string FirstName { get; set; }

        string MiddleName { get; set; }

        string LastName { get; set; }

        string EmailAddress { get; set; }

        string MobileNumber { get; set; }

        int Savings { get; set; }

        int Deposit { get; set; }

        string AccountNumber { get; set; }

        string AccountAlias { get; set; }




        double AccountBalance { get; set; }


        int viewPassCount = 1;



        public AccountsMainUserControl(Panel parentContainerPanel, string id)
        {
            InitializeComponent();

            this.id = id;
            this.parentContainerPanel = parentContainerPanel;

            //Get all the information using the id
            getUserDataByID();
            getUserBalanceByID();

            //Initialize all info
            InitializePlaceholders();
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            viewPassCount += 1;

            if (viewPassCount % 2 == 0)
            {
                lblAccPasswordAccountInfo.Text = EncryptedPassword;
                btnHide.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                lblAccPasswordAccountInfo.Text = "-----";
                btnHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }


        }

        private void InitializePlaceholders()
        {
            string completeName = "";
            string surnameFirst = "";

            if (FirstName != null && LastName != null)
            {
                if (MiddleName != null)
                {
                    completeName += FirstName + " " + MiddleName + " " + LastName;

                    surnameFirst += LastName + ", " + FirstName + " " + MiddleName;
                }
                else
                {
                    completeName += FirstName + " " + LastName;
                }

                lblNamePlaceholder.Text = completeName + " - Active";
                lblNameAccountInfo.Text = surnameFirst;

            }

            if (AccountNumber != null)
            {
                lblAccountNumberPlaceholder.Text = AccountNumber;
                lblAccNumberAccountInfo.Text = AccountNumber;
            }

            if (EmailAddress != null)
            {
                lblEmailAccountInfo.Text = EmailAddress;
            }

            if (MobileNumber != null)
            {
                lblMobileNumberAccountInfo.Text = MobileNumber;
            }

            if (Savings == 1)
            {
                lblTypeOfAccountPlaceholder.Text = "Savings Account: ";
                lblAccTypeAccountInfo.Text = "Savings Account ";
            }
            else
            {
                lblTypeOfAccountPlaceholder.Text = "Deposit Account: ";
                lblAccTypeAccountInfo.Text = "Deposit Account ";
            }

            if (Username != null)
            {
                lblAccUsernameAccountInfo.Text = Username;
            }

            if (EncryptedPassword != null)
            {
                lblAccPasswordAccountInfo.Text = "-----";
            }

            lblBalancePlaceholder.Text = AccountBalance.ToString("#,##0.00"); //Formats the balance

        }


        private void getUserDataByID()
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM AccountsTable WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Username = reader.GetString(reader.GetOrdinal("Username"));
                                EncryptedPassword = reader.GetString(reader.GetOrdinal("Password"));
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                MiddleName = reader.GetString(reader.GetOrdinal("MiddleName"));
                                LastName = reader.GetString(reader.GetOrdinal("LastName"));
                                EmailAddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                                MobileNumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                                Savings = reader.GetByte(reader.GetOrdinal("Savings"));
                                Deposit = reader.GetByte(reader.GetOrdinal("Deposit"));
                                AccountNumber = reader.GetString(reader.GetOrdinal("AccountNumber"));
                                AccountAlias = reader.GetString(reader.GetOrdinal("AccountAlias"));
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void getUserBalanceByID()
        {
            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM AccountsBalance WHERE user_id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AccountBalance = reader.GetDouble(reader.GetOrdinal("balance"));
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            removePanel(this);

            UpdateInformationSettingsMainUserControl updateInformationSettingsMainUserControl = new UpdateInformationSettingsMainUserControl(parentContainerPanel, id, Username, EncryptedPassword, EmailAddress, MobileNumber);
            updateInformationSettingsMainUserControl.Show();

            parentContainerPanel.Controls.Add(updateInformationSettingsMainUserControl);

            this.Dispose();
        }




        private void removePanel(Control panel)
        {
            parentContainerPanel.Controls.Remove(panel);
        }

        private void repaintParentPanel()
        {
            parentContainerPanel.Refresh();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            QRCode qrCode = new QRCode();
            qrCode.ShowDialog();
        }
    }
}
