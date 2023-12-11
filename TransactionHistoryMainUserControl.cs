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


namespace Trustbank
{
    public partial class TransactionHistoryMainUserControl : UserControl
    {

        string? id { get; set; }

        public TransactionHistoryMainUserControl(string id)
        {
            InitializeComponent();
            this.id = id;
            InitializeHistory();
        }



        private void InitializeHistory()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT UserAccountNumber AS 'User Account', TransactDate AS 'Date', TransactType AS 'Type', TransactPurpose AS 'Purpose', recipient_id AS 'Recipient ID', RecipientName AS 'Recipient Name', RecipientAccountNumber AS 'Recipient Account Number', UserBalance AS 'Balance', ReferenceID AS 'Reference ID' FROM TransactionHistoryTable WHERE user_id = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    connection.Open();
                    cmd.ExecuteNonQuery();


                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    transactHistoryDataGrid.DataSource = dt;

                }
            }
        }

        private void dateTimeFilter_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimeFilter.Value.ToString("MMMM dd, yyyy");
            MessageBox.Show(date);

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8SM50HF\\SQLEXPRESS;Initial Catalog=AccountsDB;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT UserAccountNumber AS 'User Account', TransactDate AS 'Date', TransactType AS 'Type', TransactPurpose AS 'Purpose', recipient_id AS 'Recipient ID', RecipientName AS 'Recipient Name', RecipientAccountNumber AS 'Recipient Account Number', UserBalance AS 'Balance', ReferenceID AS 'Reference ID' FROM TransactionHistoryTable WHERE user_id = @id AND LEFT(TransactDate, LEN(@date)) = @date", connection))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@date", date);
                    connection.Open();
                    cmd.ExecuteNonQuery();


                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    transactHistoryDataGrid.DataSource = dt;

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeHistory();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (transactHistoryDataGrid.Rows.Count > 0)
                {

                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < transactHistoryDataGrid.Columns.Count + 1; i++)
                    {
                        xcelApp.Cells[1, i] = transactHistoryDataGrid.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < transactHistoryDataGrid.Rows.Count; i++)
                    {
                        for (int j = 0; j < transactHistoryDataGrid.Columns.Count; j++)
                        {
                            try
                            {
                                xcelApp.Cells[i, j] = transactHistoryDataGrid.Rows[i].Cells[j].Value.ToString();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Excel must be version 15.0.0.0.");
            }
        }
    }
}
