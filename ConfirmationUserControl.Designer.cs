namespace Trustbank
{
    partial class ConfirmationUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationUserControl));
            confirmDetailsPanel = new Panel();
            btnShowPasscode = new FontAwesome.Sharp.IconButton();
            btnViewPassword = new FontAwesome.Sharp.IconButton();
            LBLTITLEONLY = new Label();
            TRUSTBANKLOGO = new PictureBox();
            btnSavingsOrDeposit = new Button();
            lblsToFillPanel = new TableLayoutPanel();
            txtBxPasswordFill = new TextBox();
            lblMiddleName = new Label();
            txtBxPasscodeFill = new TextBox();
            lblFirstName = new Label();
            lblUsername = new Label();
            lblAccountAlias = new Label();
            lblAccountNumber = new Label();
            lblMobileNumber = new Label();
            lblEmailAddress = new Label();
            lblLastName = new Label();
            btnCancel = new Button();
            btnNext = new Button();
            lblsTablePanel = new TableLayoutPanel();
            LBLONLY10 = new Label();
            LBLONLY4 = new Label();
            LBLONLY2 = new Label();
            LBLONLY3 = new Label();
            LBLONLY1 = new Label();
            LBLONLY9 = new Label();
            LBLONLY8 = new Label();
            LBLONLY7 = new Label();
            LBLONLY6 = new Label();
            LBLONLY5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            label9 = new Label();
            confirmDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGO).BeginInit();
            lblsToFillPanel.SuspendLayout();
            lblsTablePanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // confirmDetailsPanel
            // 
            confirmDetailsPanel.BackColor = Color.White;
            confirmDetailsPanel.Controls.Add(btnShowPasscode);
            confirmDetailsPanel.Controls.Add(btnViewPassword);
            confirmDetailsPanel.Controls.Add(LBLTITLEONLY);
            confirmDetailsPanel.Controls.Add(TRUSTBANKLOGO);
            confirmDetailsPanel.Controls.Add(btnSavingsOrDeposit);
            confirmDetailsPanel.Controls.Add(lblsToFillPanel);
            confirmDetailsPanel.Controls.Add(btnCancel);
            confirmDetailsPanel.Controls.Add(btnNext);
            confirmDetailsPanel.Controls.Add(lblsTablePanel);
            confirmDetailsPanel.Location = new Point(0, 0);
            confirmDetailsPanel.Name = "confirmDetailsPanel";
            confirmDetailsPanel.Size = new Size(1421, 438);
            confirmDetailsPanel.TabIndex = 0;
            // 
            // btnShowPasscode
            // 
            btnShowPasscode.BackColor = Color.Transparent;
            btnShowPasscode.FlatAppearance.BorderSize = 0;
            btnShowPasscode.FlatAppearance.MouseDownBackColor = Color.FromArgb(244, 244, 244);
            btnShowPasscode.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 244, 244);
            btnShowPasscode.FlatStyle = FlatStyle.Flat;
            btnShowPasscode.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnShowPasscode.IconColor = Color.Black;
            btnShowPasscode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowPasscode.IconSize = 35;
            btnShowPasscode.Location = new Point(998, 321);
            btnShowPasscode.Name = "btnShowPasscode";
            btnShowPasscode.Size = new Size(46, 31);
            btnShowPasscode.TabIndex = 54;
            btnShowPasscode.UseVisualStyleBackColor = false;
            btnShowPasscode.Click += btnShowPasscode_Click;
            // 
            // btnViewPassword
            // 
            btnViewPassword.BackColor = Color.Transparent;
            btnViewPassword.FlatAppearance.BorderSize = 0;
            btnViewPassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(244, 244, 244);
            btnViewPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 244, 244);
            btnViewPassword.FlatStyle = FlatStyle.Flat;
            btnViewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnViewPassword.IconColor = Color.Black;
            btnViewPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewPassword.IconSize = 35;
            btnViewPassword.Location = new Point(998, 50);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new Size(46, 31);
            btnViewPassword.TabIndex = 53;
            btnViewPassword.UseVisualStyleBackColor = false;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // LBLTITLEONLY
            // 
            LBLTITLEONLY.AutoSize = true;
            LBLTITLEONLY.Font = new Font("Gothic A1", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBLTITLEONLY.ForeColor = Color.FromArgb(0, 26, 136);
            LBLTITLEONLY.Location = new Point(106, 33);
            LBLTITLEONLY.Name = "LBLTITLEONLY";
            LBLTITLEONLY.Size = new Size(158, 46);
            LBLTITLEONLY.TabIndex = 5;
            LBLTITLEONLY.Text = "Trustbank";
            // 
            // TRUSTBANKLOGO
            // 
            TRUSTBANKLOGO.Image = (Image)resources.GetObject("TRUSTBANKLOGO.Image");
            TRUSTBANKLOGO.Location = new Point(15, 13);
            TRUSTBANKLOGO.Name = "TRUSTBANKLOGO";
            TRUSTBANKLOGO.Size = new Size(85, 83);
            TRUSTBANKLOGO.SizeMode = PictureBoxSizeMode.Zoom;
            TRUSTBANKLOGO.TabIndex = 4;
            TRUSTBANKLOGO.TabStop = false;
            // 
            // btnSavingsOrDeposit
            // 
            btnSavingsOrDeposit.BackColor = Color.FromArgb(0, 26, 136);
            btnSavingsOrDeposit.Enabled = false;
            btnSavingsOrDeposit.FlatAppearance.BorderSize = 0;
            btnSavingsOrDeposit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSavingsOrDeposit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSavingsOrDeposit.FlatStyle = FlatStyle.Flat;
            btnSavingsOrDeposit.Font = new Font("Gothic A1 SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavingsOrDeposit.ForeColor = Color.White;
            btnSavingsOrDeposit.Location = new Point(1114, 13);
            btnSavingsOrDeposit.Name = "btnSavingsOrDeposit";
            btnSavingsOrDeposit.Size = new Size(221, 58);
            btnSavingsOrDeposit.TabIndex = 0;
            btnSavingsOrDeposit.Text = "Savings/Deposit";
            btnSavingsOrDeposit.UseVisualStyleBackColor = false;
            // 
            // lblsToFillPanel
            // 
            lblsToFillPanel.ColumnCount = 1;
            lblsToFillPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            lblsToFillPanel.Controls.Add(txtBxPasswordFill, 0, 1);
            lblsToFillPanel.Controls.Add(lblMiddleName, 0, 3);
            lblsToFillPanel.Controls.Add(txtBxPasscodeFill, 0, 9);
            lblsToFillPanel.Controls.Add(lblFirstName, 0, 2);
            lblsToFillPanel.Controls.Add(lblUsername, 0, 0);
            lblsToFillPanel.Controls.Add(lblAccountAlias, 0, 8);
            lblsToFillPanel.Controls.Add(lblAccountNumber, 0, 7);
            lblsToFillPanel.Controls.Add(lblMobileNumber, 0, 6);
            lblsToFillPanel.Controls.Add(lblEmailAddress, 0, 5);
            lblsToFillPanel.Controls.Add(lblLastName, 0, 4);
            lblsToFillPanel.Location = new Point(730, 13);
            lblsToFillPanel.Name = "lblsToFillPanel";
            lblsToFillPanel.RowCount = 10;
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000992F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000992F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999101F));
            lblsToFillPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            lblsToFillPanel.Size = new Size(262, 340);
            lblsToFillPanel.TabIndex = 3;
            // 
            // txtBxPasswordFill
            // 
            txtBxPasswordFill.BorderStyle = BorderStyle.None;
            txtBxPasswordFill.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasswordFill.Location = new Point(3, 37);
            txtBxPasswordFill.Multiline = true;
            txtBxPasswordFill.Name = "txtBxPasswordFill";
            txtBxPasswordFill.PasswordChar = '•';
            txtBxPasswordFill.Size = new Size(256, 28);
            txtBxPasswordFill.TabIndex = 55;
            // 
            // lblMiddleName
            // 
            lblMiddleName.Anchor = AnchorStyles.Right;
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(126, 104);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(133, 30);
            lblMiddleName.TabIndex = 0;
            lblMiddleName.Text = "Middle Name";
            // 
            // txtBxPasscodeFill
            // 
            txtBxPasscodeFill.BorderStyle = BorderStyle.None;
            txtBxPasscodeFill.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscodeFill.Location = new Point(3, 309);
            txtBxPasscodeFill.Multiline = true;
            txtBxPasscodeFill.Name = "txtBxPasscodeFill";
            txtBxPasscodeFill.PasswordChar = '•';
            txtBxPasscodeFill.Size = new Size(256, 28);
            txtBxPasscodeFill.TabIndex = 0;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(148, 70);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(111, 30);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(154, 2);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 30);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblAccountAlias
            // 
            lblAccountAlias.Anchor = AnchorStyles.Right;
            lblAccountAlias.AutoSize = true;
            lblAccountAlias.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountAlias.Location = new Point(124, 274);
            lblAccountAlias.Name = "lblAccountAlias";
            lblAccountAlias.Size = new Size(135, 30);
            lblAccountAlias.TabIndex = 0;
            lblAccountAlias.Text = "Account Alias";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.Anchor = AnchorStyles.Right;
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountNumber.Location = new Point(96, 240);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(163, 30);
            lblAccountNumber.TabIndex = 0;
            lblAccountNumber.Text = "Account Number";
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.Anchor = AnchorStyles.Right;
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMobileNumber.Location = new Point(108, 206);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(151, 30);
            lblMobileNumber.TabIndex = 0;
            lblMobileNumber.Text = "Mobile Number";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.Anchor = AnchorStyles.Right;
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailAddress.Location = new Point(116, 172);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(143, 30);
            lblEmailAddress.TabIndex = 0;
            lblEmailAddress.Text = "Email Address";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(149, 138);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(110, 30);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(217, 217, 217);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(0, 26, 136);
            btnCancel.Location = new Point(377, 374);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(261, 49);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Back";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 26, 136);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Transparent;
            btnNext.Location = new Point(730, 374);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(261, 49);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblsTablePanel
            // 
            lblsTablePanel.ColumnCount = 1;
            lblsTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            lblsTablePanel.Controls.Add(LBLONLY10, 0, 9);
            lblsTablePanel.Controls.Add(LBLONLY4, 0, 3);
            lblsTablePanel.Controls.Add(LBLONLY2, 0, 1);
            lblsTablePanel.Controls.Add(LBLONLY3, 0, 2);
            lblsTablePanel.Controls.Add(LBLONLY1, 0, 0);
            lblsTablePanel.Controls.Add(LBLONLY9, 0, 8);
            lblsTablePanel.Controls.Add(LBLONLY8, 0, 7);
            lblsTablePanel.Controls.Add(LBLONLY7, 0, 6);
            lblsTablePanel.Controls.Add(LBLONLY6, 0, 5);
            lblsTablePanel.Controls.Add(LBLONLY5, 0, 4);
            lblsTablePanel.Location = new Point(377, 13);
            lblsTablePanel.Name = "lblsTablePanel";
            lblsTablePanel.RowCount = 10;
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000992F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0001F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0000992F));
            lblsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999101F));
            lblsTablePanel.Size = new Size(262, 340);
            lblsTablePanel.TabIndex = 0;
            // 
            // LBLONLY10
            // 
            LBLONLY10.Anchor = AnchorStyles.Left;
            LBLONLY10.AutoSize = true;
            LBLONLY10.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY10.Location = new Point(3, 308);
            LBLONLY10.Name = "LBLONLY10";
            LBLONLY10.Size = new Size(100, 30);
            LBLONLY10.TabIndex = 0;
            LBLONLY10.Text = "Passcode";
            // 
            // LBLONLY4
            // 
            LBLONLY4.Anchor = AnchorStyles.Left;
            LBLONLY4.AutoSize = true;
            LBLONLY4.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY4.Location = new Point(3, 104);
            LBLONLY4.Name = "LBLONLY4";
            LBLONLY4.Size = new Size(133, 30);
            LBLONLY4.TabIndex = 0;
            LBLONLY4.Text = "Middle Name";
            // 
            // LBLONLY2
            // 
            LBLONLY2.Anchor = AnchorStyles.Left;
            LBLONLY2.AutoSize = true;
            LBLONLY2.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY2.Location = new Point(3, 36);
            LBLONLY2.Name = "LBLONLY2";
            LBLONLY2.Size = new Size(101, 30);
            LBLONLY2.TabIndex = 0;
            LBLONLY2.Text = "Password";
            // 
            // LBLONLY3
            // 
            LBLONLY3.Anchor = AnchorStyles.Left;
            LBLONLY3.AutoSize = true;
            LBLONLY3.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY3.Location = new Point(3, 70);
            LBLONLY3.Name = "LBLONLY3";
            LBLONLY3.Size = new Size(111, 30);
            LBLONLY3.TabIndex = 0;
            LBLONLY3.Text = "First Name";
            // 
            // LBLONLY1
            // 
            LBLONLY1.Anchor = AnchorStyles.Left;
            LBLONLY1.AutoSize = true;
            LBLONLY1.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY1.Location = new Point(3, 2);
            LBLONLY1.Name = "LBLONLY1";
            LBLONLY1.Size = new Size(105, 30);
            LBLONLY1.TabIndex = 0;
            LBLONLY1.Text = "Username";
            // 
            // LBLONLY9
            // 
            LBLONLY9.Anchor = AnchorStyles.Left;
            LBLONLY9.AutoSize = true;
            LBLONLY9.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY9.Location = new Point(3, 274);
            LBLONLY9.Name = "LBLONLY9";
            LBLONLY9.Size = new Size(135, 30);
            LBLONLY9.TabIndex = 0;
            LBLONLY9.Text = "Account Alias";
            // 
            // LBLONLY8
            // 
            LBLONLY8.Anchor = AnchorStyles.Left;
            LBLONLY8.AutoSize = true;
            LBLONLY8.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY8.Location = new Point(3, 240);
            LBLONLY8.Name = "LBLONLY8";
            LBLONLY8.Size = new Size(163, 30);
            LBLONLY8.TabIndex = 0;
            LBLONLY8.Text = "Account Number";
            // 
            // LBLONLY7
            // 
            LBLONLY7.Anchor = AnchorStyles.Left;
            LBLONLY7.AutoSize = true;
            LBLONLY7.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY7.Location = new Point(3, 206);
            LBLONLY7.Name = "LBLONLY7";
            LBLONLY7.Size = new Size(151, 30);
            LBLONLY7.TabIndex = 0;
            LBLONLY7.Text = "Mobile Number";
            // 
            // LBLONLY6
            // 
            LBLONLY6.Anchor = AnchorStyles.Left;
            LBLONLY6.AutoSize = true;
            LBLONLY6.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY6.Location = new Point(3, 172);
            LBLONLY6.Name = "LBLONLY6";
            LBLONLY6.Size = new Size(143, 30);
            LBLONLY6.TabIndex = 0;
            LBLONLY6.Text = "Email Address";
            // 
            // LBLONLY5
            // 
            LBLONLY5.Anchor = AnchorStyles.Left;
            LBLONLY5.AutoSize = true;
            LBLONLY5.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLONLY5.Location = new Point(3, 138);
            LBLONLY5.Name = "LBLONLY5";
            LBLONLY5.Size = new Size(110, 30);
            LBLONLY5.TabIndex = 0;
            LBLONLY5.Text = "Last Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 120);
            label8.Name = "label8";
            label8.Size = new Size(180, 20);
            label8.TabIndex = 0;
            label8.Text = "Account Number";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 33);
            label9.TabIndex = 0;
            label9.Text = "Password";
            // 
            // ConfirmationUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(confirmDetailsPanel);
            Name = "ConfirmationUserControl";
            Size = new Size(1421, 438);
            confirmDetailsPanel.ResumeLayout(false);
            confirmDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGO).EndInit();
            lblsToFillPanel.ResumeLayout(false);
            lblsToFillPanel.PerformLayout();
            lblsTablePanel.ResumeLayout(false);
            lblsTablePanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel confirmDetailsPanel;
        private Label LBLONLY1;
        private TableLayoutPanel lblsTablePanel;
        private Label LBLONLY8;
        private Label LBLONLY7;
        private Label LBLONLY6;
        private Label LBLONLY5;
        private Label LBLONLY3;
        private Label LBLONLY2;
        private Button btnNext;
        private Button btnCancel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label9;
        private Label LBLONLY9;
        private Label LBLTITLEONLY;
        private PictureBox TRUSTBANKLOGO;
        private Button btnSavingsOrDeposit;
        private TableLayoutPanel lblsToFillPanel;
        private Label lblMiddleName;
        private Label lblFirstName;
        private Label lblUsername;
        private Label lblAccountAlias;
        private Label lblAccountNumber;
        private Label lblMobileNumber;
        private Label lblEmailAddress;
        private Label lblLastName;
        private Label LBLONLY10;
        private Label LBLONLY4;
        private FontAwesome.Sharp.IconButton btnShowPasscode;
        private FontAwesome.Sharp.IconButton btnViewPassword;
        private TextBox txtBxPasscodeFill;
        private TextBox txtBxPasswordFill;
    }
}
