namespace Trustbank
{
    partial class UpdateInformationSettingsMainUserControl
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
            panelUpdateInfo = new Panel();
            lblEmailExist = new Label();
            lblMobileNumberExist = new Label();
            lblUserExist = new Label();
            btnEditEmail = new Button();
            btnEditMobileNumber = new Button();
            btnEditPassword = new Button();
            btnEditUsername = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBxEmailPlaceholder = new TextBox();
            txtBxMobileNumberPlaceholder = new TextBox();
            txtBxPasswordPlaceholder = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label13 = new Label();
            label8 = new Label();
            txtBxUsernamePlaceholder = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnShowPass = new FontAwesome.Sharp.IconButton();
            panelUpdateInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelUpdateInfo
            // 
            panelUpdateInfo.BackColor = Color.FromArgb(244, 244, 244);
            panelUpdateInfo.Controls.Add(btnShowPass);
            panelUpdateInfo.Controls.Add(lblEmailExist);
            panelUpdateInfo.Controls.Add(lblMobileNumberExist);
            panelUpdateInfo.Controls.Add(lblUserExist);
            panelUpdateInfo.Controls.Add(btnEditEmail);
            panelUpdateInfo.Controls.Add(btnEditMobileNumber);
            panelUpdateInfo.Controls.Add(btnEditPassword);
            panelUpdateInfo.Controls.Add(btnEditUsername);
            panelUpdateInfo.Controls.Add(tableLayoutPanel1);
            panelUpdateInfo.Location = new Point(20, 112);
            panelUpdateInfo.Name = "panelUpdateInfo";
            panelUpdateInfo.Size = new Size(1356, 404);
            panelUpdateInfo.TabIndex = 0;
            // 
            // lblEmailExist
            // 
            lblEmailExist.AutoSize = true;
            lblEmailExist.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailExist.Location = new Point(892, 315);
            lblEmailExist.Name = "lblEmailExist";
            lblEmailExist.Size = new Size(0, 24);
            lblEmailExist.TabIndex = 16;
            // 
            // lblMobileNumberExist
            // 
            lblMobileNumberExist.AutoSize = true;
            lblMobileNumberExist.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMobileNumberExist.Location = new Point(890, 227);
            lblMobileNumberExist.Name = "lblMobileNumberExist";
            lblMobileNumberExist.Size = new Size(0, 24);
            lblMobileNumberExist.TabIndex = 15;
            // 
            // lblUserExist
            // 
            lblUserExist.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserExist.Location = new Point(892, 45);
            lblUserExist.Name = "lblUserExist";
            lblUserExist.Size = new Size(211, 52);
            lblUserExist.TabIndex = 14;
            // 
            // btnEditEmail
            // 
            btnEditEmail.FlatAppearance.BorderSize = 0;
            btnEditEmail.FlatStyle = FlatStyle.Flat;
            btnEditEmail.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEmail.ForeColor = Color.FromArgb(0, 26, 136);
            btnEditEmail.Location = new Point(1268, 301);
            btnEditEmail.Name = "btnEditEmail";
            btnEditEmail.Size = new Size(75, 38);
            btnEditEmail.TabIndex = 13;
            btnEditEmail.Text = "Edit";
            btnEditEmail.UseVisualStyleBackColor = true;
            btnEditEmail.Click += btnEditEmail_Click;
            // 
            // btnEditMobileNumber
            // 
            btnEditMobileNumber.FlatAppearance.BorderSize = 0;
            btnEditMobileNumber.FlatStyle = FlatStyle.Flat;
            btnEditMobileNumber.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditMobileNumber.ForeColor = Color.FromArgb(0, 26, 136);
            btnEditMobileNumber.Location = new Point(1268, 221);
            btnEditMobileNumber.Name = "btnEditMobileNumber";
            btnEditMobileNumber.Size = new Size(75, 38);
            btnEditMobileNumber.TabIndex = 12;
            btnEditMobileNumber.Text = "Edit";
            btnEditMobileNumber.UseVisualStyleBackColor = true;
            btnEditMobileNumber.Click += btnEditMobileNumber_Click;
            // 
            // btnEditPassword
            // 
            btnEditPassword.FlatAppearance.BorderSize = 0;
            btnEditPassword.FlatStyle = FlatStyle.Flat;
            btnEditPassword.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditPassword.ForeColor = Color.FromArgb(0, 26, 136);
            btnEditPassword.Location = new Point(1268, 132);
            btnEditPassword.Name = "btnEditPassword";
            btnEditPassword.Size = new Size(75, 38);
            btnEditPassword.TabIndex = 11;
            btnEditPassword.Text = "Edit";
            btnEditPassword.UseVisualStyleBackColor = true;
            btnEditPassword.Click += btnEditPassword_Click;
            // 
            // btnEditUsername
            // 
            btnEditUsername.FlatAppearance.BorderSize = 0;
            btnEditUsername.FlatStyle = FlatStyle.Flat;
            btnEditUsername.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditUsername.ForeColor = Color.FromArgb(0, 26, 136);
            btnEditUsername.Location = new Point(1268, 53);
            btnEditUsername.Name = "btnEditUsername";
            btnEditUsername.Size = new Size(75, 38);
            btnEditUsername.TabIndex = 10;
            btnEditUsername.Text = "Edit";
            btnEditUsername.UseVisualStyleBackColor = true;
            btnEditUsername.Click += btnEditUsername_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9210529F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.07895F));
            tableLayoutPanel1.Controls.Add(txtBxEmailPlaceholder, 1, 3);
            tableLayoutPanel1.Controls.Add(txtBxMobileNumberPlaceholder, 1, 2);
            tableLayoutPanel1.Controls.Add(txtBxPasswordPlaceholder, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label13, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(txtBxUsernamePlaceholder, 1, 0);
            tableLayoutPanel1.Location = new Point(46, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(837, 339);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // txtBxEmailPlaceholder
            // 
            txtBxEmailPlaceholder.Anchor = AnchorStyles.Right;
            txtBxEmailPlaceholder.BorderStyle = BorderStyle.None;
            txtBxEmailPlaceholder.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxEmailPlaceholder.Location = new Point(219, 269);
            txtBxEmailPlaceholder.MaxLength = 50;
            txtBxEmailPlaceholder.Multiline = true;
            txtBxEmailPlaceholder.Name = "txtBxEmailPlaceholder";
            txtBxEmailPlaceholder.ReadOnly = true;
            txtBxEmailPlaceholder.Size = new Size(615, 52);
            txtBxEmailPlaceholder.TabIndex = 17;
            txtBxEmailPlaceholder.TextAlign = HorizontalAlignment.Right;
            txtBxEmailPlaceholder.TextChanged += txtBxEmailPlaceholder_TextChanged;
            // 
            // txtBxMobileNumberPlaceholder
            // 
            txtBxMobileNumberPlaceholder.Anchor = AnchorStyles.Right;
            txtBxMobileNumberPlaceholder.BorderStyle = BorderStyle.None;
            txtBxMobileNumberPlaceholder.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxMobileNumberPlaceholder.Location = new Point(219, 184);
            txtBxMobileNumberPlaceholder.MaxLength = 50;
            txtBxMobileNumberPlaceholder.Multiline = true;
            txtBxMobileNumberPlaceholder.Name = "txtBxMobileNumberPlaceholder";
            txtBxMobileNumberPlaceholder.ReadOnly = true;
            txtBxMobileNumberPlaceholder.Size = new Size(615, 52);
            txtBxMobileNumberPlaceholder.TabIndex = 16;
            txtBxMobileNumberPlaceholder.TextAlign = HorizontalAlignment.Right;
            txtBxMobileNumberPlaceholder.TextChanged += txtBxMobileNumberPlaceholder_TextChanged;
            // 
            // txtBxPasswordPlaceholder
            // 
            txtBxPasswordPlaceholder.Anchor = AnchorStyles.Right;
            txtBxPasswordPlaceholder.BorderStyle = BorderStyle.None;
            txtBxPasswordPlaceholder.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasswordPlaceholder.Location = new Point(274, 100);
            txtBxPasswordPlaceholder.MaxLength = 15;
            txtBxPasswordPlaceholder.Multiline = true;
            txtBxPasswordPlaceholder.Name = "txtBxPasswordPlaceholder";
            txtBxPasswordPlaceholder.PasswordChar = '•';
            txtBxPasswordPlaceholder.ReadOnly = true;
            txtBxPasswordPlaceholder.Size = new Size(560, 52);
            txtBxPasswordPlaceholder.TabIndex = 15;
            txtBxPasswordPlaceholder.TextAlign = HorizontalAlignment.Right;
            txtBxPasswordPlaceholder.WordWrap = false;
            txtBxPasswordPlaceholder.TextChanged += txtBxPasswordPlaceholder_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 27);
            label6.Name = "label6";
            label6.Size = new Size(189, 30);
            label6.TabIndex = 0;
            label6.Text = "Account Username:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 280);
            label7.Name = "label7";
            label7.Size = new Size(69, 30);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 111);
            label13.Name = "label13";
            label13.Size = new Size(184, 30);
            label13.TabIndex = 8;
            label13.Text = "Account Password:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 195);
            label8.Name = "label8";
            label8.Size = new Size(155, 30);
            label8.TabIndex = 7;
            label8.Text = "Mobile Number:";
            // 
            // txtBxUsernamePlaceholder
            // 
            txtBxUsernamePlaceholder.Anchor = AnchorStyles.Right;
            txtBxUsernamePlaceholder.BorderStyle = BorderStyle.None;
            txtBxUsernamePlaceholder.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxUsernamePlaceholder.Location = new Point(219, 16);
            txtBxUsernamePlaceholder.MaxLength = 50;
            txtBxUsernamePlaceholder.Multiline = true;
            txtBxUsernamePlaceholder.Name = "txtBxUsernamePlaceholder";
            txtBxUsernamePlaceholder.ReadOnly = true;
            txtBxUsernamePlaceholder.Size = new Size(615, 52);
            txtBxUsernamePlaceholder.TabIndex = 14;
            txtBxUsernamePlaceholder.TextAlign = HorizontalAlignment.Right;
            txtBxUsernamePlaceholder.TextChanged += txtBxUsernamePlaceholder_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 26, 136);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1356, 91);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(350, 38);
            label1.TabIndex = 0;
            label1.Text = "Account Information Settings";
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 26, 136);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(0, 26, 136);
            btnSave.Location = new Point(910, 541);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 48);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 26, 136);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(0, 26, 136);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1077, 541);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 48);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1245, 541);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 48);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.FromArgb(244, 244, 244);
            btnShowPass.Cursor = Cursors.Hand;
            btnShowPass.FlatAppearance.BorderSize = 0;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnShowPass.IconColor = Color.Black;
            btnShowPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowPass.IconSize = 40;
            btnShowPass.Location = new Point(886, 132);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(46, 49);
            btnShowPass.TabIndex = 17;
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // UpdateInformationSettingsMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(panelUpdateInfo);
            Name = "UpdateInformationSettingsMainUserControl";
            Size = new Size(1405, 616);
            panelUpdateInfo.ResumeLayout(false);
            panelUpdateInfo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUpdateInfo;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private Label label13;
        private Label label8;
        private Button btnEditEmail;
        private Button btnEditMobileNumber;
        private Button btnEditPassword;
        private Button btnEditUsername;
        private Button btnSave;
        private Button btnUpdate;
        private TextBox txtBxUsernamePlaceholder;
        private TextBox txtBxEmailPlaceholder;
        private TextBox txtBxMobileNumberPlaceholder;
        private TextBox txtBxPasswordPlaceholder;
        private Label lblEmailExist;
        private Label lblMobileNumberExist;
        private Label lblUserExist;
        private Button btnCancel;
        private FontAwesome.Sharp.IconButton btnShowPass;
    }
}
