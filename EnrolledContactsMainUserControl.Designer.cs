namespace Trustbank
{
    partial class EnrolledContactsMainUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            label1 = new Label();
            txtBxName = new TextBox();
            txtBxAccountNumber = new TextBox();
            label2 = new Label();
            txtBxEmailAddress = new TextBox();
            label3 = new Label();
            txtBxBankName = new TextBox();
            label4 = new Label();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnView = new FontAwesome.Sharp.IconButton();
            contactsDataGrid = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            btnCancelEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)contactsDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 100);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtBxName
            // 
            txtBxName.BackColor = Color.FromArgb(217, 217, 217);
            txtBxName.BorderStyle = BorderStyle.None;
            txtBxName.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxName.Location = new Point(43, 128);
            txtBxName.MaxLength = 35;
            txtBxName.Multiline = true;
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(298, 38);
            txtBxName.TabIndex = 1;
            // 
            // txtBxAccountNumber
            // 
            txtBxAccountNumber.BackColor = Color.FromArgb(217, 217, 217);
            txtBxAccountNumber.BorderStyle = BorderStyle.None;
            txtBxAccountNumber.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxAccountNumber.Location = new Point(43, 220);
            txtBxAccountNumber.MaxLength = 35;
            txtBxAccountNumber.Multiline = true;
            txtBxAccountNumber.Name = "txtBxAccountNumber";
            txtBxAccountNumber.Size = new Size(298, 38);
            txtBxAccountNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 192);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 0;
            label2.Text = "Account Number:";
            // 
            // txtBxEmailAddress
            // 
            txtBxEmailAddress.BackColor = Color.FromArgb(217, 217, 217);
            txtBxEmailAddress.BorderStyle = BorderStyle.None;
            txtBxEmailAddress.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxEmailAddress.Location = new Point(43, 306);
            txtBxEmailAddress.MaxLength = 35;
            txtBxEmailAddress.Multiline = true;
            txtBxEmailAddress.Name = "txtBxEmailAddress";
            txtBxEmailAddress.Size = new Size(298, 38);
            txtBxEmailAddress.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 278);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 0;
            label3.Text = "Email Address:";
            // 
            // txtBxBankName
            // 
            txtBxBankName.BackColor = Color.FromArgb(217, 217, 217);
            txtBxBankName.BorderStyle = BorderStyle.None;
            txtBxBankName.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxBankName.Location = new Point(43, 393);
            txtBxBankName.MaxLength = 35;
            txtBxBankName.Multiline = true;
            txtBxBankName.Name = "txtBxBankName";
            txtBxBankName.Size = new Size(298, 38);
            txtBxBankName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 365);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 0;
            label4.Text = "Bank Name:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 147, 68);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(43, 484);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 47);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 26, 136);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEdit.IconColor = Color.Black;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.Location = new Point(205, 484);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 47);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(43, 550);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 47);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(149, 149, 149);
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor = Color.White;
            btnView.IconChar = FontAwesome.Sharp.IconChar.None;
            btnView.IconColor = Color.Black;
            btnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnView.Location = new Point(205, 550);
            btnView.Name = "btnView";
            btnView.Size = new Size(136, 47);
            btnView.TabIndex = 8;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // contactsDataGrid
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.LightGray;
            dataGridViewCellStyle13.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            contactsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            contactsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            contactsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            contactsDataGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            contactsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            contactsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            contactsDataGrid.DefaultCellStyle = dataGridViewCellStyle15;
            contactsDataGrid.Location = new Point(398, 118);
            contactsDataGrid.Name = "contactsDataGrid";
            contactsDataGrid.RowTemplate.Height = 25;
            contactsDataGrid.Size = new Size(965, 479);
            contactsDataGrid.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 26, 136);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(398, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 83);
            panel1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gothic A1", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(322, 15);
            label5.Name = "label5";
            label5.Size = new Size(325, 55);
            label5.TabIndex = 0;
            label5.Text = "Enrolled Contacts";
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.DimGray;
            btnCancelEdit.FlatAppearance.BorderSize = 0;
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelEdit.ForeColor = Color.White;
            btnCancelEdit.Location = new Point(43, 35);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(298, 40);
            btnCancelEdit.TabIndex = 14;
            btnCancelEdit.Text = "Cancel Edit";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // EnrolledContactsMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCancelEdit);
            Controls.Add(panel1);
            Controls.Add(contactsDataGrid);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtBxBankName);
            Controls.Add(label4);
            Controls.Add(txtBxEmailAddress);
            Controls.Add(label3);
            Controls.Add(txtBxAccountNumber);
            Controls.Add(label2);
            Controls.Add(txtBxName);
            Controls.Add(label1);
            Name = "EnrolledContactsMainUserControl";
            Size = new Size(1405, 616);
            ((System.ComponentModel.ISupportInitialize)contactsDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBxName;
        private TextBox txtBxAccountNumber;
        private Label label2;
        private TextBox txtBxEmailAddress;
        private Label label3;
        private TextBox txtBxBankName;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnView;
        private DataGridView contactsDataGrid;
        private Panel panel1;
        private Label label5;
        private Button btnCancelEdit;
    }
}
