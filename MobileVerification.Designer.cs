namespace Trustbank
{
    partial class MobileVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobileVerification));
            LBLSECUREONLY = new Label();
            label1 = new Label();
            lblMobileNumPlaceholder = new Label();
            label3 = new Label();
            passcodeTextboxesPanel = new TableLayoutPanel();
            txtBxOTP1 = new TextBox();
            txtBxOTP2 = new TextBox();
            txtBxOTP5 = new TextBox();
            txtBxOTP3 = new TextBox();
            txtBxOTP4 = new TextBox();
            txtBxOTP6 = new TextBox();
            label4 = new Label();
            lblSendAnotherOTP = new Label();
            btnSubmit = new Button();
            passcodeTextboxesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LBLSECUREONLY
            // 
            LBLSECUREONLY.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLSECUREONLY.Location = new Point(194, 42);
            LBLSECUREONLY.Name = "LBLSECUREONLY";
            LBLSECUREONLY.Size = new Size(466, 40);
            LBLSECUREONLY.TabIndex = 2;
            LBLSECUREONLY.Text = "Mobile Verification";
            LBLSECUREONLY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 100);
            label1.Name = "label1";
            label1.Size = new Size(554, 40);
            label1.TabIndex = 3;
            label1.Text = "We sent a 6 - digit  verification code to your phone ending in ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMobileNumPlaceholder
            // 
            lblMobileNumPlaceholder.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMobileNumPlaceholder.ForeColor = Color.FromArgb(7, 166, 234);
            lblMobileNumPlaceholder.Location = new Point(593, 100);
            lblMobileNumPlaceholder.Name = "lblMobileNumPlaceholder";
            lblMobileNumPlaceholder.Size = new Size(266, 40);
            lblMobileNumPlaceholder.TabIndex = 4;
            lblMobileNumPlaceholder.Text = "****1";
            lblMobileNumPlaceholder.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(207, 169);
            label3.Name = "label3";
            label3.Size = new Size(466, 40);
            label3.TabIndex = 5;
            label3.Text = "Please enter the code below";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            passcodeTextboxesPanel.Location = new Point(137, 230);
            passcodeTextboxesPanel.Name = "passcodeTextboxesPanel";
            passcodeTextboxesPanel.RowCount = 1;
            passcodeTextboxesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            passcodeTextboxesPanel.Size = new Size(601, 80);
            passcodeTextboxesPanel.TabIndex = 10;
            // 
            // txtBxOTP1
            // 
            txtBxOTP1.Anchor = AnchorStyles.None;
            txtBxOTP1.BackColor = Color.FromArgb(217, 217, 217);
            txtBxOTP1.BorderStyle = BorderStyle.None;
            txtBxOTP1.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxOTP1.Location = new Point(23, 15);
            txtBxOTP1.MaxLength = 1;
            txtBxOTP1.Multiline = true;
            txtBxOTP1.Name = "txtBxOTP1";
            txtBxOTP1.Size = new Size(53, 50);
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
            txtBxOTP2.Location = new Point(123, 15);
            txtBxOTP2.MaxLength = 1;
            txtBxOTP2.Multiline = true;
            txtBxOTP2.Name = "txtBxOTP2";
            txtBxOTP2.Size = new Size(53, 50);
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
            txtBxOTP5.Location = new Point(423, 15);
            txtBxOTP5.MaxLength = 1;
            txtBxOTP5.Multiline = true;
            txtBxOTP5.Name = "txtBxOTP5";
            txtBxOTP5.Size = new Size(53, 50);
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
            txtBxOTP3.Location = new Point(223, 15);
            txtBxOTP3.MaxLength = 1;
            txtBxOTP3.Multiline = true;
            txtBxOTP3.Name = "txtBxOTP3";
            txtBxOTP3.Size = new Size(53, 50);
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
            txtBxOTP4.Location = new Point(323, 15);
            txtBxOTP4.MaxLength = 1;
            txtBxOTP4.Multiline = true;
            txtBxOTP4.Name = "txtBxOTP4";
            txtBxOTP4.Size = new Size(53, 50);
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
            txtBxOTP6.Location = new Point(524, 15);
            txtBxOTP6.MaxLength = 1;
            txtBxOTP6.Multiline = true;
            txtBxOTP6.Name = "txtBxOTP6";
            txtBxOTP6.Size = new Size(53, 50);
            txtBxOTP6.TabIndex = 6;
            txtBxOTP6.TextAlign = HorizontalAlignment.Center;
            txtBxOTP6.KeyDown += btnNextIsValid;
            txtBxOTP6.KeyUp += btnNextIsValid;
            // 
            // label4
            // 
            label4.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(215, 338);
            label4.Name = "label4";
            label4.Size = new Size(217, 40);
            label4.TabIndex = 11;
            label4.Text = "Did not receive code?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSendAnotherOTP
            // 
            lblSendAnotherOTP.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSendAnotherOTP.ForeColor = Color.FromArgb(7, 166, 234);
            lblSendAnotherOTP.Location = new Point(433, 338);
            lblSendAnotherOTP.Name = "lblSendAnotherOTP";
            lblSendAnotherOTP.Size = new Size(186, 40);
            lblSendAnotherOTP.TabIndex = 12;
            lblSendAnotherOTP.Text = "Send another one.";
            lblSendAnotherOTP.TextAlign = ContentAlignment.MiddleCenter;
            lblSendAnotherOTP.Click += lblSendAnotherOTP_Click;
            lblSendAnotherOTP.MouseEnter += lblSendAnotherOTP_MouseEnter;
            lblSendAnotherOTP.MouseLeave += lblSendAnotherOTP_MouseLeave;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 26, 136);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(281, 416);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(288, 55);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // MobileVerification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 537);
            Controls.Add(btnSubmit);
            Controls.Add(lblSendAnotherOTP);
            Controls.Add(label4);
            Controls.Add(passcodeTextboxesPanel);
            Controls.Add(label3);
            Controls.Add(lblMobileNumPlaceholder);
            Controls.Add(label1);
            Controls.Add(LBLSECUREONLY);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MobileVerification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MobileVerification";
            passcodeTextboxesPanel.ResumeLayout(false);
            passcodeTextboxesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LBLSECUREONLY;
        private Label label1;
        private Label lblMobileNumPlaceholder;
        private Label label3;
        private TableLayoutPanel passcodeTextboxesPanel;
        private TextBox txtBxOTP1;
        private TextBox txtBxOTP2;
        private TextBox txtBxOTP5;
        private TextBox txtBxOTP3;
        private TextBox txtBxOTP4;
        private TextBox txtBxOTP6;
        private Label label4;
        private Label lblSendAnotherOTP;
        private Button btnSubmit;
    }
}