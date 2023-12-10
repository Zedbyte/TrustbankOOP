namespace Trustbank
{
    partial class SelectRecipientMainUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            selectContactGrid = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtBxName = new TextBox();
            txtBxAccountNumber = new TextBox();
            label3 = new Label();
            txtBxEmailAddress = new TextBox();
            label4 = new Label();
            txtBxBankName = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            label6 = new Label();
            selectContactPanel = new Panel();
            btnSelectTheHighlightedRecipient = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)selectContactGrid).BeginInit();
            panel1.SuspendLayout();
            selectContactPanel.SuspendLayout();
            SuspendLayout();
            // 
            // selectContactGrid
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectContactGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            selectContactGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            selectContactGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            selectContactGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            selectContactGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            selectContactGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            selectContactGrid.DefaultCellStyle = dataGridViewCellStyle6;
            selectContactGrid.Location = new Point(397, 118);
            selectContactGrid.Name = "selectContactGrid";
            selectContactGrid.RowTemplate.Height = 25;
            selectContactGrid.Size = new Size(965, 479);
            selectContactGrid.TabIndex = 0;
            selectContactGrid.CellClick += selectContactGrid_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 26, 136);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(397, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 83);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(321, 14);
            label1.Name = "label1";
            label1.Size = new Size(325, 55);
            label1.TabIndex = 2;
            label1.Text = "Enrolled Contacts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 128);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // txtBxName
            // 
            txtBxName.BackColor = Color.FromArgb(217, 217, 217);
            txtBxName.BorderStyle = BorderStyle.None;
            txtBxName.Font = new Font("Gothic A1 SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxName.Location = new Point(45, 156);
            txtBxName.Multiline = true;
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(298, 38);
            txtBxName.TabIndex = 3;
            // 
            // txtBxAccountNumber
            // 
            txtBxAccountNumber.BackColor = Color.FromArgb(217, 217, 217);
            txtBxAccountNumber.BorderStyle = BorderStyle.None;
            txtBxAccountNumber.Font = new Font("Gothic A1 SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxAccountNumber.Location = new Point(45, 258);
            txtBxAccountNumber.Multiline = true;
            txtBxAccountNumber.Name = "txtBxAccountNumber";
            txtBxAccountNumber.Size = new Size(298, 38);
            txtBxAccountNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 230);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 4;
            label3.Text = "Account Number:";
            // 
            // txtBxEmailAddress
            // 
            txtBxEmailAddress.BackColor = Color.FromArgb(217, 217, 217);
            txtBxEmailAddress.BorderStyle = BorderStyle.None;
            txtBxEmailAddress.Font = new Font("Gothic A1 SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxEmailAddress.Location = new Point(45, 361);
            txtBxEmailAddress.Multiline = true;
            txtBxEmailAddress.Name = "txtBxEmailAddress";
            txtBxEmailAddress.Size = new Size(298, 38);
            txtBxEmailAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 333);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 6;
            label4.Text = "Email Address:";
            // 
            // txtBxBankName
            // 
            txtBxBankName.BackColor = Color.FromArgb(217, 217, 217);
            txtBxBankName.BorderStyle = BorderStyle.None;
            txtBxBankName.Font = new Font("Gothic A1 SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxBankName.Location = new Point(45, 463);
            txtBxBankName.Multiline = true;
            txtBxBankName.Name = "txtBxBankName";
            txtBxBankName.Size = new Size(298, 38);
            txtBxBankName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 435);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 8;
            label5.Text = "Bank Name:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 26, 136);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(45, 526);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(298, 45);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gothic A1 SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(149, 149, 149);
            label6.Location = new Point(45, 107);
            label6.Name = "label6";
            label6.Size = new Size(196, 21);
            label6.TabIndex = 11;
            label6.Text = "Add unenrolled contacts here:";
            // 
            // selectContactPanel
            // 
            selectContactPanel.BackColor = Color.White;
            selectContactPanel.Controls.Add(btnSelectTheHighlightedRecipient);
            selectContactPanel.Controls.Add(label6);
            selectContactPanel.Controls.Add(panel1);
            selectContactPanel.Controls.Add(btnAdd);
            selectContactPanel.Controls.Add(selectContactGrid);
            selectContactPanel.Controls.Add(txtBxBankName);
            selectContactPanel.Controls.Add(label2);
            selectContactPanel.Controls.Add(label5);
            selectContactPanel.Controls.Add(txtBxName);
            selectContactPanel.Controls.Add(txtBxEmailAddress);
            selectContactPanel.Controls.Add(label3);
            selectContactPanel.Controls.Add(label4);
            selectContactPanel.Controls.Add(txtBxAccountNumber);
            selectContactPanel.Location = new Point(0, 0);
            selectContactPanel.Name = "selectContactPanel";
            selectContactPanel.Size = new Size(1405, 616);
            selectContactPanel.TabIndex = 12;
            // 
            // btnSelectTheHighlightedRecipient
            // 
            btnSelectTheHighlightedRecipient.BackColor = Color.FromArgb(0, 26, 136);
            btnSelectTheHighlightedRecipient.FlatAppearance.BorderSize = 0;
            btnSelectTheHighlightedRecipient.FlatStyle = FlatStyle.Flat;
            btnSelectTheHighlightedRecipient.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectTheHighlightedRecipient.ForeColor = Color.White;
            btnSelectTheHighlightedRecipient.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSelectTheHighlightedRecipient.IconColor = Color.Black;
            btnSelectTheHighlightedRecipient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSelectTheHighlightedRecipient.Location = new Point(45, 37);
            btnSelectTheHighlightedRecipient.Name = "btnSelectTheHighlightedRecipient";
            btnSelectTheHighlightedRecipient.Size = new Size(298, 51);
            btnSelectTheHighlightedRecipient.TabIndex = 12;
            btnSelectTheHighlightedRecipient.Text = "Select Recipient";
            btnSelectTheHighlightedRecipient.UseVisualStyleBackColor = false;
            btnSelectTheHighlightedRecipient.Click += btnSelectTheHighlightedRecipient_Click;
            // 
            // SelectRecipientMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(selectContactPanel);
            Name = "SelectRecipientMainUserControl";
            Size = new Size(1405, 616);
            ((System.ComponentModel.ISupportInitialize)selectContactGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            selectContactPanel.ResumeLayout(false);
            selectContactPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView selectContactGrid;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtBxName;
        private TextBox txtBxAccountNumber;
        private Label label3;
        private TextBox txtBxEmailAddress;
        private Label label4;
        private TextBox txtBxBankName;
        private Label label5;
        private Button button1;
        private Label label6;
        private Panel selectContactPanel;
        private Button btnAdd;
        private FontAwesome.Sharp.IconButton btnSelectTheHighlightedRecipient;
    }
}
