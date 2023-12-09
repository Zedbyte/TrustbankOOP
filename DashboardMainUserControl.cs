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

            AccountsMainUserControl accountsMainUserControl = new AccountsMainUserControl(id);
            accountsMainUserControl.Show();
            parentContainerPanel.Controls.Add(accountsMainUserControl);

            this.Dispose();
        }
    }
}
