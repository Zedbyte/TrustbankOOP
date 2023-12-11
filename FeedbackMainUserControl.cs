using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class FeedbackMainUserControl : UserControl
    {
        string? id;

        string? satisfaction {  get; set; }

        string? suggestion {  get; set; }

        HelpCenterMainUserControl helpCenterMainUserControl;

        Panel parentContainerPanel;

        public FeedbackMainUserControl(string? id, HelpCenterMainUserControl helpCenterInstance, Panel parentContainerPanel)
        {
            InitializeComponent();

            this.id = id;

            this.parentContainerPanel = parentContainerPanel;

            this.helpCenterMainUserControl = helpCenterInstance;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            satisfaction = txtBxSatisfaction.Text;
            suggestion = txtBxSuggestion.Text;
            try
            {
                AddtoDatabase();
                MessageBox.Show("Feedback Submitted!");

                txtBxSatisfaction.Clear();
                txtBxSuggestion.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot submit feedback. Please try again later.");
            }
        }

        private void AddtoDatabase()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[FeedbackTable] 
                   (
                   [id], 
                   [satisfaction],
                   [suggestion]
                   )
                   VALUES
                   (@id, @satisfaction, @suggestion)", con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@satisfaction", satisfaction);
            cmd.Parameters.AddWithValue("@suggestion", suggestion);
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
