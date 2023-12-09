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
            parentContainerPanel = new Panel();
            slidingPanel = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            HEADERPANEL = new Panel();
            SUBHEADERLBLONLY = new Label();
            HEADERLBLONLY = new Label();
            TRUSTBANKLOGOONLY = new PictureBox();
            headerContainerPanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblTrustbankTitle = new Label();
            btnLogOut = new FontAwesome.Sharp.IconButton();
            btnHamburger = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            mainFormPanel.SuspendLayout();
            slidingPanel.SuspendLayout();
            HEADERPANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGOONLY).BeginInit();
            headerContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // parentContainerPanel
            // 
            parentContainerPanel.Font = new Font("Gothic A1 SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            parentContainerPanel.Location = new Point(0, 137);
            parentContainerPanel.Name = "parentContainerPanel";
            parentContainerPanel.Size = new Size(1405, 616);
            parentContainerPanel.TabIndex = 3;
            // 
            // slidingPanel
            // 
            slidingPanel.BottomLeft = Color.Black;
            slidingPanel.BottomRight = Color.DodgerBlue;
            slidingPanel.CollapseControl = parentContainerPanel;
            slidingPanel.Collapsed = true;
            slidingPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            slidingPanel.Controls.Add(btnDashboard);
            slidingPanel.Controls.Add(HEADERPANEL);
            slidingPanel.Dock = DockStyle.Left;
            slidingPanel.HideControls = false;
            slidingPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            slidingPanel.Location = new Point(0, 0);
            slidingPanel.Name = "slidingPanel";
            slidingPanel.PanelWidthCollapsed = 251;
            slidingPanel.PanelWidthExpanded = 251;
            slidingPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            slidingPanel.PrimerColor = Color.White;
            slidingPanel.Size = new Size(251, 753);
            slidingPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            slidingPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            slidingPanel.TabIndex = 0;
            slidingPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            slidingPanel.TopLeft = Color.FromArgb(0, 26, 136);
            slidingPanel.TopRight = Color.FromArgb(0, 26, 136);
            // 
            // HEADERPANEL
            // 
            HEADERPANEL.Controls.Add(SUBHEADERLBLONLY);
            HEADERPANEL.Controls.Add(HEADERLBLONLY);
            HEADERPANEL.Controls.Add(TRUSTBANKLOGOONLY);
            HEADERPANEL.Location = new Point(0, 39);
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
            headerContainerPanel.Controls.Add(pictureBox1);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(442, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 26, 136);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.H;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.Location = new Point(25, 190);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(195, 52);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
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
            HEADERPANEL.ResumeLayout(false);
            HEADERPANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGOONLY).EndInit();
            headerContainerPanel.ResumeLayout(false);
            headerContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label lblTrustbankTitle;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnDashboard;
    }
}