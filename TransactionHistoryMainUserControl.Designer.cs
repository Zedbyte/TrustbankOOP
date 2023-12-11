namespace Trustbank
{
    partial class TransactionHistoryMainUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            transactHistoryDataGrid = new DataGridView();
            headerPanel = new Panel();
            btnReset = new FontAwesome.Sharp.IconButton();
            dateTimeFilter = new DateTimePicker();
            label1 = new Label();
            btnDownload = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)transactHistoryDataGrid).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // transactHistoryDataGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            transactHistoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            transactHistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactHistoryDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            transactHistoryDataGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            transactHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            transactHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            transactHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            transactHistoryDataGrid.Location = new Point(20, 113);
            transactHistoryDataGrid.Name = "transactHistoryDataGrid";
            transactHistoryDataGrid.RowTemplate.Height = 25;
            transactHistoryDataGrid.Size = new Size(1362, 429);
            transactHistoryDataGrid.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 26, 136);
            headerPanel.Controls.Add(btnReset);
            headerPanel.Controls.Add(dateTimeFilter);
            headerPanel.Controls.Add(label1);
            headerPanel.Location = new Point(20, 24);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1362, 92);
            headerPanel.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            btnReset.IconColor = Color.White;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 25;
            btnReset.Location = new Point(1000, 36);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(39, 32);
            btnReset.TabIndex = 4;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dateTimeFilter
            // 
            dateTimeFilter.CalendarFont = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeFilter.CalendarMonthBackground = Color.FromArgb(241, 241, 241);
            dateTimeFilter.CalendarTitleBackColor = SystemColors.ButtonShadow;
            dateTimeFilter.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeFilter.Location = new Point(1045, 37);
            dateTimeFilter.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimeFilter.Name = "dateTimeFilter";
            dateTimeFilter.Size = new Size(286, 26);
            dateTimeFilter.TabIndex = 4;
            dateTimeFilter.ValueChanged += dateTimeFilter_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(500, 16);
            label1.Name = "label1";
            label1.Size = new Size(353, 55);
            label1.TabIndex = 0;
            label1.Text = "Transaction History";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(0, 147, 68);
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDownload.ForeColor = Color.White;
            btnDownload.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnDownload.IconColor = Color.White;
            btnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDownload.IconSize = 25;
            btnDownload.Location = new Point(1150, 561);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(232, 32);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download Transactions";
            btnDownload.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // TransactionHistoryMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDownload);
            Controls.Add(headerPanel);
            Controls.Add(transactHistoryDataGrid);
            Name = "TransactionHistoryMainUserControl";
            Size = new Size(1405, 616);
            ((System.ComponentModel.ISupportInitialize)transactHistoryDataGrid).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView transactHistoryDataGrid;
        private Panel headerPanel;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnDownload;
        private DateTimePicker dateTimeFilter;
        private FontAwesome.Sharp.IconButton btnReset;
    }
}
