namespace Trustbank
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainFormPanel = new Panel();
            slidingPanel = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            parentContainerPanel = new Panel();
            label5 = new Label();
            btnLogOutSideBar = new FontAwesome.Sharp.IconButton();
            btnHelpAndSupport = new FontAwesome.Sharp.IconButton();
            btnConversionRate = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            btnTransferMoney = new FontAwesome.Sharp.IconButton();
            btnShowHistory = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            btnEnrolledContacts = new FontAwesome.Sharp.IconButton();
            btnSidePanelClose = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            btnAccounts = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            HEADERPANEL = new Panel();
            SUBHEADERLBLONLY = new Label();
            HEADERLBLONLY = new Label();
            TRUSTBANKLOGOONLY = new PictureBox();
            headerContainerPanel = new Panel();
            label1 = new Label();
            trustBankHeaderLogo = new PictureBox();
            lblTrustbankTitle = new Label();
            btnLogOut = new FontAwesome.Sharp.IconButton();
            btnHamburger = new FontAwesome.Sharp.IconButton();
            mainFormPanel.SuspendLayout();
            slidingPanel.SuspendLayout();
            HEADERPANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGOONLY).BeginInit();
            headerContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trustBankHeaderLogo).BeginInit();
            SuspendLayout();
            // 
            // mainFormPanel
            // 
            mainFormPanel.Controls.Add(slidingPanel);
            mainFormPanel.Controls.Add(parentContainerPanel);
            mainFormPanel.Controls.Add(headerContainerPanel);
            mainFormPanel.Location = new Point(-1, -1);
            mainFormPanel.Name = "mainFormPanel";
            mainFormPanel.Size = new Size(1405, 753);
            mainFormPanel.TabIndex = 0;
            // 
            // slidingPanel
            // 
            slidingPanel.BottomLeft = Color.Black;
            slidingPanel.BottomRight = Color.DodgerBlue;
            slidingPanel.CollapseControl = parentContainerPanel;
            slidingPanel.Collapsed = true;
            slidingPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            slidingPanel.Controls.Add(label5);
            slidingPanel.Controls.Add(btnLogOutSideBar);
            slidingPanel.Controls.Add(btnHelpAndSupport);
            slidingPanel.Controls.Add(btnConversionRate);
            slidingPanel.Controls.Add(label4);
            slidingPanel.Controls.Add(btnTransferMoney);
            slidingPanel.Controls.Add(btnShowHistory);
            slidingPanel.Controls.Add(label3);
            slidingPanel.Controls.Add(btnEnrolledContacts);
            slidingPanel.Controls.Add(btnSidePanelClose);
            slidingPanel.Controls.Add(label2);
            slidingPanel.Controls.Add(btnAccounts);
            slidingPanel.Controls.Add(btnDashboard);
            slidingPanel.Controls.Add(HEADERPANEL);
            slidingPanel.Dock = DockStyle.Left;
            slidingPanel.HideControls = false;
            slidingPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            slidingPanel.Location = new Point(0, 0);
            slidingPanel.Name = "slidingPanel";
            slidingPanel.PanelWidthCollapsed = 1;
            slidingPanel.PanelWidthExpanded = 251;
            slidingPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            slidingPanel.PrimerColor = Color.White;
            slidingPanel.Size = new Size(1, 753);
            slidingPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            slidingPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            slidingPanel.TabIndex = 0;
            slidingPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            slidingPanel.TopLeft = Color.FromArgb(0, 26, 136);
            slidingPanel.TopRight = Color.FromArgb(0, 26, 136);
            // 
            // parentContainerPanel
            // 
            parentContainerPanel.Font = new Font("Gothic A1 SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            parentContainerPanel.Location = new Point(0, 137);
            parentContainerPanel.Name = "parentContainerPanel";
            parentContainerPanel.Size = new Size(1405, 616);
            parentContainerPanel.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 26, 136);
            label5.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(152, 224, 255);
            label5.Location = new Point(18, 598);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 16;
            label5.Text = "ACCOUNT";
            // 
            // btnLogOutSideBar
            // 
            btnLogOutSideBar.BackColor = Color.FromArgb(0, 26, 136);
            btnLogOutSideBar.FlatAppearance.BorderSize = 0;
            btnLogOutSideBar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogOutSideBar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogOutSideBar.FlatStyle = FlatStyle.Flat;
            btnLogOutSideBar.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutSideBar.ForeColor = Color.White;
            btnLogOutSideBar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogOutSideBar.IconColor = Color.White;
            btnLogOutSideBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogOutSideBar.IconSize = 27;
            btnLogOutSideBar.Location = new Point(3, 635);
            btnLogOutSideBar.Name = "btnLogOutSideBar";
            btnLogOutSideBar.Size = new Size(196, 43);
            btnLogOutSideBar.TabIndex = 15;
            btnLogOutSideBar.Text = "Log Out";
            btnLogOutSideBar.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOutSideBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOutSideBar.UseVisualStyleBackColor = false;
            btnLogOutSideBar.Click += btnLogOutSideBar_Click;
            btnLogOutSideBar.MouseEnter += btnLbl_MouseEnter;
            btnLogOutSideBar.MouseLeave += btnLbl_MouseLeave;
            // 
            // btnHelpAndSupport
            // 
            btnHelpAndSupport.BackColor = Color.FromArgb(0, 26, 136);
            btnHelpAndSupport.FlatAppearance.BorderSize = 0;
            btnHelpAndSupport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHelpAndSupport.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHelpAndSupport.FlatStyle = FlatStyle.Flat;
            btnHelpAndSupport.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHelpAndSupport.ForeColor = Color.White;
            btnHelpAndSupport.IconChar = FontAwesome.Sharp.IconChar.Comments;
            btnHelpAndSupport.IconColor = Color.White;
            btnHelpAndSupport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHelpAndSupport.IconSize = 27;
            btnHelpAndSupport.Location = new Point(18, 542);
            btnHelpAndSupport.Name = "btnHelpAndSupport";
            btnHelpAndSupport.Size = new Size(211, 37);
            btnHelpAndSupport.TabIndex = 14;
            btnHelpAndSupport.Text = "Help and Support";
            btnHelpAndSupport.TextAlign = ContentAlignment.MiddleLeft;
            btnHelpAndSupport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHelpAndSupport.UseVisualStyleBackColor = false;
            btnHelpAndSupport.Click += btnHelpAndSupport_Click;
            btnHelpAndSupport.MouseEnter += btnLbl_MouseEnter;
            btnHelpAndSupport.MouseLeave += btnLbl_MouseLeave;
            // 
            // btnConversionRate
            // 
            btnConversionRate.BackColor = Color.FromArgb(0, 26, 136);
            btnConversionRate.FlatAppearance.BorderSize = 0;
            btnConversionRate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConversionRate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConversionRate.FlatStyle = FlatStyle.Flat;
            btnConversionRate.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConversionRate.ForeColor = Color.White;
            btnConversionRate.IconChar = FontAwesome.Sharp.IconChar.Coins;
            btnConversionRate.IconColor = Color.White;
            btnConversionRate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConversionRate.IconSize = 27;
            btnConversionRate.Location = new Point(18, 501);
            btnConversionRate.Name = "btnConversionRate";
            btnConversionRate.Size = new Size(211, 35);
            btnConversionRate.TabIndex = 12;
            btnConversionRate.Text = "Conversion Rate";
            btnConversionRate.TextAlign = ContentAlignment.MiddleLeft;
            btnConversionRate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConversionRate.UseVisualStyleBackColor = false;
            btnConversionRate.Click += btnConversionRate_Click;
            btnConversionRate.MouseEnter += btnLbl_MouseEnter;
            btnConversionRate.MouseLeave += btnLbl_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 26, 136);
            label4.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(152, 224, 255);
            label4.Location = new Point(18, 468);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 11;
            label4.Text = "TOOLS";
            // 
            // btnTransferMoney
            // 
            btnTransferMoney.BackColor = Color.FromArgb(0, 26, 136);
            btnTransferMoney.FlatAppearance.BorderSize = 0;
            btnTransferMoney.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTransferMoney.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTransferMoney.FlatStyle = FlatStyle.Flat;
            btnTransferMoney.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransferMoney.ForeColor = Color.White;
            btnTransferMoney.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            btnTransferMoney.IconColor = Color.White;
            btnTransferMoney.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTransferMoney.IconSize = 27;
            btnTransferMoney.Location = new Point(18, 424);
            btnTransferMoney.Name = "btnTransferMoney";
            btnTransferMoney.Size = new Size(211, 36);
            btnTransferMoney.TabIndex = 10;
            btnTransferMoney.Text = "Transfer Money";
            btnTransferMoney.TextAlign = ContentAlignment.MiddleLeft;
            btnTransferMoney.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferMoney.UseVisualStyleBackColor = false;
            btnTransferMoney.Click += btnTransferMoney_Click;
            btnTransferMoney.MouseEnter += btnLbl_MouseEnter;
            btnTransferMoney.MouseLeave += btnLbl_MouseLeave;
            // 
            // btnShowHistory
            // 
            btnShowHistory.BackColor = Color.FromArgb(0, 26, 136);
            btnShowHistory.FlatAppearance.BorderSize = 0;
            btnShowHistory.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnShowHistory.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShowHistory.FlatStyle = FlatStyle.Flat;
            btnShowHistory.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowHistory.ForeColor = Color.White;
            btnShowHistory.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            btnShowHistory.IconColor = Color.White;
            btnShowHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowHistory.IconSize = 27;
            btnShowHistory.Location = new Point(13, 381);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(211, 33);
            btnShowHistory.TabIndex = 9;
            btnShowHistory.Text = "Show History";
            btnShowHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnShowHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShowHistory.UseVisualStyleBackColor = false;
            btnShowHistory.Click += btnShowHistory_Click;
            btnShowHistory.MouseEnter += btnLbl_MouseEnter;
            btnShowHistory.MouseLeave += btnLbl_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 26, 136);
            label3.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(152, 224, 255);
            label3.Location = new Point(18, 346);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 8;
            label3.Text = "TRANSACTIONS";
            // 
            // btnEnrolledContacts
            // 
            btnEnrolledContacts.BackColor = Color.FromArgb(0, 26, 136);
            btnEnrolledContacts.FlatAppearance.BorderSize = 0;
            btnEnrolledContacts.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEnrolledContacts.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEnrolledContacts.FlatStyle = FlatStyle.Flat;
            btnEnrolledContacts.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnrolledContacts.ForeColor = Color.White;
            btnEnrolledContacts.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            btnEnrolledContacts.IconColor = Color.White;
            btnEnrolledContacts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEnrolledContacts.IconSize = 27;
            btnEnrolledContacts.Location = new Point(18, 293);
            btnEnrolledContacts.Name = "btnEnrolledContacts";
            btnEnrolledContacts.Size = new Size(211, 36);
            btnEnrolledContacts.TabIndex = 3;
            btnEnrolledContacts.Text = "Enrolled Contacts";
            btnEnrolledContacts.TextAlign = ContentAlignment.MiddleLeft;
            btnEnrolledContacts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnrolledContacts.UseVisualStyleBackColor = false;
            btnEnrolledContacts.Click += btnEnrolledContacts_Click;
            btnEnrolledContacts.MouseEnter += btnLbl_MouseEnter;
            btnEnrolledContacts.MouseLeave += btnLbl_MouseLeave;
            // 
            // btnSidePanelClose
            // 
            btnSidePanelClose.BackColor = Color.FromArgb(0, 26, 136);
            btnSidePanelClose.FlatAppearance.BorderSize = 0;
            btnSidePanelClose.FlatStyle = FlatStyle.Flat;
            btnSidePanelClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnSidePanelClose.IconColor = Color.White;
            btnSidePanelClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSidePanelClose.IconSize = 25;
            btnSidePanelClose.Location = new Point(204, 4);
            btnSidePanelClose.Name = "btnSidePanelClose";
            btnSidePanelClose.Size = new Size(47, 37);
            btnSidePanelClose.TabIndex = 6;
            btnSidePanelClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 26, 136);
            label2.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(152, 224, 255);
            label2.Location = new Point(18, 265);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 0;
            label2.Text = "RECIPIENTS";
            // 
            // btnAccounts
            // 
            btnAccounts.BackColor = Color.FromArgb(0, 26, 136);
            btnAccounts.FlatAppearance.BorderSize = 0;
            btnAccounts.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAccounts.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAccounts.FlatStyle = FlatStyle.Flat;
            btnAccounts.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccounts.ForeColor = Color.White;
            btnAccounts.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            btnAccounts.IconColor = Color.White;
            btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccounts.IconSize = 27;
            btnAccounts.Location = new Point(0, 220);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(195, 31);
            btnAccounts.TabIndex = 2;
            btnAccounts.Text = "Accounts";
            btnAccounts.TextAlign = ContentAlignment.MiddleLeft;
            btnAccounts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccounts.UseVisualStyleBackColor = false;
            btnAccounts.Click += btnAccounts_Click;
            btnAccounts.MouseEnter += btnLbl_MouseEnter;
            btnAccounts.MouseLeave += btnLbl_MouseLeave;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 26, 136);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 27;
            btnDashboard.Location = new Point(3, 181);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(195, 31);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseEnter += btnLbl_MouseEnter;
            btnDashboard.MouseLeave += btnLbl_MouseLeave;
            // 
            // HEADERPANEL
            // 
            HEADERPANEL.Controls.Add(SUBHEADERLBLONLY);
            HEADERPANEL.Controls.Add(HEADERLBLONLY);
            HEADERPANEL.Controls.Add(TRUSTBANKLOGOONLY);
            HEADERPANEL.Location = new Point(0, 71);
            HEADERPANEL.Name = "HEADERPANEL";
            HEADERPANEL.Size = new Size(251, 95);
            HEADERPANEL.TabIndex = 1;
            // 
            // SUBHEADERLBLONLY
            // 
            SUBHEADERLBLONLY.AutoSize = true;
            SUBHEADERLBLONLY.BackColor = Color.Transparent;
            SUBHEADERLBLONLY.Font = new Font("Gothic A1", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            SUBHEADERLBLONLY.ForeColor = Color.FromArgb(0, 26, 136);
            SUBHEADERLBLONLY.Location = new Point(68, 56);
            SUBHEADERLBLONLY.Name = "SUBHEADERLBLONLY";
            SUBHEADERLBLONLY.Size = new Size(181, 17);
            SUBHEADERLBLONLY.TabIndex = 2;
            SUBHEADERLBLONLY.Text = "Where Your Wealth Finds Security";
            // 
            // HEADERLBLONLY
            // 
            HEADERLBLONLY.AutoSize = true;
            HEADERLBLONLY.BackColor = Color.Transparent;
            HEADERLBLONLY.Font = new Font("Gothic A1 ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            HEADERLBLONLY.ForeColor = Color.FromArgb(0, 26, 136);
            HEADERLBLONLY.Location = new Point(68, 12);
            HEADERLBLONLY.Name = "HEADERLBLONLY";
            HEADERLBLONLY.Size = new Size(179, 51);
            HEADERLBLONLY.TabIndex = 1;
            HEADERLBLONLY.Text = "Trustbank";
            // 
            // TRUSTBANKLOGOONLY
            // 
            TRUSTBANKLOGOONLY.BackColor = Color.Transparent;
            TRUSTBANKLOGOONLY.Image = (Image)resources.GetObject("TRUSTBANKLOGOONLY.Image");
            TRUSTBANKLOGOONLY.Location = new Point(0, 12);
            TRUSTBANKLOGOONLY.Name = "TRUSTBANKLOGOONLY";
            TRUSTBANKLOGOONLY.Size = new Size(78, 69);
            TRUSTBANKLOGOONLY.SizeMode = PictureBoxSizeMode.Zoom;
            TRUSTBANKLOGOONLY.TabIndex = 1;
            TRUSTBANKLOGOONLY.TabStop = false;
            // 
            // headerContainerPanel
            // 
            headerContainerPanel.Controls.Add(label1);
            headerContainerPanel.Controls.Add(trustBankHeaderLogo);
            headerContainerPanel.Controls.Add(lblTrustbankTitle);
            headerContainerPanel.Controls.Add(btnLogOut);
            headerContainerPanel.Controls.Add(btnHamburger);
            headerContainerPanel.Location = new Point(0, 0);
            headerContainerPanel.Name = "headerContainerPanel";
            headerContainerPanel.Size = new Size(1405, 131);
            headerContainerPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 26, 136);
            label1.Location = new Point(566, 71);
            label1.Name = "label1";
            label1.Size = new Size(264, 25);
            label1.TabIndex = 4;
            label1.Text = "Where Your Wealth Finds Security";
            // 
            // trustBankHeaderLogo
            // 
            trustBankHeaderLogo.Image = (Image)resources.GetObject("trustBankHeaderLogo.Image");
            trustBankHeaderLogo.Location = new Point(442, 3);
            trustBankHeaderLogo.Name = "trustBankHeaderLogo";
            trustBankHeaderLogo.Size = new Size(128, 109);
            trustBankHeaderLogo.SizeMode = PictureBoxSizeMode.Zoom;
            trustBankHeaderLogo.TabIndex = 3;
            trustBankHeaderLogo.TabStop = false;
            // 
            // lblTrustbankTitle
            // 
            lblTrustbankTitle.AutoSize = true;
            lblTrustbankTitle.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrustbankTitle.ForeColor = Color.FromArgb(0, 26, 136);
            lblTrustbankTitle.Location = new Point(570, 4);
            lblTrustbankTitle.Name = "lblTrustbankTitle";
            lblTrustbankTitle.Size = new Size(239, 69);
            lblTrustbankTitle.TabIndex = 0;
            lblTrustbankTitle.Text = "Trustbank";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogOut.IconColor = Color.FromArgb(0, 26, 136);
            btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogOut.Location = new Point(1312, 13);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(81, 56);
            btnLogOut.TabIndex = 2;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnHamburger
            // 
            btnHamburger.BackColor = Color.Transparent;
            btnHamburger.FlatAppearance.BorderSize = 0;
            btnHamburger.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHamburger.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHamburger.FlatStyle = FlatStyle.Flat;
            btnHamburger.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnHamburger.IconColor = Color.FromArgb(0, 26, 136);
            btnHamburger.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHamburger.Location = new Point(13, 13);
            btnHamburger.Name = "btnHamburger";
            btnHamburger.Size = new Size(62, 57);
            btnHamburger.TabIndex = 1;
            btnHamburger.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1404, 751);
            Controls.Add(mainFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            mainFormPanel.ResumeLayout(false);
            slidingPanel.ResumeLayout(false);
            slidingPanel.PerformLayout();
            HEADERPANEL.ResumeLayout(false);
            HEADERPANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGOONLY).EndInit();
            headerContainerPanel.ResumeLayout(false);
            headerContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trustBankHeaderLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainFormPanel;
        private ReaLTaiizor.Controls.ParrotSlidingPanel slidingPanel;
        private Panel HEADERPANEL;
        private Label HEADERLBLONLY;
        private Label SUBHEADERLBLONLY;
        private PictureBox TRUSTBANKLOGOONLY;
        private FontAwesome.Sharp.IconButton btnHamburger;
        private Panel headerContainerPanel;
        private Panel parentContainerPanel;
        private PictureBox trustBankHeaderLogo;
        private Label lblTrustbankTitle;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnAccounts;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnSidePanelClose;
        private FontAwesome.Sharp.IconButton btnEnrolledContacts;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnShowHistory;
        private FontAwesome.Sharp.IconButton btnTransferMoney;
        private FontAwesome.Sharp.IconButton btnConversionRate;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnLogOutSideBar;
        private FontAwesome.Sharp.IconButton btnHelpAndSupport;
    }
}