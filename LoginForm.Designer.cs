namespace Trustbank
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            HEADERLBLONLY = new Label();
            LoginPanel = new ReaLTaiizor.Controls.Panel();
            btnLblRecoverAccess = new Label();
            btnLblSignUp = new Label();
            btnParrotLogin = new ReaLTaiizor.Controls.ParrotButton();
            BTNPASSWORDLOGO = new FontAwesome.Sharp.IconButton();
            BTNUSERLOGO = new FontAwesome.Sharp.IconButton();
            LINE2 = new Panel();
            LINE1 = new Panel();
            txtBxPassword = new TextBox();
            txtBxUsername = new TextBox();
            TRUSTBANKLOGO = new PictureBox();
            TRUSTBANKLBLONLY = new Label();
            pictureBox1 = new PictureBox();
            btnShutdown = new FontAwesome.Sharp.IconButton();
            btnAbout = new FontAwesome.Sharp.IconButton();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // HEADERLBLONLY
            // 
            HEADERLBLONLY.AutoSize = true;
            HEADERLBLONLY.Font = new Font("Gothic A1 ExtraBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            HEADERLBLONLY.ForeColor = Color.FromArgb(0, 26, 136);
            HEADERLBLONLY.Location = new Point(317, 92);
            HEADERLBLONLY.Name = "HEADERLBLONLY";
            HEADERLBLONLY.Size = new Size(819, 76);
            HEADERLBLONLY.TabIndex = 0;
            HEADERLBLONLY.Text = "Where Your Wealth Finds Security";
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(230, 230, 230);
            LoginPanel.Controls.Add(btnLblRecoverAccess);
            LoginPanel.Controls.Add(btnLblSignUp);
            LoginPanel.Controls.Add(btnParrotLogin);
            LoginPanel.Controls.Add(BTNPASSWORDLOGO);
            LoginPanel.Controls.Add(BTNUSERLOGO);
            LoginPanel.Controls.Add(LINE2);
            LoginPanel.Controls.Add(LINE1);
            LoginPanel.Controls.Add(txtBxPassword);
            LoginPanel.Controls.Add(txtBxUsername);
            LoginPanel.Controls.Add(TRUSTBANKLOGO);
            LoginPanel.Controls.Add(TRUSTBANKLBLONLY);
            LoginPanel.EdgeColor = Color.White;
            LoginPanel.Location = new Point(405, 184);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Padding = new Padding(5);
            LoginPanel.Size = new Size(609, 327);
            LoginPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            LoginPanel.TabIndex = 1;
            LoginPanel.Text = "panel1";
            LoginPanel.Click += setFocusToOther;
            // 
            // btnLblRecoverAccess
            // 
            btnLblRecoverAccess.AutoSize = true;
            btnLblRecoverAccess.FlatStyle = FlatStyle.Flat;
            btnLblRecoverAccess.Font = new Font("Gothic A1 SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLblRecoverAccess.ForeColor = Color.FromArgb(0, 26, 136);
            btnLblRecoverAccess.Location = new Point(436, 281);
            btnLblRecoverAccess.Name = "btnLblRecoverAccess";
            btnLblRecoverAccess.Size = new Size(128, 25);
            btnLblRecoverAccess.TabIndex = 5;
            btnLblRecoverAccess.Text = "Recover Access";
            btnLblRecoverAccess.MouseEnter += btnLblRecoverAccess_MouseEnter;
            btnLblRecoverAccess.MouseLeave += btnLblRecoverAccess_MouseLeave;
            // 
            // btnLblSignUp
            // 
            btnLblSignUp.AutoSize = true;
            btnLblSignUp.FlatStyle = FlatStyle.Flat;
            btnLblSignUp.Font = new Font("Gothic A1 SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLblSignUp.ForeColor = Color.FromArgb(0, 26, 136);
            btnLblSignUp.Location = new Point(35, 281);
            btnLblSignUp.Name = "btnLblSignUp";
            btnLblSignUp.Size = new Size(70, 25);
            btnLblSignUp.TabIndex = 4;
            btnLblSignUp.Text = "Sign Up";
            btnLblSignUp.Click += btnLblSignUp_Click;
            btnLblSignUp.MouseEnter += btnLblSignUp_MouseEnter;
            btnLblSignUp.MouseLeave += btnLblSignUp_MouseLeave;
            // 
            // btnParrotLogin
            // 
            btnParrotLogin.BackgroundColor = Color.FromArgb(25, 48, 147);
            btnParrotLogin.ButtonImage = null;
            btnParrotLogin.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnParrotLogin.ButtonText = "LOGIN";
            btnParrotLogin.ClickBackColor = Color.FromArgb(0, 20, 108);
            btnParrotLogin.ClickTextColor = Color.White;
            btnParrotLogin.CornerRadius = 7;
            btnParrotLogin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnParrotLogin.Horizontal_Alignment = StringAlignment.Center;
            btnParrotLogin.HoverBackgroundColor = Color.FromArgb(0, 20, 108);
            btnParrotLogin.HoverTextColor = Color.White;
            btnParrotLogin.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnParrotLogin.Location = new Point(38, 226);
            btnParrotLogin.Name = "btnParrotLogin";
            btnParrotLogin.Size = new Size(526, 50);
            btnParrotLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnParrotLogin.TabIndex = 3;
            btnParrotLogin.TextColor = Color.White;
            btnParrotLogin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnParrotLogin.Vertical_Alignment = StringAlignment.Center;
            // 
            // BTNPASSWORDLOGO
            // 
            BTNPASSWORDLOGO.Enabled = false;
            BTNPASSWORDLOGO.FlatAppearance.BorderSize = 0;
            BTNPASSWORDLOGO.FlatStyle = FlatStyle.Flat;
            BTNPASSWORDLOGO.IconChar = FontAwesome.Sharp.IconChar.Lock;
            BTNPASSWORDLOGO.IconColor = Color.FromArgb(181, 181, 181);
            BTNPASSWORDLOGO.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTNPASSWORDLOGO.IconSize = 25;
            BTNPASSWORDLOGO.Location = new Point(38, 182);
            BTNPASSWORDLOGO.Name = "BTNPASSWORDLOGO";
            BTNPASSWORDLOGO.Size = new Size(28, 28);
            BTNPASSWORDLOGO.TabIndex = 0;
            BTNPASSWORDLOGO.UseVisualStyleBackColor = true;
            // 
            // BTNUSERLOGO
            // 
            BTNUSERLOGO.Enabled = false;
            BTNUSERLOGO.FlatAppearance.BorderSize = 0;
            BTNUSERLOGO.FlatStyle = FlatStyle.Flat;
            BTNUSERLOGO.IconChar = FontAwesome.Sharp.IconChar.User;
            BTNUSERLOGO.IconColor = Color.FromArgb(181, 181, 181);
            BTNUSERLOGO.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BTNUSERLOGO.IconSize = 25;
            BTNUSERLOGO.Location = new Point(38, 133);
            BTNUSERLOGO.Name = "BTNUSERLOGO";
            BTNUSERLOGO.Size = new Size(28, 28);
            BTNUSERLOGO.TabIndex = 0;
            BTNUSERLOGO.UseVisualStyleBackColor = true;
            // 
            // LINE2
            // 
            LINE2.BackColor = Color.FromArgb(181, 181, 181);
            LINE2.Location = new Point(72, 206);
            LINE2.Name = "LINE2";
            LINE2.Size = new Size(492, 1);
            LINE2.TabIndex = 0;
            // 
            // LINE1
            // 
            LINE1.BackColor = Color.FromArgb(181, 181, 181);
            LINE1.Location = new Point(72, 155);
            LINE1.Name = "LINE1";
            LINE1.Size = new Size(492, 1);
            LINE1.TabIndex = 0;
            // 
            // txtBxPassword
            // 
            txtBxPassword.BackColor = Color.FromArgb(230, 230, 230);
            txtBxPassword.BorderStyle = BorderStyle.None;
            txtBxPassword.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxPassword.ForeColor = Color.Black;
            txtBxPassword.Location = new Point(72, 181);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.PlaceholderText = "Password";
            txtBxPassword.Size = new Size(490, 20);
            txtBxPassword.TabIndex = 2;
            // 
            // txtBxUsername
            // 
            txtBxUsername.BackColor = Color.FromArgb(230, 230, 230);
            txtBxUsername.BorderStyle = BorderStyle.None;
            txtBxUsername.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxUsername.ForeColor = Color.Black;
            txtBxUsername.Location = new Point(72, 130);
            txtBxUsername.Name = "txtBxUsername";
            txtBxUsername.PlaceholderText = "Username";
            txtBxUsername.Size = new Size(490, 20);
            txtBxUsername.TabIndex = 1;
            // 
            // TRUSTBANKLOGO
            // 
            TRUSTBANKLOGO.Image = (Image)resources.GetObject("TRUSTBANKLOGO.Image");
            TRUSTBANKLOGO.Location = new Point(142, 11);
            TRUSTBANKLOGO.Name = "TRUSTBANKLOGO";
            TRUSTBANKLOGO.Size = new Size(105, 94);
            TRUSTBANKLOGO.SizeMode = PictureBoxSizeMode.Zoom;
            TRUSTBANKLOGO.TabIndex = 1;
            TRUSTBANKLOGO.TabStop = false;
            // 
            // TRUSTBANKLBLONLY
            // 
            TRUSTBANKLBLONLY.AutoSize = true;
            TRUSTBANKLBLONLY.Font = new Font("Gothic A1 ExtraBold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            TRUSTBANKLBLONLY.ForeColor = Color.FromArgb(0, 26, 136);
            TRUSTBANKLBLONLY.Location = new Point(238, 26);
            TRUSTBANKLBLONLY.Name = "TRUSTBANKLBLONLY";
            TRUSTBANKLBLONLY.Size = new Size(221, 63);
            TRUSTBANKLBLONLY.TabIndex = 0;
            TRUSTBANKLBLONLY.Text = "Trustbank";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, 493);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1430, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnShutdown
            // 
            btnShutdown.FlatAppearance.BorderSize = 0;
            btnShutdown.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnShutdown.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShutdown.FlatStyle = FlatStyle.Flat;
            btnShutdown.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            btnShutdown.IconColor = Color.FromArgb(0, 26, 136);
            btnShutdown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShutdown.Location = new Point(1312, 12);
            btnShutdown.Name = "btnShutdown";
            btnShutdown.Size = new Size(80, 71);
            btnShutdown.TabIndex = 3;
            btnShutdown.UseVisualStyleBackColor = true;
            btnShutdown.Click += btnShutdown_Click;
            // 
            // btnAbout
            // 
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAbout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            btnAbout.IconColor = Color.FromArgb(0, 26, 136);
            btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbout.Location = new Point(12, 12);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(59, 54);
            btnAbout.TabIndex = 4;
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1420, 790);
            Controls.Add(btnAbout);
            Controls.Add(btnShutdown);
            Controls.Add(LoginPanel);
            Controls.Add(HEADERLBLONLY);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trustbank - Login";
            Click += setFocusToOther;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HEADERLBLONLY;
        private ReaLTaiizor.Controls.Panel LoginPanel;
        private Label TRUSTBANKLBLONLY;
        private PictureBox TRUSTBANKLOGO;
        private TextBox txtBxUsername;
        private Panel LINE1;
        private TextBox txtBxPassword;
        private PictureBox pictureBox1;
        private Panel LINE2;
        private FontAwesome.Sharp.IconButton BTNUSERLOGO;
        private FontAwesome.Sharp.IconButton BTNPASSWORDLOGO;
        private ReaLTaiizor.Controls.ParrotButton btnParrotLogin;
        private FontAwesome.Sharp.IconButton btnShutdown;
        private FontAwesome.Sharp.IconButton btnAbout;
        private Label btnLblRecoverAccess;
        private Label btnLblSignUp;
    }
}
