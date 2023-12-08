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
            verificationPanel = new Panel();
            LBLSECUREONLY = new Label();
            lblEmailPlaceholder = new Label();
            label2 = new Label();
            btnShowOTP = new Button();
            passcodeTextboxesPanel = new TableLayoutPanel();
            txtBxPasscode1 = new TextBox();
            txtBxPasscode2 = new TextBox();
            txtBxPasscode5 = new TextBox();
            txtBxPasscode3 = new TextBox();
            txtBxPasscode4 = new TextBox();
            txtBxPasscode6 = new TextBox();
            btnNext = new Button();
            btnBack = new Button();
            LBLDIDNOTONLY = new Label();
            lblSendAnotherOTP = new Label();
            verificationPanel.SuspendLayout();
            passcodeTextboxesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // verificationPanel
            // 
            verificationPanel.BackColor = Color.White;
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
            // LBLSECUREONLY
            // 
            LBLSECUREONLY.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLSECUREONLY.Location = new Point(327, 75);
            LBLSECUREONLY.Name = "LBLSECUREONLY";
            LBLSECUREONLY.Size = new Size(466, 40);
            LBLSECUREONLY.TabIndex = 1;
            LBLSECUREONLY.Text = "We sent a 6 - digit  verification code to your email: ";
            // 
            // lblEmailPlaceholder
            // 
            lblEmailPlaceholder.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailPlaceholder.Location = new Point(810, 75);
            lblEmailPlaceholder.Name = "lblEmailPlaceholder";
            lblEmailPlaceholder.Size = new Size(466, 40);
            lblEmailPlaceholder.TabIndex = 2;
            lblEmailPlaceholder.Text = "te****e@gmail.com";
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
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode1, 0, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode2, 1, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode5, 4, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode3, 2, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode4, 3, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode6, 5, 0);
            passcodeTextboxesPanel.Location = new Point(294, 164);
            passcodeTextboxesPanel.Name = "passcodeTextboxesPanel";
            passcodeTextboxesPanel.RowCount = 1;
            passcodeTextboxesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            passcodeTextboxesPanel.Size = new Size(839, 100);
            passcodeTextboxesPanel.TabIndex = 9;
            // 
            // txtBxPasscode1
            // 
            txtBxPasscode1.Anchor = AnchorStyles.None;
            txtBxPasscode1.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode1.BorderStyle = BorderStyle.None;
            txtBxPasscode1.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode1.Location = new Point(33, 18);
            txtBxPasscode1.MaxLength = 1;
            txtBxPasscode1.Multiline = true;
            txtBxPasscode1.Name = "txtBxPasscode1";
            txtBxPasscode1.PasswordChar = '•';
            txtBxPasscode1.Size = new Size(72, 64);
            txtBxPasscode1.TabIndex = 1;
            txtBxPasscode1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxPasscode2
            // 
            txtBxPasscode2.Anchor = AnchorStyles.None;
            txtBxPasscode2.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode2.BorderStyle = BorderStyle.None;
            txtBxPasscode2.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode2.Location = new Point(172, 18);
            txtBxPasscode2.MaxLength = 1;
            txtBxPasscode2.Multiline = true;
            txtBxPasscode2.Name = "txtBxPasscode2";
            txtBxPasscode2.PasswordChar = '•';
            txtBxPasscode2.Size = new Size(72, 64);
            txtBxPasscode2.TabIndex = 2;
            txtBxPasscode2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxPasscode5
            // 
            txtBxPasscode5.Anchor = AnchorStyles.None;
            txtBxPasscode5.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode5.BorderStyle = BorderStyle.None;
            txtBxPasscode5.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode5.Location = new Point(589, 18);
            txtBxPasscode5.MaxLength = 1;
            txtBxPasscode5.Multiline = true;
            txtBxPasscode5.Name = "txtBxPasscode5";
            txtBxPasscode5.PasswordChar = '•';
            txtBxPasscode5.Size = new Size(72, 64);
            txtBxPasscode5.TabIndex = 5;
            txtBxPasscode5.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxPasscode3
            // 
            txtBxPasscode3.Anchor = AnchorStyles.None;
            txtBxPasscode3.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode3.BorderStyle = BorderStyle.None;
            txtBxPasscode3.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode3.Location = new Point(311, 18);
            txtBxPasscode3.MaxLength = 1;
            txtBxPasscode3.Multiline = true;
            txtBxPasscode3.Name = "txtBxPasscode3";
            txtBxPasscode3.PasswordChar = '•';
            txtBxPasscode3.Size = new Size(72, 64);
            txtBxPasscode3.TabIndex = 3;
            txtBxPasscode3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxPasscode4
            // 
            txtBxPasscode4.Anchor = AnchorStyles.None;
            txtBxPasscode4.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode4.BorderStyle = BorderStyle.None;
            txtBxPasscode4.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode4.Location = new Point(450, 18);
            txtBxPasscode4.MaxLength = 1;
            txtBxPasscode4.Multiline = true;
            txtBxPasscode4.Name = "txtBxPasscode4";
            txtBxPasscode4.PasswordChar = '•';
            txtBxPasscode4.Size = new Size(72, 64);
            txtBxPasscode4.TabIndex = 4;
            txtBxPasscode4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBxPasscode6
            // 
            txtBxPasscode6.Anchor = AnchorStyles.None;
            txtBxPasscode6.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode6.BorderStyle = BorderStyle.None;
            txtBxPasscode6.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode6.Location = new Point(731, 18);
            txtBxPasscode6.MaxLength = 1;
            txtBxPasscode6.Multiline = true;
            txtBxPasscode6.Name = "txtBxPasscode6";
            txtBxPasscode6.PasswordChar = '•';
            txtBxPasscode6.Size = new Size(72, 64);
            txtBxPasscode6.TabIndex = 6;
            txtBxPasscode6.TextAlign = HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 26, 136);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(758, 343);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(288, 55);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(217, 217, 217);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(0, 26, 136);
            btnBack.Location = new Point(389, 343);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(288, 55);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
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
            // lblSendAnotherOTP
            // 
            lblSendAnotherOTP.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSendAnotherOTP.ForeColor = Color.FromArgb(7, 166, 234);
            lblSendAnotherOTP.Location = new Point(728, 272);
            lblSendAnotherOTP.Name = "lblSendAnotherOTP";
            lblSendAnotherOTP.Size = new Size(197, 40);
            lblSendAnotherOTP.TabIndex = 13;
            lblSendAnotherOTP.Text = "Send another one.";
            lblSendAnotherOTP.TextAlign = ContentAlignment.MiddleCenter;
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
        private TextBox txtBxPasscode1;
        private TextBox txtBxPasscode2;
        private TextBox txtBxPasscode5;
        private TextBox txtBxPasscode3;
        private TextBox txtBxPasscode4;
        private TextBox txtBxPasscode6;
        private Button btnBack;
        private Button btnNext;
        private Label lblSendAnotherOTP;
        private Label LBLDIDNOTONLY;
        private Button button3;
    }
}
