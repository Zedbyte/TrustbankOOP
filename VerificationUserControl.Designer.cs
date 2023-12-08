namespace Trustbank
{
    partial class VerificationUserControl
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
            components = new System.ComponentModel.Container();
            verificationPanel = new Panel();
            lblSendEmailAgain = new Label();
            lblSendAnotherOTP = new Label();
            LBLDIDNOTONLY = new Label();
            btnBack = new Button();
            btnNext = new Button();
            btnShowOTP = new Button();
            passcodeTextboxesPanel = new TableLayoutPanel();
            txtBxOTP1 = new TextBox();
            txtBxOTP2 = new TextBox();
            txtBxOTP5 = new TextBox();
            txtBxOTP3 = new TextBox();
            txtBxOTP4 = new TextBox();
            txtBxOTP6 = new TextBox();
            label2 = new Label();
            lblEmailPlaceholder = new Label();
            LBLSECUREONLY = new Label();
            timerEmail = new System.Windows.Forms.Timer(components);
            expiration = new System.Windows.Forms.Timer(components);
            verificationPanel.SuspendLayout();
            passcodeTextboxesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // verificationPanel
            // 
            verificationPanel.BackColor = Color.White;
            verificationPanel.Controls.Add(lblSendEmailAgain);
            verificationPanel.Controls.Add(lblSendAnotherOTP);
            verificationPanel.Controls.Add(LBLDIDNOTONLY);
            verificationPanel.Controls.Add(btnBack);
            verificationPanel.Controls.Add(btnNext);
            verificationPanel.Controls.Add(btnShowOTP);
            verificationPanel.Controls.Add(passcodeTextboxesPanel);
            verificationPanel.Controls.Add(label2);
            verificationPanel.Controls.Add(lblEmailPlaceholder);
            verificationPanel.Controls.Add(LBLSECUREONLY);
            verificationPanel.Location = new Point(0, 0);
            verificationPanel.Name = "verificationPanel";
            verificationPanel.Size = new Size(1421, 438);
            verificationPanel.TabIndex = 0;
            // 
            // lblSendEmailAgain
            // 
            lblSendEmailAgain.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSendEmailAgain.ForeColor = Color.FromArgb(7, 166, 234);
            lblSendEmailAgain.Location = new Point(721, 271);
            lblSendEmailAgain.Name = "lblSendEmailAgain";
            lblSendEmailAgain.Size = new Size(197, 40);
            lblSendEmailAgain.TabIndex = 14;
            lblSendEmailAgain.Text = "Send another one.";
            lblSendEmailAgain.TextAlign = ContentAlignment.MiddleCenter;
            lblSendEmailAgain.Click += lblSendEmailAgain_Click;
            lblSendEmailAgain.MouseEnter += lblSendEmailAgain_MouseEnter;
            lblSendEmailAgain.MouseLeave += lblSendEmailAgain_MouseLeave;
            // 
            // lblSendAnotherOTP
            // 
            lblSendAnotherOTP.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSendAnotherOTP.ForeColor = Color.FromArgb(7, 166, 234);
            lblSendAnotherOTP.Location = new Point(619, 311);
            lblSendAnotherOTP.Name = "lblSendAnotherOTP";
            lblSendAnotherOTP.Size = new Size(197, 40);
            lblSendAnotherOTP.TabIndex = 13;
            lblSendAnotherOTP.Text = "Try another way.";
            lblSendAnotherOTP.TextAlign = ContentAlignment.MiddleCenter;
            lblSendAnotherOTP.Click += lblSendAnotherOTP_Click;
            lblSendAnotherOTP.MouseEnter += lblSendAnotherOTP_MouseEnter;
            lblSendAnotherOTP.MouseLeave += lblSendAnotherOTP_MouseLeave;
            // 
            // LBLDIDNOTONLY
            // 
            LBLDIDNOTONLY.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLDIDNOTONLY.Location = new Point(512, 271);
            LBLDIDNOTONLY.Name = "LBLDIDNOTONLY";
            LBLDIDNOTONLY.Size = new Size(222, 40);
            LBLDIDNOTONLY.TabIndex = 12;
            LBLDIDNOTONLY.Text = "Did not receive code?";
            LBLDIDNOTONLY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(217, 217, 217);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(0, 26, 136);
            btnBack.Location = new Point(389, 361);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(288, 55);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 26, 136);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(759, 361);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(288, 55);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnShowOTP
            // 
            btnShowOTP.FlatAppearance.BorderSize = 0;
            btnShowOTP.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnShowOTP.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShowOTP.FlatStyle = FlatStyle.Flat;
            btnShowOTP.Font = new Font("Gothic A1 SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowOTP.ForeColor = Color.FromArgb(149, 149, 149);
            btnShowOTP.Location = new Point(1139, 186);
            btnShowOTP.Name = "btnShowOTP";
            btnShowOTP.Size = new Size(94, 49);
            btnShowOTP.TabIndex = 8;
            btnShowOTP.Text = "Show";
            btnShowOTP.UseVisualStyleBackColor = true;
            btnShowOTP.Click += btnShowOTP_Click_1;
            btnShowOTP.MouseEnter += btnShowOTP_MouseEnter;
            btnShowOTP.MouseLeave += btnShowOTP_MouseLeave;
            // 
            // passcodeTextboxesPanel
            // 
            passcodeTextboxesPanel.Anchor = AnchorStyles.None;
            passcodeTextboxesPanel.ColumnCount = 6;
            passcodeTextboxesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            passcodeTextboxesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            passcodeTextboxesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            passcodeTextboxesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            passcodeTextboxesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            passcodeTextboxesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            passcodeTextboxesPanel.Controls.Add(txtBxOTP1, 0, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxOTP2, 1, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxOTP5, 4, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxOTP3, 2, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxOTP4, 3, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxOTP6, 5, 0);
            passcodeTextboxesPanel.Location = new Point(294, 164);
            passcodeTextboxesPanel.Name = "passcodeTextboxesPanel";
            passcodeTextboxesPanel.RowCount = 1;
            passcodeTextboxesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            passcodeTextboxesPanel.Size = new Size(839, 100);
            passcodeTextboxesPanel.TabIndex = 9;
            // 
            // txtBxOTP1
            // 
            txtBxOTP1.Anchor = AnchorStyles.None;
            txtBxOTP1.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP1.BorderStyle = BorderStyle.None;
            txtBxOTP1.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP1.Location = new Point(33, 18);
            txtBxOTP1.MaxLength = 1;
            txtBxOTP1.Multiline = true;
            txtBxOTP1.Name = "txtBxOTP1";
            txtBxOTP1.PasswordChar = '•';
            txtBxOTP1.Size = new Size(72, 64);
            txtBxOTP1.TabIndex = 1;
            txtBxOTP1.TextAlign = HorizontalAlignment.Center;
            txtBxOTP1.KeyDown += btnNextIsValid;
            txtBxOTP1.KeyUp += btnNextIsValid;
            // 
            // txtBxOTP2
            // 
            txtBxOTP2.Anchor = AnchorStyles.None;
            txtBxOTP2.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP2.BorderStyle = BorderStyle.None;
            txtBxOTP2.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP2.Location = new Point(172, 18);
            txtBxOTP2.MaxLength = 1;
            txtBxOTP2.Multiline = true;
            txtBxOTP2.Name = "txtBxOTP2";
            txtBxOTP2.PasswordChar = '•';
            txtBxOTP2.Size = new Size(72, 64);
            txtBxOTP2.TabIndex = 2;
            txtBxOTP2.TextAlign = HorizontalAlignment.Center;
            txtBxOTP2.KeyDown += btnNextIsValid;
            txtBxOTP2.KeyUp += btnNextIsValid;
            // 
            // txtBxOTP5
            // 
            txtBxOTP5.Anchor = AnchorStyles.None;
            txtBxOTP5.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP5.BorderStyle = BorderStyle.None;
            txtBxOTP5.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP5.Location = new Point(589, 18);
            txtBxOTP5.MaxLength = 1;
            txtBxOTP5.Multiline = true;
            txtBxOTP5.Name = "txtBxOTP5";
            txtBxOTP5.PasswordChar = '•';
            txtBxOTP5.Size = new Size(72, 64);
            txtBxOTP5.TabIndex = 5;
            txtBxOTP5.TextAlign = HorizontalAlignment.Center;
            txtBxOTP5.KeyDown += btnNextIsValid;
            txtBxOTP5.KeyUp += btnNextIsValid;
            // 
            // txtBxOTP3
            // 
            txtBxOTP3.Anchor = AnchorStyles.None;
            txtBxOTP3.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP3.BorderStyle = BorderStyle.None;
            txtBxOTP3.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP3.Location = new Point(311, 18);
            txtBxOTP3.MaxLength = 1;
            txtBxOTP3.Multiline = true;
            txtBxOTP3.Name = "txtBxOTP3";
            txtBxOTP3.PasswordChar = '•';
            txtBxOTP3.Size = new Size(72, 64);
            txtBxOTP3.TabIndex = 3;
            txtBxOTP3.TextAlign = HorizontalAlignment.Center;
            txtBxOTP3.KeyDown += btnNextIsValid;
            txtBxOTP3.KeyUp += btnNextIsValid;
            // 
            // txtBxOTP4
            // 
            txtBxOTP4.Anchor = AnchorStyles.None;
            txtBxOTP4.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP4.BorderStyle = BorderStyle.None;
            txtBxOTP4.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP4.Location = new Point(450, 18);
            txtBxOTP4.MaxLength = 1;
            txtBxOTP4.Multiline = true;
            txtBxOTP4.Name = "txtBxOTP4";
            txtBxOTP4.PasswordChar = '•';
            txtBxOTP4.Size = new Size(72, 64);
            txtBxOTP4.TabIndex = 4;
            txtBxOTP4.TextAlign = HorizontalAlignment.Center;
            txtBxOTP4.KeyDown += btnNextIsValid;
            txtBxOTP4.KeyUp += btnNextIsValid;
            // 
            // txtBxOTP6
            // 
            txtBxOTP6.Anchor = AnchorStyles.None;
            txtBxOTP6.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP6.BorderStyle = BorderStyle.None;
            txtBxOTP6.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP6.Location = new Point(731, 18);
            txtBxOTP6.MaxLength = 1;
            txtBxOTP6.Multiline = true;
            txtBxOTP6.Name = "txtBxOTP6";
            txtBxOTP6.PasswordChar = '•';
            txtBxOTP6.Size = new Size(72, 64);
            txtBxOTP6.TabIndex = 6;
            txtBxOTP6.TextAlign = HorizontalAlignment.Center;
            txtBxOTP6.KeyDown += btnNextIsValid;
            txtBxOTP6.KeyUp += btnNextIsValid;
            // 
            // label2
            // 
            label2.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(477, 115);
            label2.Name = "label2";
            label2.Size = new Size(466, 40);
            label2.TabIndex = 3;
            label2.Text = "Please enter the code below";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmailPlaceholder
            // 
            lblEmailPlaceholder.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailPlaceholder.ForeColor = Color.FromArgb(7, 166, 234);
            lblEmailPlaceholder.Location = new Point(810, 75);
            lblEmailPlaceholder.Name = "lblEmailPlaceholder";
            lblEmailPlaceholder.Size = new Size(466, 40);
            lblEmailPlaceholder.TabIndex = 2;
            lblEmailPlaceholder.Text = "te****e@gmail.com";
            // 
            // LBLSECUREONLY
            // 
            LBLSECUREONLY.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLSECUREONLY.Location = new Point(327, 75);
            LBLSECUREONLY.Name = "LBLSECUREONLY";
            LBLSECUREONLY.Size = new Size(466, 40);
            LBLSECUREONLY.TabIndex = 1;
            LBLSECUREONLY.Text = "We sent a 6 - digit  verification code to your email: ";
            // 
            // timerEmail
            // 
            timerEmail.Enabled = true;
            timerEmail.Tick += timerEmail_Tick;
            // 
            // expiration
            // 
            expiration.Enabled = true;
            expiration.Interval = 1000;
            expiration.Tick += expiration_Tick;
            // 
            // VerificationUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(verificationPanel);
            Name = "VerificationUserControl";
            Size = new Size(1421, 438);
            verificationPanel.ResumeLayout(false);
            passcodeTextboxesPanel.ResumeLayout(false);
            passcodeTextboxesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel verificationPanel;
        private Label label2;
        private Label lblEmailPlaceholder;
        private Label LBLSECUREONLY;
        private Button btnShowOTP;
        private TableLayoutPanel passcodeTextboxesPanel;
        private TextBox txtBxOTP1;
        private TextBox txtBxOTP2;
        private TextBox txtBxOTP5;
        private TextBox txtBxOTP3;
        private TextBox txtBxOTP4;
        private TextBox txtBxOTP6;
        private Button btnBack;
        private Button btnNext;
        private Label lblSendAnotherOTP;
        private Label LBLDIDNOTONLY;
        private Button button3;
        private System.Windows.Forms.Timer timerEmail;
        private System.Windows.Forms.Timer expiration;
        private Label lblSendEmailAgain;
    }
}
