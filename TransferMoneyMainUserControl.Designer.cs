namespace Trustbank
{
    partial class TransferMoneyMainUserControl
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
            label1 = new Label();
            label2 = new Label();
            fromPanel = new Panel();
            txtBxPurpose = new TextBox();
            btnNext = new Button();
            label3 = new Label();
            metroRBtnInstaPay = new ReaLTaiizor.Controls.MetroRadioButton();
            metroRBtnPesonet = new ReaLTaiizor.Controls.MetroRadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            purposePanel = new Panel();
            amountPanel = new Panel();
            txtBxAmount = new TextBox();
            label13 = new Label();
            lblNamePlaceholder = new Label();
            label14 = new Label();
            lblAccountNumPlaceholder = new Label();
            comboBox1 = new ComboBox();
            PANELLINEONLY = new Panel();
            label15 = new Label();
            recipientPanel = new Panel();
            txtRecipient = new TextBox();
            btnSelectRecipients = new FontAwesome.Sharp.IconButton();
            fromPanel.SuspendLayout();
            purposePanel.SuspendLayout();
            amountPanel.SuspendLayout();
            recipientPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(584, 18);
            label1.Name = "label1";
            label1.Size = new Size(222, 43);
            label1.TabIndex = 0;
            label1.Text = "Transfer Money";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 84);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 0;
            label2.Text = "From:";
            // 
            // fromPanel
            // 
            fromPanel.BackColor = Color.FromArgb(241, 241, 241);
            fromPanel.Controls.Add(lblAccountNumPlaceholder);
            fromPanel.Controls.Add(label14);
            fromPanel.Controls.Add(lblNamePlaceholder);
            fromPanel.Location = new Point(62, 112);
            fromPanel.Name = "fromPanel";
            fromPanel.Size = new Size(600, 93);
            fromPanel.TabIndex = 1;
            // 
            // txtBxPurpose
            // 
            txtBxPurpose.BackColor = Color.FromArgb(241, 241, 241);
            txtBxPurpose.BorderStyle = BorderStyle.None;
            txtBxPurpose.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPurpose.Location = new Point(20, 26);
            txtBxPurpose.Multiline = true;
            txtBxPurpose.Name = "txtBxPurpose";
            txtBxPurpose.PlaceholderText = "Purpose";
            txtBxPurpose.Size = new Size(567, 37);
            txtBxPurpose.TabIndex = 4;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 26, 136);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(730, 491);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(600, 71);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(730, 239);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 0;
            label3.Text = "Transfer Service:";
            // 
            // metroRBtnInstaPay
            // 
            metroRBtnInstaPay.BackgroundColor = Color.White;
            metroRBtnInstaPay.BorderColor = Color.FromArgb(155, 155, 155);
            metroRBtnInstaPay.Checked = false;
            metroRBtnInstaPay.CheckSignColor = Color.FromArgb(65, 177, 225);
            metroRBtnInstaPay.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            metroRBtnInstaPay.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            metroRBtnInstaPay.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            metroRBtnInstaPay.Group = 0;
            metroRBtnInstaPay.IsDerivedStyle = true;
            metroRBtnInstaPay.Location = new Point(750, 289);
            metroRBtnInstaPay.Name = "metroRBtnInstaPay";
            metroRBtnInstaPay.Size = new Size(20, 17);
            metroRBtnInstaPay.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroRBtnInstaPay.StyleManager = null;
            metroRBtnInstaPay.TabIndex = 5;
            metroRBtnInstaPay.ThemeAuthor = "Taiizor";
            metroRBtnInstaPay.ThemeName = "MetroLight";
            // 
            // metroRBtnPesonet
            // 
            metroRBtnPesonet.BackgroundColor = Color.White;
            metroRBtnPesonet.BorderColor = Color.FromArgb(155, 155, 155);
            metroRBtnPesonet.Checked = false;
            metroRBtnPesonet.CheckSignColor = Color.FromArgb(65, 177, 225);
            metroRBtnPesonet.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            metroRBtnPesonet.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            metroRBtnPesonet.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroRBtnPesonet.Group = 0;
            metroRBtnPesonet.IsDerivedStyle = true;
            metroRBtnPesonet.Location = new Point(1098, 289);
            metroRBtnPesonet.Name = "metroRBtnPesonet";
            metroRBtnPesonet.Size = new Size(25, 17);
            metroRBtnPesonet.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroRBtnPesonet.StyleManager = null;
            metroRBtnPesonet.TabIndex = 6;
            metroRBtnPesonet.ThemeAuthor = "Taiizor";
            metroRBtnPesonet.ThemeName = "MetroLight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(773, 285);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 0;
            label4.Text = "InstaPay";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1118, 285);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 0;
            label5.Text = "PESONet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(217, 217, 217);
            label6.Location = new Point(773, 321);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 0;
            label6.Text = "✓ Real time transfer ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(217, 217, 217);
            label7.Location = new Point(773, 358);
            label7.Name = "label7";
            label7.Size = new Size(182, 50);
            label7.TabIndex = 0;
            label7.Text = "✓ PHP 50,000.00 only \r\n    transaction limit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(773, 417);
            label8.Name = "label8";
            label8.Size = new Size(171, 50);
            label8.TabIndex = 0;
            label8.Text = "✓ PHP 25.00 fee per \r\n    transaction";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1118, 417);
            label9.Name = "label9";
            label9.Size = new Size(171, 50);
            label9.TabIndex = 0;
            label9.Text = "✓ PHP 25.00 fee per \r\n    transaction";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(217, 217, 217);
            label10.Location = new Point(1118, 358);
            label10.Name = "label10";
            label10.Size = new Size(182, 50);
            label10.TabIndex = 0;
            label10.Text = "✓ PHP 50,000.00 only \r\n    transaction limit";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(217, 217, 217);
            label11.Location = new Point(1118, 321);
            label11.Name = "label11";
            label11.Size = new Size(168, 25);
            label11.TabIndex = 0;
            label11.Text = "✓ Real time transfer ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(730, 84);
            label12.Name = "label12";
            label12.Size = new Size(80, 25);
            label12.TabIndex = 12;
            label12.Text = "Purpose:";
            // 
            // purposePanel
            // 
            purposePanel.BackColor = Color.FromArgb(241, 241, 241);
            purposePanel.Controls.Add(txtBxPurpose);
            purposePanel.Location = new Point(730, 112);
            purposePanel.Name = "purposePanel";
            purposePanel.Size = new Size(600, 93);
            purposePanel.TabIndex = 0;
            // 
            // amountPanel
            // 
            amountPanel.BackColor = Color.FromArgb(241, 241, 241);
            amountPanel.Controls.Add(PANELLINEONLY);
            amountPanel.Controls.Add(comboBox1);
            amountPanel.Controls.Add(txtBxAmount);
            amountPanel.Location = new Point(62, 289);
            amountPanel.Name = "amountPanel";
            amountPanel.Size = new Size(600, 93);
            amountPanel.TabIndex = 0;
            // 
            // txtBxAmount
            // 
            txtBxAmount.BackColor = Color.FromArgb(241, 241, 241);
            txtBxAmount.BorderStyle = BorderStyle.None;
            txtBxAmount.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxAmount.Location = new Point(137, 26);
            txtBxAmount.Multiline = true;
            txtBxAmount.Name = "txtBxAmount";
            txtBxAmount.PlaceholderText = "Amount";
            txtBxAmount.Size = new Size(451, 37);
            txtBxAmount.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(62, 261);
            label13.Name = "label13";
            label13.Size = new Size(76, 25);
            label13.TabIndex = 15;
            label13.Text = "Amount:";
            // 
            // lblNamePlaceholder
            // 
            lblNamePlaceholder.AutoSize = true;
            lblNamePlaceholder.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNamePlaceholder.Location = new Point(15, 11);
            lblNamePlaceholder.Name = "lblNamePlaceholder";
            lblNamePlaceholder.Size = new Size(132, 33);
            lblNamePlaceholder.TabIndex = 0;
            lblNamePlaceholder.Text = "placeholder";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Gothic A1 SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(149, 149, 149);
            label14.Location = new Point(16, 47);
            label14.Name = "label14";
            label14.Size = new Size(164, 25);
            label14.TabIndex = 0;
            label14.Text = "ACCOUNT NUMBER";
            // 
            // lblAccountNumPlaceholder
            // 
            lblAccountNumPlaceholder.AutoSize = true;
            lblAccountNumPlaceholder.Font = new Font("Gothic A1 SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountNumPlaceholder.ForeColor = Color.FromArgb(149, 149, 149);
            lblAccountNumPlaceholder.Location = new Point(186, 47);
            lblAccountNumPlaceholder.Name = "lblAccountNumPlaceholder";
            lblAccountNumPlaceholder.Size = new Size(164, 25);
            lblAccountNumPlaceholder.TabIndex = 0;
            lblAccountNumPlaceholder.Text = "ACCOUNT NUMBER";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(241, 241, 241);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Gothic A1", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PHP" });
            comboBox1.Location = new Point(16, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(71, 63);
            comboBox1.TabIndex = 1;
            // 
            // PANELLINEONLY
            // 
            PANELLINEONLY.BackColor = Color.FromArgb(149, 149, 149);
            PANELLINEONLY.Location = new Point(113, 6);
            PANELLINEONLY.Name = "PANELLINEONLY";
            PANELLINEONLY.Size = new Size(1, 80);
            PANELLINEONLY.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(62, 441);
            label15.Name = "label15";
            label15.Size = new Size(36, 25);
            label15.TabIndex = 16;
            label15.Text = "To:";
            // 
            // recipientPanel
            // 
            recipientPanel.BackColor = Color.FromArgb(241, 241, 241);
            recipientPanel.Controls.Add(txtRecipient);
            recipientPanel.Location = new Point(62, 469);
            recipientPanel.Name = "recipientPanel";
            recipientPanel.Size = new Size(475, 93);
            recipientPanel.TabIndex = 0;
            // 
            // txtRecipient
            // 
            txtRecipient.BackColor = Color.FromArgb(241, 241, 241);
            txtRecipient.BorderStyle = BorderStyle.None;
            txtRecipient.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtRecipient.Location = new Point(20, 26);
            txtRecipient.Multiline = true;
            txtRecipient.Name = "txtRecipient";
            txtRecipient.PlaceholderText = "Select Recipient";
            txtRecipient.Size = new Size(448, 37);
            txtRecipient.TabIndex = 0;
            // 
            // btnSelectRecipients
            // 
            btnSelectRecipients.BackColor = Color.FromArgb(241, 241, 241);
            btnSelectRecipients.FlatAppearance.BorderSize = 0;
            btnSelectRecipients.FlatStyle = FlatStyle.Flat;
            btnSelectRecipients.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            btnSelectRecipients.IconColor = Color.FromArgb(149, 149, 149);
            btnSelectRecipients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSelectRecipients.Location = new Point(536, 469);
            btnSelectRecipients.Name = "btnSelectRecipients";
            btnSelectRecipients.Size = new Size(126, 93);
            btnSelectRecipients.TabIndex = 3;
            btnSelectRecipients.UseVisualStyleBackColor = false;
            // 
            // TransferMoneyMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSelectRecipients);
            Controls.Add(recipientPanel);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(amountPanel);
            Controls.Add(purposePanel);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(metroRBtnPesonet);
            Controls.Add(metroRBtnInstaPay);
            Controls.Add(label3);
            Controls.Add(btnNext);
            Controls.Add(fromPanel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TransferMoneyMainUserControl";
            Size = new Size(1405, 616);
            fromPanel.ResumeLayout(false);
            fromPanel.PerformLayout();
            purposePanel.ResumeLayout(false);
            purposePanel.PerformLayout();
            amountPanel.ResumeLayout(false);
            amountPanel.PerformLayout();
            recipientPanel.ResumeLayout(false);
            recipientPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel fromPanel;
        private TextBox txtBxPurpose;
        private Button btnNext;
        private Label label3;
        private ReaLTaiizor.Controls.MetroRadioButton metroRBtnInstaPay;
        private ReaLTaiizor.Controls.MetroRadioButton metroRBtnPesonet;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel purposePanel;
        private Panel amountPanel;
        private TextBox txtBxAmount;
        private Label label13;
        private Label lblNamePlaceholder;
        private Label lblAccountNumPlaceholder;
        private Label label14;
        private ComboBox comboBox1;
        private Panel PANELLINEONLY;
        private Label label15;
        private Panel recipientPanel;
        private TextBox txtRecipient;
        private FontAwesome.Sharp.IconButton btnSelectRecipients;
    }
}
