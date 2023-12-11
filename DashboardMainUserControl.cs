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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trustbank
{
    public partial class DashboardMainUserControl : UserControl
    {
        Panel parentContainerPanel;

        string date { get; set; }
        string id { get; set; } //Used to get the current user name



        public DashboardMainUserControl(Panel parentContainerPanel, string id, string date)
        {
            InitializeComponent();

            this.parentContainerPanel = parentContainerPanel;

            this.date = date;
            this.id = id;

            lblDatePlaceholder.Text = date;
            lblUsernamePlaceholder.Text = getCurrentUsername();
        }


        public string getCurrentUsername()
        {
            string currentUser = "";

            string connectionString = "Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT Username FROM AccountsTable WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                currentUser = reader["Username"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return currentUser;
        }

        private void removePanel(Control panel)
        {
            parentContainerPanel.Controls.Remove(panel);
        }

        private void repaintParentPanel()
        {
            parentContainerPanel.Refresh();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            removePanel(this);
            repaintParentPanel();

            AccountsMainUserControl accountsMainUserControl = new AccountsMainUserControl(parentContainerPanel, id);
            accountsMainUserControl.Show();
            parentContainerPanel.Controls.Add(accountsMainUserControl);

            this.Dispose();
        }

        private void btnEnrolledContacts_Click(object sender, EventArgs e)
        {
            removePanel(this);
            repaintParentPanel();

            EnrolledContactsMainUserControl enrolledContactsMainUserControl = new EnrolledContactsMainUserControl(id);
            enrolledContactsMainUserControl.Show();
            parentContainerPanel.Controls.Add(enrolledContactsMainUserControl);

            this.Dispose();
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            removePanel(this);
            repaintParentPanel();

            TransferMoneyMainUserControl transferMoneyMainUserControl = new TransferMoneyMainUserControl(parentContainerPanel, id, 0, "", "");
            transferMoneyMainUserControl.Show();
            parentContainerPanel.Controls.Add(transferMoneyMainUserControl);

            this.Dispose();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            removePanel(this);
            repaintParentPanel();

            TransactionHistoryMainUserControl transactionHistory = new TransactionHistoryMainUserControl(id);
            transactionHistory.Show();
            parentContainerPanel.Controls.Add(transactionHistory);

            this.Dispose();
        }

        private void btnConversionRate_Click(object sender, EventArgs e)
        {
            removePanel(this);
            repaintParentPanel();

            ConversionRateMainUserControl conversion = new ConversionRateMainUserControl(parentContainerPanel);
            conversion.Show();
            parentContainerPanel.Controls.Add(conversion);

            this.Dispose();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            removePanel(this);
            repaintParentPanel();

            HelpCenterMainUserControl helpCenterMainUserControl = new HelpCenterMainUserControl(parentContainerPanel, id);
            helpCenterMainUserControl.Show();

            parentContainerPanel.Controls.Add(helpCenterMainUserControl);

            this.Dispose();
        }
    }
}
