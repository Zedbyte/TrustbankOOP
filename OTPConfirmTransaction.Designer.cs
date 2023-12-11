namespace Trustbank
{
    partial class OTPConfirmTransaction
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPConfirmTransaction));
            label1 = new Label();
            label2 = new Label();
            lblEmailAddressPlaceholder = new Label();
            LBLTITLEONLY = new Label();
            TRUSTBANKLOGO = new PictureBox();
            label3 = new Label();
            txtBxOTP1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBxOTP6 = new TextBox();
            txtBxOTP5 = new TextBox();
            txtBxOTP4 = new TextBox();
            txtBxOTP3 = new TextBox();
            txtBxOTP2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            timerEmail = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGO).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 106);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 0;
            label1.Text = "Email Verification";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 164);
            label2.Name = "label2";
            label2.Size = new Size(462, 30);
            label2.TabIndex = 0;
            label2.Text = "We sent  a 6 - digit verification code to your email:";
            // 
            // lblEmailAddressPlaceholder
            // 
            lblEmailAddressPlaceholder.AutoSize = true;
            lblEmailAddressPlaceholder.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailAddressPlaceholder.Location = new Point(565, 164);
            lblEmailAddressPlaceholder.Name = "lblEmailAddressPlaceholder";
            lblEmailAddressPlaceholder.Size = new Size(119, 30);
            lblEmailAddressPlaceholder.TabIndex = 0;
            lblEmailAddressPlaceholder.Text = "placeholder";
            // 
            // LBLTITLEONLY
            // 
            LBLTITLEONLY.AutoSize = true;
            LBLTITLEONLY.Font = new Font("Gothic A1", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBLTITLEONLY.ForeColor = Color.FromArgb(0, 26, 136);
            LBLTITLEONLY.Location = new Point(386, 22);
            LBLTITLEONLY.Name = "LBLTITLEONLY";
            LBLTITLEONLY.Size = new Size(202, 59);
            LBLTITLEONLY.TabIndex = 7;
            LBLTITLEONLY.Text = "Trustbank";
            // 
            // TRUSTBANKLOGO
            // 
            TRUSTBANKLOGO.Image = (Image)resources.GetObject("TRUSTBANKLOGO.Image");
            TRUSTBANKLOGO.Location = new Point(289, 7);
            TRUSTBANKLOGO.Name = "TRUSTBANKLOGO";
            TRUSTBANKLOGO.Size = new Size(108, 96);
            TRUSTBANKLOGO.SizeMode = PictureBoxSizeMode.Zoom;
            TRUSTBANKLOGO.TabIndex = 6;
            TRUSTBANKLOGO.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(322, 225);
            label3.Name = "label3";
            label3.Size = new Size(301, 33);
            label3.TabIndex = 8;
            label3.Text = "Please enter the code below:";
            // 
            // txtBxOTP1
            // 
            txtBxOTP1.Anchor = AnchorStyles.None;
            txtBxOTP1.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP1.BorderStyle = BorderStyle.None;
            txtBxOTP1.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP1.Location = new Point(15, 11);
            txtBxOTP1.MaxLength = 1;
            txtBxOTP1.Multiline = true;
            txtBxOTP1.Name = "txtBxOTP1";
            txtBxOTP1.Size = new Size(94, 90);
            txtBxOTP1.TabIndex = 1;
            txtBxOTP1.TextAlign = HorizontalAlignment.Center;
            txtBxOTP1.KeyDown += isOTPValid;
            txtBxOTP1.KeyUp += isOTPValid;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(txtBxOTP6, 5, 0);
            tableLayoutPanel1.Controls.Add(txtBxOTP5, 4, 0);
            tableLayoutPanel1.Controls.Add(txtBxOTP4, 3, 0);
            tableLayoutPanel1.Controls.Add(txtBxOTP3, 2, 0);
            tableLayoutPanel1.Controls.Add(txtBxOTP2, 1, 0);
            tableLayoutPanel1.Controls.Add(txtBxOTP1, 0, 0);
            tableLayoutPanel1.Location = new Point(81, 295);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(744, 112);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // txtBxOTP6
            // 
            txtBxOTP6.Anchor = AnchorStyles.None;
            txtBxOTP6.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP6.BorderStyle = BorderStyle.None;
            txtBxOTP6.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP6.Location = new Point(635, 11);
            txtBxOTP6.MaxLength = 1;
            txtBxOTP6.Multiline = true;
            txtBxOTP6.Name = "txtBxOTP6";
            txtBxOTP6.Size = new Size(94, 90);
            txtBxOTP6.TabIndex = 6;
            txtBxOTP6.TextAlign = HorizontalAlignment.Center;
            txtBxOTP6.KeyDown += isOTPValid;
            txtBxOTP6.KeyUp += isOTPValid;
            // 
            // txtBxOTP5
            // 
            txtBxOTP5.Anchor = AnchorStyles.None;
            txtBxOTP5.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP5.BorderStyle = BorderStyle.None;
            txtBxOTP5.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP5.Location = new Point(511, 11);
            txtBxOTP5.MaxLength = 1;
            txtBxOTP5.Multiline = true;
            txtBxOTP5.Name = "txtBxOTP5";
            txtBxOTP5.Size = new Size(94, 90);
            txtBxOTP5.TabIndex = 5;
            txtBxOTP5.TextAlign = HorizontalAlignment.Center;
            txtBxOTP5.KeyDown += isOTPValid;
            txtBxOTP5.KeyUp += isOTPValid;
            // 
            // txtBxOTP4
            // 
            txtBxOTP4.Anchor = AnchorStyles.None;
            txtBxOTP4.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP4.BorderStyle = BorderStyle.None;
            txtBxOTP4.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP4.Location = new Point(387, 11);
            txtBxOTP4.MaxLength = 1;
            txtBxOTP4.Multiline = true;
            txtBxOTP4.Name = "txtBxOTP4";
            txtBxOTP4.Size = new Size(94, 90);
            txtBxOTP4.TabIndex = 4;
            txtBxOTP4.TextAlign = HorizontalAlignment.Center;
            txtBxOTP4.KeyDown += isOTPValid;
            txtBxOTP4.KeyUp += isOTPValid;
            // 
            // txtBxOTP3
            // 
            txtBxOTP3.Anchor = AnchorStyles.None;
            txtBxOTP3.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP3.BorderStyle = BorderStyle.None;
            txtBxOTP3.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP3.Location = new Point(263, 11);
            txtBxOTP3.MaxLength = 1;
            txtBxOTP3.Multiline = true;
            txtBxOTP3.Name = "txtBxOTP3";
            txtBxOTP3.Size = new Size(94, 90);
            txtBxOTP3.TabIndex = 3;
            txtBxOTP3.TextAlign = HorizontalAlignment.Center;
            txtBxOTP3.KeyDown += isOTPValid;
            txtBxOTP3.KeyUp += isOTPValid;
            // 
            // txtBxOTP2
            // 
            txtBxOTP2.Anchor = AnchorStyles.None;
            txtBxOTP2.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP2.BorderStyle = BorderStyle.None;
            txtBxOTP2.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP2.Location = new Point(139, 11);
            txtBxOTP2.MaxLength = 1;
            txtBxOTP2.Multiline = true;
            txtBxOTP2.Name = "txtBxOTP2";
            txtBxOTP2.Size = new Size(94, 90);
            txtBxOTP2.TabIndex = 2;
            txtBxOTP2.TextAlign = HorizontalAlignment.Center;
            txtBxOTP2.KeyDown += isOTPValid;
            txtBxOTP2.KeyUp += isOTPValid;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(253, 426);
            label4.Name = "label4";
            label4.Size = new Size(208, 30);
            label4.TabIndex = 11;
            label4.Text = "Did not receive code?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(7, 166, 234);
            label5.Location = new Point(467, 426);
            label5.Name = "label5";
            label5.Size = new Size(176, 30);
            label5.TabIndex = 12;
            label5.Text = "Send another one ";
            // 
            // timerEmail
            // 
            timerEmail.Enabled = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 26, 136);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 592);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 26, 136);
            panel2.Location = new Point(928, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 592);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 26, 136);
            panel3.Location = new Point(2, 586);
            panel3.Name = "panel3";
            panel3.Size = new Size(929, 10);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 26, 136);
            panel4.Location = new Point(2, -5);
            panel4.Name = "panel4";
            panel4.Size = new Size(928, 10);
            panel4.TabIndex = 16;
            // 
            // OTPConfirmTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 591);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(LBLTITLEONLY);
            Controls.Add(TRUSTBANKLOGO);
            Controls.Add(lblEmailAddressPlaceholder);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OTPConfirmTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OTPConfirmTransaction";
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGO).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label lblEmailAddressPlaceholder;
        private Label LBLTITLEONLY;
        private PictureBox TRUSTBANKLOGO;
        private Label label3;
        private TextBox txtBxOTP1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtBxOTP6;
        private TextBox txtBxOTP5;
        private TextBox txtBxOTP4;
        private TextBox txtBxOTP3;
        private TextBox txtBxOTP2;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timerEmail;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
    }
}