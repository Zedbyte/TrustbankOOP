using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class TicketMainUserControl : UserControl
    {
        string? id { get; set; }

        string? issue { get; set; }
        string? description { get; set; }


        HelpCenterMainUserControl helpCenterMainUserControl;

        Panel parentContainerPanel;

        public TicketMainUserControl(string? id, HelpCenterMainUserControl helpCenterInstance, Panel parentContainerPanel)
        {
            InitializeComponent();

            this.helpCenterMainUserControl = helpCenterInstance;
            this.parentContainerPanel = parentContainerPanel;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            string filePath = openFileDialog.FileName;
            pBoxImageTicket.Image = Image.FromFile(filePath);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            issue = txtBxIssue.Text;
            description = txtBxDescription.Text;
            try
            {
                AddtoDatabase();
                MessageBox.Show("Ticket Submitted!");

                txtBxIssue.Clear();
                txtBxDescription.Clear();
                pBoxImageTicket.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot submit ticket. Please try again later." + ex.ToString());
            }
        }


        private void AddtoDatabase()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[TicketTable] 
                   (
                   [id], 
                   [issue],
                   [description]
                   )
                   VALUES
                   (@id, @issue, @description)", con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@issue", issue);
            cmd.Parameters.AddWithValue("@description", description);
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parentContainerPanel.Controls.Remove(this);
            parentContainerPanel.Refresh();

            helpCenterMainUserControl.Show();
            parentContainerPanel.Controls.Add(helpCenterMainUserControl);

            this.Dispose();

        }
    }
}
