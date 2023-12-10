namespace Trustbank
{
    partial class DashboardMainUserControl
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
            btnAccounts = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lblUsernamePlaceholder = new Label();
            label2 = new Label();
            lblDatePlaceholder = new Label();
            btnsLayoutPanel = new TableLayoutPanel();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnBillsPayment = new FontAwesome.Sharp.IconButton();
            btnTransactionHistory = new FontAwesome.Sharp.IconButton();
            btnTransferMoney = new FontAwesome.Sharp.IconButton();
            btnEnrolledContacts = new FontAwesome.Sharp.IconButton();
            footerPanel = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            BLUELINE = new Panel();
            label3 = new Label();
            btnsLayoutPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnAccounts
            // 
            btnAccounts.Anchor = AnchorStyles.None;
            btnAccounts.BackColor = Color.FromArgb(241, 241, 241);
            btnAccounts.FlatAppearance.BorderSize = 0;
            btnAccounts.FlatStyle = FlatStyle.Flat;
            btnAccounts.Font = new Font("Gothic A1 SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccounts.ForeColor = Color.FromArgb(0, 26, 136);
            btnAccounts.IconChar = FontAwesome.Sharp.IconChar.User;
            btnAccounts.IconColor = Color.FromArgb(0, 26, 136);
            btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAccounts.ImageAlign = ContentAlignment.BottomCenter;
            btnAccounts.Location = new Point(9, 8);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(189, 173);
            btnAccounts.TabIndex = 1;
            btnAccounts.Text = "Accounts";
            btnAccounts.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAccounts.UseVisualStyleBackColor = false;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 26, 136);
            label1.Location = new Point(57, 22);
            label1.Name = "label1";
            label1.Size = new Size(237, 69);
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
            // 
            // lblUsernamePlaceholder
            // 
            lblUsernamePlaceholder.AutoSize = true;
            lblUsernamePlaceholder.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsernamePlaceholder.ForeColor = Color.FromArgb(0, 26, 136);
            lblUsernamePlaceholder.Location = new Point(278, 22);
            lblUsernamePlaceholder.Name = "lblUsernamePlaceholder";
            lblUsernamePlaceholder.Size = new Size(128, 69);
            lblUsernamePlaceholder.TabIndex = 0;
            lblUsernamePlaceholder.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 26, 136);
            label2.Location = new Point(72, 91);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 0;
            label2.Text = "Last Login: ";
            // 
            // lblDatePlaceholder
            // 
            lblDatePlaceholder.AutoSize = true;
            lblDatePlaceholder.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatePlaceholder.ForeColor = Color.FromArgb(0, 26, 136);
            lblDatePlaceholder.Location = new Point(178, 91);
            lblDatePlaceholder.Name = "lblDatePlaceholder";
            lblDatePlaceholder.Size = new Size(162, 30);
            lblDatePlaceholder.TabIndex = 2;
            lblDatePlaceholder.Text = "date placeholder";
            // 
            // btnsLayoutPanel
            // 
            btnsLayoutPanel.ColumnCount = 6;
            btnsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            btnsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            btnsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            btnsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            btnsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            btnsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            btnsLayoutPanel.Controls.Add(btnSettings, 5, 0);
            btnsLayoutPanel.Controls.Add(btnBillsPayment, 4, 0);
            btnsLayoutPanel.Controls.Add(btnTransactionHistory, 3, 0);
            btnsLayoutPanel.Controls.Add(btnTransferMoney, 2, 0);
            btnsLayoutPanel.Controls.Add(btnEnrolledContacts, 1, 0);
            btnsLayoutPanel.Controls.Add(btnAccounts, 0, 0);
            btnsLayoutPanel.Location = new Point(72, 155);
            btnsLayoutPanel.Name = "btnsLayoutPanel";
            btnsLayoutPanel.RowCount = 1;
            btnsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            btnsLayoutPanel.Size = new Size(1244, 190);
            btnsLayoutPanel.TabIndex = 3;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.None;
            btnSettings.BackColor = Color.FromArgb(241, 241, 241);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Gothic A1 SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.FromArgb(0, 26, 136);
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            btnSettings.IconColor = Color.FromArgb(0, 26, 136);
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.ImageAlign = ContentAlignment.BottomCenter;
            btnSettings.Location = new Point(1045, 8);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(189, 173);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnBillsPayment
            // 
            btnBillsPayment.Anchor = AnchorStyles.None;
            btnBillsPayment.BackColor = Color.FromArgb(241, 241, 241);
            btnBillsPayment.FlatAppearance.BorderSize = 0;
            btnBillsPayment.FlatStyle = FlatStyle.Flat;
            btnBillsPayment.Font = new Font("Gothic A1 SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBillsPayment.ForeColor = Color.FromArgb(0, 26, 136);
            btnBillsPayment.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            btnBillsPayment.IconColor = Color.FromArgb(0, 26, 136);
            btnBillsPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBillsPayment.ImageAlign = ContentAlignment.BottomCenter;
            btnBillsPayment.Location = new Point(837, 8);
            btnBillsPayment.Name = "btnBillsPayment";
            btnBillsPayment.Size = new Size(189, 173);
            btnBillsPayment.TabIndex = 5;
            btnBillsPayment.Text = "Bills Payment";
            btnBillsPayment.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBillsPayment.UseVisualStyleBackColor = false;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.Anchor = AnchorStyles.None;
            btnTransactionHistory.BackColor = Color.FromArgb(241, 241, 241);
            btnTransactionHistory.FlatAppearance.BorderSize = 0;
            btnTransactionHistory.FlatStyle = FlatStyle.Flat;
            btnTransactionHistory.Font = new Font("Gothic A1 SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransactionHistory.ForeColor = Color.FromArgb(0, 26, 136);
            btnTransactionHistory.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            btnTransactionHistory.IconColor = Color.FromArgb(0, 26, 136);
            btnTransactionHistory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnTransactionHistory.ImageAlign = ContentAlignment.BottomCenter;
            btnTransactionHistory.Location = new Point(630, 8);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Size = new Size(189, 173);
            btnTransactionHistory.TabIndex = 4;
            btnTransactionHistory.Text = "Transaction History";
            btnTransactionHistory.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTransactionHistory.UseVisualStyleBackColor = false;
            // 
            // btnTransferMoney
            // 
            btnTransferMoney.Anchor = AnchorStyles.None;
            btnTransferMoney.BackColor = Color.FromArgb(241, 241, 241);
            btnTransferMoney.FlatAppearance.BorderSize = 0;
            btnTransferMoney.FlatStyle = FlatStyle.Flat;
            btnTransferMoney.Font = new Font("Gothic A1 SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransferMoney.ForeColor = Color.FromArgb(0, 26, 136);
            btnTransferMoney.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            btnTransferMoney.IconColor = Color.FromArgb(0, 26, 136);
            btnTransferMoney.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnTransferMoney.ImageAlign = ContentAlignment.BottomCenter;
            btnTransferMoney.Location = new Point(423, 8);
            btnTransferMoney.Name = "btnTransferMoney";
            btnTransferMoney.Size = new Size(189, 173);
            btnTransferMoney.TabIndex = 3;
            btnTransferMoney.Text = "Transfer Money";
            btnTransferMoney.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTransferMoney.UseVisualStyleBackColor = false;
            btnTransferMoney.Click += btnTransferMoney_Click;
            // 
            // btnEnrolledContacts
            // 
            btnEnrolledContacts.Anchor = AnchorStyles.None;
            btnEnrolledContacts.BackColor = Color.FromArgb(241, 241, 241);
            btnEnrolledContacts.FlatAppearance.BorderSize = 0;
            btnEnrolledContacts.FlatStyle = FlatStyle.Flat;
            btnEnrolledContacts.Font = new Font("Gothic A1 SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnrolledContacts.ForeColor = Color.FromArgb(0, 26, 136);
            btnEnrolledContacts.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            btnEnrolledContacts.IconColor = Color.FromArgb(0, 26, 136);
            btnEnrolledContacts.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnEnrolledContacts.ImageAlign = ContentAlignment.BottomCenter;
            btnEnrolledContacts.Location = new Point(216, 8);
            btnEnrolledContacts.Name = "btnEnrolledContacts";
            btnEnrolledContacts.Size = new Size(189, 173);
            btnEnrolledContacts.TabIndex = 2;
            btnEnrolledContacts.Text = "Enrolled Contacts";
            btnEnrolledContacts.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEnrolledContacts.UseVisualStyleBackColor = false;
            btnEnrolledContacts.Click += btnEnrolledContacts_Click;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(244, 244, 244);
            footerPanel.Controls.Add(label6);
            footerPanel.Controls.Add(label5);
            footerPanel.Controls.Add(label4);
            footerPanel.Controls.Add(BLUELINE);
            footerPanel.Controls.Add(label3);
            footerPanel.Location = new Point(72, 381);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1234, 213);
            footerPanel.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gothic A1", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 26, 136);
            label6.Location = new Point(21, 157);
            label6.Name = "label6";
            label6.Size = new Size(277, 42);
            label6.TabIndex = 9;
            label6.Text = "Transactions done before 3:00 PM cut-off:\r\nFunds will be credited on the next banking day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gothic A1", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 26, 136);
            label5.Location = new Point(21, 106);
            label5.Name = "label5";
            label5.Size = new Size(297, 42);
            label5.TabIndex = 8;
            label5.Text = "Transactions done before 3:00 PM cut-off:\r\nFunds will be credited before 11:00 PM, same day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 26, 136);
            label4.Location = new Point(21, 67);
            label4.Name = "label4";
            label4.Size = new Size(365, 30);
            label4.TabIndex = 7;
            label4.Text = "Know your PESONet crediting schedule";
            // 
            // BLUELINE
            // 
            BLUELINE.BackColor = Color.FromArgb(0, 26, 136);
            BLUELINE.Location = new Point(21, 63);
            BLUELINE.Name = "BLUELINE";
            BLUELINE.Size = new Size(1188, 1);
            BLUELINE.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 26, 136);
            label3.Location = new Point(21, 18);
            label3.Name = "label3";
            label3.Size = new Size(303, 38);
            label3.TabIndex = 5;
            label3.Text = "Service Announcements:";
            // 
            // DashboardMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(footerPanel);
            Controls.Add(btnsLayoutPanel);
            Controls.Add(lblDatePlaceholder);
            Controls.Add(label2);
            Controls.Add(lblUsernamePlaceholder);
            Controls.Add(label1);
            Name = "DashboardMainUserControl";
            Size = new Size(1405, 616);
            btnsLayoutPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAccounts;
        private Label label1;
        private Label lblUsernamePlaceholder;
        private Label label2;
        private Label lblDatePlaceholder;
        private TableLayoutPanel btnsLayoutPanel;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnBillsPayment;
        private FontAwesome.Sharp.IconButton btnTransactionHistory;
        private FontAwesome.Sharp.IconButton btnTransferMoney;
        private FontAwesome.Sharp.IconButton btnEnrolledContacts;
        private Panel footerPanel;
        private Label label3;
        private Panel BLUELINE;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}
