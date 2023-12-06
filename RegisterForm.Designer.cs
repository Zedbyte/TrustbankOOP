namespace Trustbank
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            TRUSTBANKLBLONLY = new Label();
            TRUSTBANKLOGO = new PictureBox();
            HEADERLBLONLY = new Label();
            signUpHeaderImage = new PictureBox();
            btnNext = new Button();
            LINE1 = new Panel();
            prtBtn1 = new ReaLTaiizor.Controls.ParrotButton();
            prtBtn5 = new ReaLTaiizor.Controls.ParrotButton();
            prtBtn2 = new ReaLTaiizor.Controls.ParrotButton();
            prtBtn4 = new ReaLTaiizor.Controls.ParrotButton();
            prtBtn3 = new ReaLTaiizor.Controls.ParrotButton();
            LINE2 = new Panel();
            LINE3 = new Panel();
            LINE4 = new Panel();
            prtBtnsPanel = new Panel();
            lblDone = new Label();
            lblVerification = new Label();
            lblConfirmation = new Label();
            lblPasscode = new Label();
            lblDetails = new Label();
            gradientPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            detailsPanel = new Panel();
            mobileNumberPrefix = new ComboBox();
            passwordRequirementsPanel = new Panel();
            lblDigitReq = new Label();
            label13 = new Label();
            lblUppercaseReq = new Label();
            lblNumberOfCharactersReq = new Label();
            lblSpecialCharacterReq = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBxUsername = new TextBox();
            txtBxPassword = new TextBox();
            button1 = new Button();
            lblTermsAndService4 = new Label();
            lblTermsAndService3 = new Label();
            lblTermsAndService2 = new Label();
            lblTermsAndService1 = new Label();
            checkBxMetroTermsAndService = new ReaLTaiizor.Controls.MetroCheckBox();
            lblAccountAliasFillUp = new Label();
            txtBxAccountAlias = new TextBox();
            lblAccountNumberFillUp = new Label();
            txtBxAccountNumber = new TextBox();
            lblMobileNumberFillUp = new Label();
            txtBxMobileNumber = new TextBox();
            btnDeposit = new Button();
            btnSavings = new Button();
            lblEmailAddressFillUp = new Label();
            txtBxEmailAddress = new TextBox();
            lblLastNameFillUp = new Label();
            txtBxLastName = new TextBox();
            lblMiddleNameFillUp = new Label();
            txtBxMiddleName = new TextBox();
            lblFirstNameFillUp = new Label();
            txtBxFirstName = new TextBox();
            lblPasswordFillUp = new Label();
            lblUsernameFillUp = new Label();
            parentRegistrationPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signUpHeaderImage).BeginInit();
            prtBtnsPanel.SuspendLayout();
            detailsPanel.SuspendLayout();
            passwordRequirementsPanel.SuspendLayout();
            parentRegistrationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TRUSTBANKLBLONLY
            // 
            TRUSTBANKLBLONLY.BackColor = Color.Transparent;
            TRUSTBANKLBLONLY.Font = new Font("Gothic A1", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            TRUSTBANKLBLONLY.ForeColor = Color.FromArgb(0, 26, 136);
            TRUSTBANKLBLONLY.Location = new Point(621, 20);
            TRUSTBANKLBLONLY.Name = "TRUSTBANKLBLONLY";
            TRUSTBANKLBLONLY.Size = new Size(234, 57);
            TRUSTBANKLBLONLY.TabIndex = 0;
            TRUSTBANKLBLONLY.Text = "Trustbank";
            // 
            // TRUSTBANKLOGO
            // 
            TRUSTBANKLOGO.BackColor = Color.Transparent;
            TRUSTBANKLOGO.Image = (Image)resources.GetObject("TRUSTBANKLOGO.Image");
            TRUSTBANKLOGO.Location = new Point(527, 19);
            TRUSTBANKLOGO.Name = "TRUSTBANKLOGO";
            TRUSTBANKLOGO.Size = new Size(105, 94);
            TRUSTBANKLOGO.SizeMode = PictureBoxSizeMode.Zoom;
            TRUSTBANKLOGO.TabIndex = 2;
            TRUSTBANKLOGO.TabStop = false;
            // 
            // HEADERLBLONLY
            // 
            HEADERLBLONLY.AutoSize = true;
            HEADERLBLONLY.BackColor = Color.Transparent;
            HEADERLBLONLY.Font = new Font("Gothic A1 SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HEADERLBLONLY.ForeColor = Color.FromArgb(0, 26, 136);
            HEADERLBLONLY.Location = new Point(633, 77);
            HEADERLBLONLY.Name = "HEADERLBLONLY";
            HEADERLBLONLY.Size = new Size(215, 21);
            HEADERLBLONLY.TabIndex = 3;
            HEADERLBLONLY.Text = "Where Your Wealth Finds Security";
            // 
            // signUpHeaderImage
            // 
            signUpHeaderImage.Image = (Image)resources.GetObject("signUpHeaderImage.Image");
            signUpHeaderImage.Location = new Point(-35, -5);
            signUpHeaderImage.Name = "signUpHeaderImage";
            signUpHeaderImage.Size = new Size(1463, 263);
            signUpHeaderImage.SizeMode = PictureBoxSizeMode.StretchImage;
            signUpHeaderImage.TabIndex = 4;
            signUpHeaderImage.TabStop = false;
            signUpHeaderImage.Click += setFocusToOther;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 26, 136);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(476, 843);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(453, 48);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // LINE1
            // 
            LINE1.BackColor = Color.FromArgb(149, 149, 149);
            LINE1.Location = new Point(327, 42);
            LINE1.Name = "LINE1";
            LINE1.Size = new Size(134, 1);
            LINE1.TabIndex = 0;
            // 
            // prtBtn1
            // 
            prtBtn1.Anchor = AnchorStyles.None;
            prtBtn1.BackgroundColor = Color.FromArgb(7, 166, 234);
            prtBtn1.ButtonImage = null;
            prtBtn1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialEllipse;
            prtBtn1.ButtonText = "1";
            prtBtn1.ClickBackColor = Color.FromArgb(195, 200, 185);
            prtBtn1.ClickTextColor = Color.FromArgb(195, 200, 185);
            prtBtn1.CornerRadius = 5;
            prtBtn1.Enabled = false;
            prtBtn1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prtBtn1.Horizontal_Alignment = StringAlignment.Center;
            prtBtn1.HoverBackgroundColor = Color.FromArgb(195, 200, 185);
            prtBtn1.HoverTextColor = Color.FromArgb(65, 70, 75);
            prtBtn1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            prtBtn1.Location = new Point(273, 26);
            prtBtn1.Name = "prtBtn1";
            prtBtn1.Size = new Size(35, 32);
            prtBtn1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            prtBtn1.TabIndex = 0;
            prtBtn1.TextColor = Color.White;
            prtBtn1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            prtBtn1.Vertical_Alignment = StringAlignment.Center;
            // 
            // prtBtn5
            // 
            prtBtn5.Anchor = AnchorStyles.None;
            prtBtn5.BackgroundColor = Color.FromArgb(149, 149, 149);
            prtBtn5.ButtonImage = null;
            prtBtn5.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialEllipse;
            prtBtn5.ButtonText = "5";
            prtBtn5.ClickBackColor = Color.FromArgb(195, 200, 185);
            prtBtn5.ClickTextColor = Color.FromArgb(195, 200, 185);
            prtBtn5.CornerRadius = 5;
            prtBtn5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prtBtn5.Horizontal_Alignment = StringAlignment.Center;
            prtBtn5.HoverBackgroundColor = Color.FromArgb(195, 200, 185);
            prtBtn5.HoverTextColor = Color.FromArgb(65, 70, 75);
            prtBtn5.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            prtBtn5.Location = new Point(1122, 26);
            prtBtn5.Name = "prtBtn5";
            prtBtn5.Size = new Size(35, 32);
            prtBtn5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            prtBtn5.TabIndex = 0;
            prtBtn5.TextColor = Color.White;
            prtBtn5.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            prtBtn5.Vertical_Alignment = StringAlignment.Center;
            // 
            // prtBtn2
            // 
            prtBtn2.Anchor = AnchorStyles.None;
            prtBtn2.BackgroundColor = Color.FromArgb(149, 149, 149);
            prtBtn2.ButtonImage = null;
            prtBtn2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialEllipse;
            prtBtn2.ButtonText = "2";
            prtBtn2.ClickBackColor = Color.FromArgb(195, 200, 185);
            prtBtn2.ClickTextColor = Color.FromArgb(195, 200, 185);
            prtBtn2.CornerRadius = 5;
            prtBtn2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prtBtn2.Horizontal_Alignment = StringAlignment.Center;
            prtBtn2.HoverBackgroundColor = Color.FromArgb(195, 200, 185);
            prtBtn2.HoverTextColor = Color.FromArgb(65, 70, 75);
            prtBtn2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            prtBtn2.Location = new Point(485, 26);
            prtBtn2.Name = "prtBtn2";
            prtBtn2.Size = new Size(35, 32);
            prtBtn2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            prtBtn2.TabIndex = 0;
            prtBtn2.TextColor = Color.White;
            prtBtn2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            prtBtn2.Vertical_Alignment = StringAlignment.Center;
            // 
            // prtBtn4
            // 
            prtBtn4.Anchor = AnchorStyles.None;
            prtBtn4.BackgroundColor = Color.FromArgb(149, 149, 149);
            prtBtn4.ButtonImage = null;
            prtBtn4.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialEllipse;
            prtBtn4.ButtonText = "4";
            prtBtn4.ClickBackColor = Color.FromArgb(195, 200, 185);
            prtBtn4.ClickTextColor = Color.FromArgb(195, 200, 185);
            prtBtn4.CornerRadius = 5;
            prtBtn4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prtBtn4.Horizontal_Alignment = StringAlignment.Center;
            prtBtn4.HoverBackgroundColor = Color.FromArgb(195, 200, 185);
            prtBtn4.HoverTextColor = Color.FromArgb(65, 70, 75);
            prtBtn4.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            prtBtn4.Location = new Point(909, 26);
            prtBtn4.Name = "prtBtn4";
            prtBtn4.Size = new Size(35, 32);
            prtBtn4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            prtBtn4.TabIndex = 0;
            prtBtn4.TextColor = Color.White;
            prtBtn4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            prtBtn4.Vertical_Alignment = StringAlignment.Center;
            // 
            // prtBtn3
            // 
            prtBtn3.Anchor = AnchorStyles.None;
            prtBtn3.BackgroundColor = Color.FromArgb(149, 149, 149);
            prtBtn3.ButtonImage = null;
            prtBtn3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialEllipse;
            prtBtn3.ButtonText = "3";
            prtBtn3.ClickBackColor = Color.FromArgb(195, 200, 185);
            prtBtn3.ClickTextColor = Color.FromArgb(195, 200, 185);
            prtBtn3.CornerRadius = 5;
            prtBtn3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prtBtn3.Horizontal_Alignment = StringAlignment.Center;
            prtBtn3.HoverBackgroundColor = Color.FromArgb(195, 200, 185);
            prtBtn3.HoverTextColor = Color.FromArgb(65, 70, 75);
            prtBtn3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            prtBtn3.Location = new Point(697, 26);
            prtBtn3.Name = "prtBtn3";
            prtBtn3.Size = new Size(35, 32);
            prtBtn3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            prtBtn3.TabIndex = 0;
            prtBtn3.TextColor = Color.White;
            prtBtn3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            prtBtn3.Vertical_Alignment = StringAlignment.Center;
            // 
            // LINE2
            // 
            LINE2.BackColor = Color.FromArgb(149, 149, 149);
            LINE2.Location = new Point(540, 42);
            LINE2.Name = "LINE2";
            LINE2.Size = new Size(134, 1);
            LINE2.TabIndex = 0;
            // 
            // LINE3
            // 
            LINE3.BackColor = Color.FromArgb(149, 149, 149);
            LINE3.Location = new Point(756, 42);
            LINE3.Name = "LINE3";
            LINE3.Size = new Size(134, 1);
            LINE3.TabIndex = 0;
            // 
            // LINE4
            // 
            LINE4.BackColor = Color.FromArgb(149, 149, 149);
            LINE4.Location = new Point(968, 42);
            LINE4.Name = "LINE4";
            LINE4.Size = new Size(134, 1);
            LINE4.TabIndex = 0;
            // 
            // prtBtnsPanel
            // 
            prtBtnsPanel.Controls.Add(lblDone);
            prtBtnsPanel.Controls.Add(lblVerification);
            prtBtnsPanel.Controls.Add(lblConfirmation);
            prtBtnsPanel.Controls.Add(lblPasscode);
            prtBtnsPanel.Controls.Add(lblDetails);
            prtBtnsPanel.Controls.Add(LINE4);
            prtBtnsPanel.Controls.Add(prtBtn4);
            prtBtnsPanel.Controls.Add(LINE3);
            prtBtnsPanel.Controls.Add(LINE1);
            prtBtnsPanel.Controls.Add(LINE2);
            prtBtnsPanel.Controls.Add(prtBtn3);
            prtBtnsPanel.Controls.Add(prtBtn1);
            prtBtnsPanel.Controls.Add(prtBtn2);
            prtBtnsPanel.Controls.Add(prtBtn5);
            prtBtnsPanel.Location = new Point(-11, 258);
            prtBtnsPanel.Name = "prtBtnsPanel";
            prtBtnsPanel.Size = new Size(1439, 93);
            prtBtnsPanel.TabIndex = 0;
            prtBtnsPanel.Click += setFocusToOther;
            // 
            // lblDone
            // 
            lblDone.AutoSize = true;
            lblDone.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDone.ForeColor = Color.FromArgb(149, 149, 149);
            lblDone.Location = new Point(1114, 61);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(48, 24);
            lblDone.TabIndex = 5;
            lblDone.Text = "Done";
            // 
            // lblVerification
            // 
            lblVerification.AutoSize = true;
            lblVerification.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerification.ForeColor = Color.FromArgb(149, 149, 149);
            lblVerification.Location = new Point(880, 61);
            lblVerification.Name = "lblVerification";
            lblVerification.Size = new Size(93, 24);
            lblVerification.TabIndex = 4;
            lblVerification.Text = "Verification";
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmation.ForeColor = Color.FromArgb(149, 149, 149);
            lblConfirmation.Location = new Point(666, 61);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(103, 24);
            lblConfirmation.TabIndex = 3;
            lblConfirmation.Text = "Confirmation";
            // 
            // lblPasscode
            // 
            lblPasscode.AutoSize = true;
            lblPasscode.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasscode.ForeColor = Color.FromArgb(149, 149, 149);
            lblPasscode.Location = new Point(464, 61);
            lblPasscode.Name = "lblPasscode";
            lblPasscode.Size = new Size(79, 24);
            lblPasscode.TabIndex = 2;
            lblPasscode.Text = "Passcode";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Gothic A1", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetails.ForeColor = Color.FromArgb(7, 166, 234);
            lblDetails.Location = new Point(260, 61);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(61, 24);
            lblDetails.TabIndex = 1;
            lblDetails.Text = "Details";
            // 
            // gradientPanel
            // 
            gradientPanel.BottomLeft = Color.Transparent;
            gradientPanel.BottomRight = Color.Transparent;
            gradientPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gradientPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            gradientPanel.Location = new Point(-1, 352);
            gradientPanel.Name = "gradientPanel";
            gradientPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            gradientPanel.PrimerColor = Color.White;
            gradientPanel.Size = new Size(1424, 3);
            gradientPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            gradientPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            gradientPanel.TabIndex = 0;
            gradientPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            gradientPanel.TopLeft = Color.FromArgb(149, 149, 149);
            gradientPanel.TopRight = Color.White;
            // 
            // detailsPanel
            // 
            detailsPanel.AutoScroll = true;
            detailsPanel.AutoScrollMargin = new Size(0, 200);
            detailsPanel.Controls.Add(mobileNumberPrefix);
            detailsPanel.Controls.Add(passwordRequirementsPanel);
            detailsPanel.Controls.Add(label9);
            detailsPanel.Controls.Add(label8);
            detailsPanel.Controls.Add(label7);
            detailsPanel.Controls.Add(label6);
            detailsPanel.Controls.Add(label5);
            detailsPanel.Controls.Add(label3);
            detailsPanel.Controls.Add(label2);
            detailsPanel.Controls.Add(label1);
            detailsPanel.Controls.Add(txtBxUsername);
            detailsPanel.Controls.Add(txtBxPassword);
            detailsPanel.Controls.Add(button1);
            detailsPanel.Controls.Add(lblTermsAndService4);
            detailsPanel.Controls.Add(lblTermsAndService3);
            detailsPanel.Controls.Add(lblTermsAndService2);
            detailsPanel.Controls.Add(lblTermsAndService1);
            detailsPanel.Controls.Add(checkBxMetroTermsAndService);
            detailsPanel.Controls.Add(lblAccountAliasFillUp);
            detailsPanel.Controls.Add(txtBxAccountAlias);
            detailsPanel.Controls.Add(lblAccountNumberFillUp);
            detailsPanel.Controls.Add(txtBxAccountNumber);
            detailsPanel.Controls.Add(lblMobileNumberFillUp);
            detailsPanel.Controls.Add(txtBxMobileNumber);
            detailsPanel.Controls.Add(btnDeposit);
            detailsPanel.Controls.Add(btnSavings);
            detailsPanel.Controls.Add(lblEmailAddressFillUp);
            detailsPanel.Controls.Add(txtBxEmailAddress);
            detailsPanel.Controls.Add(lblLastNameFillUp);
            detailsPanel.Controls.Add(txtBxLastName);
            detailsPanel.Controls.Add(lblMiddleNameFillUp);
            detailsPanel.Controls.Add(txtBxMiddleName);
            detailsPanel.Controls.Add(lblFirstNameFillUp);
            detailsPanel.Controls.Add(txtBxFirstName);
            detailsPanel.Controls.Add(lblPasswordFillUp);
            detailsPanel.Controls.Add(lblUsernameFillUp);
            detailsPanel.Controls.Add(btnNext);
            detailsPanel.Location = new Point(0, -3);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(1421, 438);
            detailsPanel.TabIndex = 7;
            detailsPanel.Click += setFocusToOther;
            // 
            // mobileNumberPrefix
            // 
            mobileNumberPrefix.BackColor = Color.FromArgb(244, 244, 244);
            mobileNumberPrefix.FlatStyle = FlatStyle.Flat;
            mobileNumberPrefix.Font = new Font("Gothic A1 SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mobileNumberPrefix.ForeColor = Color.Black;
            mobileNumberPrefix.FormattingEnabled = true;
            mobileNumberPrefix.Items.AddRange(new object[] { "", "+63" });
            mobileNumberPrefix.Location = new Point(477, 538);
            mobileNumberPrefix.Name = "mobileNumberPrefix";
            mobileNumberPrefix.Size = new Size(63, 33);
            mobileNumberPrefix.TabIndex = 51;
            // 
            // passwordRequirementsPanel
            // 
            passwordRequirementsPanel.Controls.Add(lblDigitReq);
            passwordRequirementsPanel.Controls.Add(label13);
            passwordRequirementsPanel.Controls.Add(lblUppercaseReq);
            passwordRequirementsPanel.Controls.Add(lblNumberOfCharactersReq);
            passwordRequirementsPanel.Controls.Add(lblSpecialCharacterReq);
            passwordRequirementsPanel.Location = new Point(978, 80);
            passwordRequirementsPanel.Name = "passwordRequirementsPanel";
            passwordRequirementsPanel.Size = new Size(220, 165);
            passwordRequirementsPanel.TabIndex = 50;
            // 
            // lblDigitReq
            // 
            lblDigitReq.AutoSize = true;
            lblDigitReq.Font = new Font("Gothic A1", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDigitReq.ForeColor = Color.Firebrick;
            lblDigitReq.Location = new Point(3, 90);
            lblDigitReq.Name = "lblDigitReq";
            lblDigitReq.Size = new Size(75, 17);
            lblDigitReq.TabIndex = 46;
            lblDigitReq.Text = "One (1) Digit";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Gothic A1", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(3, 11);
            label13.Name = "label13";
            label13.Size = new Size(188, 21);
            label13.TabIndex = 49;
            label13.Text = "Password must have atleast;";
            // 
            // lblUppercaseReq
            // 
            lblUppercaseReq.AutoSize = true;
            lblUppercaseReq.Font = new Font("Gothic A1", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUppercaseReq.ForeColor = Color.Firebrick;
            lblUppercaseReq.Location = new Point(3, 63);
            lblUppercaseReq.Name = "lblUppercaseReq";
            lblUppercaseReq.Size = new Size(106, 17);
            lblUppercaseReq.TabIndex = 45;
            lblUppercaseReq.Text = "One (1) Uppercase";
            // 
            // lblNumberOfCharactersReq
            // 
            lblNumberOfCharactersReq.AutoSize = true;
            lblNumberOfCharactersReq.Font = new Font("Gothic A1", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberOfCharactersReq.ForeColor = Color.Firebrick;
            lblNumberOfCharactersReq.Location = new Point(3, 37);
            lblNumberOfCharactersReq.Name = "lblNumberOfCharactersReq";
            lblNumberOfCharactersReq.Size = new Size(126, 17);
            lblNumberOfCharactersReq.TabIndex = 48;
            lblNumberOfCharactersReq.Text = "12 characters in length";
            // 
            // lblSpecialCharacterReq
            // 
            lblSpecialCharacterReq.AutoSize = true;
            lblSpecialCharacterReq.Font = new Font("Gothic A1", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpecialCharacterReq.ForeColor = Color.Firebrick;
            lblSpecialCharacterReq.Location = new Point(3, 116);
            lblSpecialCharacterReq.Name = "lblSpecialCharacterReq";
            lblSpecialCharacterReq.Size = new Size(142, 17);
            lblSpecialCharacterReq.TabIndex = 47;
            lblSpecialCharacterReq.Text = "One (1) Special Character";
            // 
            // label9
            // 
            label9.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(475, 714);
            label9.Name = "label9";
            label9.Size = new Size(15, 25);
            label9.TabIndex = 43;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(474, 636);
            label8.Name = "label8";
            label8.Size = new Size(15, 25);
            label8.TabIndex = 42;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(474, 511);
            label7.Name = "label7";
            label7.Size = new Size(15, 25);
            label7.TabIndex = 41;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(473, 424);
            label6.Name = "label6";
            label6.Size = new Size(15, 25);
            label6.TabIndex = 40;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(473, 352);
            label5.Name = "label5";
            label5.Size = new Size(15, 25);
            label5.TabIndex = 39;
            label5.Text = "*";
            // 
            // label3
            // 
            label3.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(473, 201);
            label3.Name = "label3";
            label3.Size = new Size(15, 25);
            label3.TabIndex = 37;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(473, 120);
            label2.Name = "label2";
            label2.Size = new Size(15, 25);
            label2.TabIndex = 36;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(472, 38);
            label1.Name = "label1";
            label1.Size = new Size(15, 25);
            label1.TabIndex = 35;
            label1.Text = "*";
            // 
            // txtBxUsername
            // 
            txtBxUsername.BackColor = Color.FromArgb(244, 244, 244);
            txtBxUsername.BorderStyle = BorderStyle.None;
            txtBxUsername.Font = new Font("Gothic A1 SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxUsername.Location = new Point(476, 66);
            txtBxUsername.Multiline = true;
            txtBxUsername.Name = "txtBxUsername";
            txtBxUsername.Size = new Size(459, 36);
            txtBxUsername.TabIndex = 33;
            txtBxUsername.Enter += EnterText;
            txtBxUsername.Leave += IsBlankTextBox;
            // 
            // txtBxPassword
            // 
            txtBxPassword.BackColor = Color.FromArgb(244, 244, 244);
            txtBxPassword.BorderStyle = BorderStyle.None;
            txtBxPassword.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPassword.Location = new Point(476, 148);
            txtBxPassword.Multiline = true;
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(459, 36);
            txtBxPassword.TabIndex = 34;
            txtBxPassword.Enter += EnterText;
            txtBxPassword.KeyPress += txtBxPassword_KeyPress;
            txtBxPassword.Leave += IsBlankTextBox;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 26, 136);
            button1.Location = new Point(476, 908);
            button1.Name = "button1";
            button1.Size = new Size(453, 48);
            button1.TabIndex = 32;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblTermsAndService4
            // 
            lblTermsAndService4.AutoSize = true;
            lblTermsAndService4.Font = new Font("Gothic A1", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTermsAndService4.ForeColor = Color.FromArgb(0, 26, 136);
            lblTermsAndService4.Location = new Point(858, 790);
            lblTermsAndService4.Name = "lblTermsAndService4";
            lblTermsAndService4.Size = new Size(86, 19);
            lblTermsAndService4.TabIndex = 31;
            lblTermsAndService4.Text = "Terms of Use.";
            // 
            // lblTermsAndService3
            // 
            lblTermsAndService3.AutoSize = true;
            lblTermsAndService3.Font = new Font("Gothic A1", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTermsAndService3.Location = new Point(599, 790);
            lblTermsAndService3.Name = "lblTermsAndService3";
            lblTermsAndService3.Size = new Size(263, 19);
            lblTermsAndService3.TabIndex = 30;
            lblTermsAndService3.Text = "to collect and process my data, and agree to";
            // 
            // lblTermsAndService2
            // 
            lblTermsAndService2.AutoSize = true;
            lblTermsAndService2.Font = new Font("Gothic A1", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTermsAndService2.ForeColor = Color.FromArgb(0, 26, 136);
            lblTermsAndService2.Location = new Point(536, 790);
            lblTermsAndService2.Name = "lblTermsAndService2";
            lblTermsAndService2.Size = new Size(66, 19);
            lblTermsAndService2.TabIndex = 29;
            lblTermsAndService2.Text = "Trustbank";
            // 
            // lblTermsAndService1
            // 
            lblTermsAndService1.AutoSize = true;
            lblTermsAndService1.Font = new Font("Gothic A1", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTermsAndService1.Location = new Point(495, 790);
            lblTermsAndService1.Name = "lblTermsAndService1";
            lblTermsAndService1.Size = new Size(45, 19);
            lblTermsAndService1.TabIndex = 28;
            lblTermsAndService1.Text = "I allow";
            // 
            // checkBxMetroTermsAndService
            // 
            checkBxMetroTermsAndService.BackColor = Color.Transparent;
            checkBxMetroTermsAndService.BackgroundColor = Color.White;
            checkBxMetroTermsAndService.BorderColor = Color.FromArgb(155, 155, 155);
            checkBxMetroTermsAndService.Checked = false;
            checkBxMetroTermsAndService.CheckSignColor = Color.FromArgb(65, 177, 225);
            checkBxMetroTermsAndService.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            checkBxMetroTermsAndService.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            checkBxMetroTermsAndService.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBxMetroTermsAndService.IsDerivedStyle = true;
            checkBxMetroTermsAndService.Location = new Point(476, 793);
            checkBxMetroTermsAndService.Name = "checkBxMetroTermsAndService";
            checkBxMetroTermsAndService.SignStyle = ReaLTaiizor.Enum.Metro.SignStyle.Sign;
            checkBxMetroTermsAndService.Size = new Size(19, 16);
            checkBxMetroTermsAndService.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            checkBxMetroTermsAndService.StyleManager = null;
            checkBxMetroTermsAndService.TabIndex = 27;
            checkBxMetroTermsAndService.ThemeAuthor = "Taiizor";
            checkBxMetroTermsAndService.ThemeName = "MetroLight";
            // 
            // lblAccountAliasFillUp
            // 
            lblAccountAliasFillUp.AutoSize = true;
            lblAccountAliasFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountAliasFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblAccountAliasFillUp.Location = new Point(495, 714);
            lblAccountAliasFillUp.Name = "lblAccountAliasFillUp";
            lblAccountAliasFillUp.Size = new Size(115, 25);
            lblAccountAliasFillUp.TabIndex = 26;
            lblAccountAliasFillUp.Text = "Account Alias";
            // 
            // txtBxAccountAlias
            // 
            txtBxAccountAlias.BackColor = Color.FromArgb(244, 244, 244);
            txtBxAccountAlias.BorderStyle = BorderStyle.None;
            txtBxAccountAlias.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxAccountAlias.Location = new Point(476, 742);
            txtBxAccountAlias.Multiline = true;
            txtBxAccountAlias.Name = "txtBxAccountAlias";
            txtBxAccountAlias.Size = new Size(459, 36);
            txtBxAccountAlias.TabIndex = 25;
            txtBxAccountAlias.Enter += EnterText;
            txtBxAccountAlias.Leave += IsBlankTextBox;
            // 
            // lblAccountNumberFillUp
            // 
            lblAccountNumberFillUp.AutoSize = true;
            lblAccountNumberFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountNumberFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblAccountNumberFillUp.Location = new Point(494, 636);
            lblAccountNumberFillUp.Name = "lblAccountNumberFillUp";
            lblAccountNumberFillUp.Size = new Size(138, 25);
            lblAccountNumberFillUp.TabIndex = 24;
            lblAccountNumberFillUp.Text = "Account Number";
            // 
            // txtBxAccountNumber
            // 
            txtBxAccountNumber.BackColor = Color.FromArgb(244, 244, 244);
            txtBxAccountNumber.BorderStyle = BorderStyle.None;
            txtBxAccountNumber.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxAccountNumber.Location = new Point(475, 664);
            txtBxAccountNumber.Multiline = true;
            txtBxAccountNumber.Name = "txtBxAccountNumber";
            txtBxAccountNumber.Size = new Size(459, 36);
            txtBxAccountNumber.TabIndex = 23;
            txtBxAccountNumber.Enter += EnterText;
            txtBxAccountNumber.Leave += IsBlankTextBox;
            // 
            // lblMobileNumberFillUp
            // 
            lblMobileNumberFillUp.AutoSize = true;
            lblMobileNumberFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMobileNumberFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblMobileNumberFillUp.Location = new Point(495, 510);
            lblMobileNumberFillUp.Name = "lblMobileNumberFillUp";
            lblMobileNumberFillUp.Size = new Size(127, 25);
            lblMobileNumberFillUp.TabIndex = 22;
            lblMobileNumberFillUp.Text = "Mobile Number";
            // 
            // txtBxMobileNumber
            // 
            txtBxMobileNumber.BackColor = Color.FromArgb(244, 244, 244);
            txtBxMobileNumber.BorderStyle = BorderStyle.None;
            txtBxMobileNumber.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxMobileNumber.Location = new Point(556, 538);
            txtBxMobileNumber.Multiline = true;
            txtBxMobileNumber.Name = "txtBxMobileNumber";
            txtBxMobileNumber.Size = new Size(379, 36);
            txtBxMobileNumber.TabIndex = 21;
            txtBxMobileNumber.Enter += EnterText;
            txtBxMobileNumber.Leave += IsBlankTextBox;
            // 
            // btnDeposit
            // 
            btnDeposit.FlatAppearance.BorderColor = Color.FromArgb(0, 26, 136);
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeposit.ForeColor = Color.FromArgb(0, 26, 136);
            btnDeposit.Location = new Point(704, 584);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(230, 39);
            btnDeposit.TabIndex = 20;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnSavings
            // 
            btnSavings.BackColor = Color.FromArgb(0, 26, 136);
            btnSavings.FlatAppearance.BorderColor = Color.FromArgb(0, 26, 136);
            btnSavings.FlatStyle = FlatStyle.Flat;
            btnSavings.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavings.ForeColor = Color.White;
            btnSavings.Location = new Point(475, 584);
            btnSavings.Name = "btnSavings";
            btnSavings.Size = new Size(232, 39);
            btnSavings.TabIndex = 18;
            btnSavings.Text = "Savings";
            btnSavings.UseVisualStyleBackColor = false;
            btnSavings.Click += btnSavings_Click;
            // 
            // lblEmailAddressFillUp
            // 
            lblEmailAddressFillUp.AutoSize = true;
            lblEmailAddressFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailAddressFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblEmailAddressFillUp.Location = new Point(495, 424);
            lblEmailAddressFillUp.Name = "lblEmailAddressFillUp";
            lblEmailAddressFillUp.Size = new Size(120, 25);
            lblEmailAddressFillUp.TabIndex = 17;
            lblEmailAddressFillUp.Text = "Email Address";
            // 
            // txtBxEmailAddress
            // 
            txtBxEmailAddress.BackColor = Color.FromArgb(244, 244, 244);
            txtBxEmailAddress.BorderStyle = BorderStyle.None;
            txtBxEmailAddress.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxEmailAddress.Location = new Point(476, 452);
            txtBxEmailAddress.Multiline = true;
            txtBxEmailAddress.Name = "txtBxEmailAddress";
            txtBxEmailAddress.Size = new Size(459, 36);
            txtBxEmailAddress.TabIndex = 16;
            txtBxEmailAddress.Enter += EnterText;
            txtBxEmailAddress.Leave += IsBlankTextBox;
            // 
            // lblLastNameFillUp
            // 
            lblLastNameFillUp.AutoSize = true;
            lblLastNameFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastNameFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblLastNameFillUp.Location = new Point(492, 352);
            lblLastNameFillUp.Name = "lblLastNameFillUp";
            lblLastNameFillUp.Size = new Size(92, 25);
            lblLastNameFillUp.TabIndex = 15;
            lblLastNameFillUp.Text = "Last Name";
            // 
            // txtBxLastName
            // 
            txtBxLastName.BackColor = Color.FromArgb(244, 244, 244);
            txtBxLastName.BorderStyle = BorderStyle.None;
            txtBxLastName.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxLastName.Location = new Point(476, 380);
            txtBxLastName.Multiline = true;
            txtBxLastName.Name = "txtBxLastName";
            txtBxLastName.Size = new Size(459, 36);
            txtBxLastName.TabIndex = 14;
            txtBxLastName.Enter += EnterText;
            txtBxLastName.Leave += IsBlankTextBox;
            // 
            // lblMiddleNameFillUp
            // 
            lblMiddleNameFillUp.AutoSize = true;
            lblMiddleNameFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleNameFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblMiddleNameFillUp.Location = new Point(472, 280);
            lblMiddleNameFillUp.Name = "lblMiddleNameFillUp";
            lblMiddleNameFillUp.Size = new Size(112, 25);
            lblMiddleNameFillUp.TabIndex = 13;
            lblMiddleNameFillUp.Text = "Middle Name";
            // 
            // txtBxMiddleName
            // 
            txtBxMiddleName.BackColor = Color.FromArgb(244, 244, 244);
            txtBxMiddleName.BorderStyle = BorderStyle.None;
            txtBxMiddleName.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxMiddleName.Location = new Point(475, 308);
            txtBxMiddleName.Multiline = true;
            txtBxMiddleName.Name = "txtBxMiddleName";
            txtBxMiddleName.Size = new Size(459, 36);
            txtBxMiddleName.TabIndex = 12;
            // 
            // lblFirstNameFillUp
            // 
            lblFirstNameFillUp.AutoSize = true;
            lblFirstNameFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstNameFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblFirstNameFillUp.Location = new Point(491, 201);
            lblFirstNameFillUp.Name = "lblFirstNameFillUp";
            lblFirstNameFillUp.Size = new Size(94, 25);
            lblFirstNameFillUp.TabIndex = 11;
            lblFirstNameFillUp.Text = "First Name";
            // 
            // txtBxFirstName
            // 
            txtBxFirstName.BackColor = Color.FromArgb(244, 244, 244);
            txtBxFirstName.BorderStyle = BorderStyle.None;
            txtBxFirstName.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxFirstName.Location = new Point(476, 229);
            txtBxFirstName.Multiline = true;
            txtBxFirstName.Name = "txtBxFirstName";
            txtBxFirstName.Size = new Size(459, 36);
            txtBxFirstName.TabIndex = 10;
            txtBxFirstName.Enter += EnterText;
            txtBxFirstName.Leave += IsBlankTextBox;
            // 
            // lblPasswordFillUp
            // 
            lblPasswordFillUp.AutoSize = true;
            lblPasswordFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblPasswordFillUp.Location = new Point(491, 119);
            lblPasswordFillUp.Name = "lblPasswordFillUp";
            lblPasswordFillUp.Size = new Size(84, 25);
            lblPasswordFillUp.TabIndex = 9;
            lblPasswordFillUp.Text = "Password";
            // 
            // lblUsernameFillUp
            // 
            lblUsernameFillUp.AutoSize = true;
            lblUsernameFillUp.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsernameFillUp.ForeColor = Color.FromArgb(149, 149, 149);
            lblUsernameFillUp.Location = new Point(491, 38);
            lblUsernameFillUp.Name = "lblUsernameFillUp";
            lblUsernameFillUp.Size = new Size(88, 25);
            lblUsernameFillUp.TabIndex = 7;
            lblUsernameFillUp.Text = "Username";
            // 
            // parentRegistrationPanel
            // 
            parentRegistrationPanel.Controls.Add(detailsPanel);
            parentRegistrationPanel.Location = new Point(-1, 355);
            parentRegistrationPanel.Name = "parentRegistrationPanel";
            parentRegistrationPanel.Size = new Size(1424, 438);
            parentRegistrationPanel.TabIndex = 8;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1420, 790);
            Controls.Add(gradientPanel);
            Controls.Add(HEADERLBLONLY);
            Controls.Add(TRUSTBANKLOGO);
            Controls.Add(TRUSTBANKLBLONLY);
            Controls.Add(signUpHeaderImage);
            Controls.Add(prtBtnsPanel);
            Controls.Add(parentRegistrationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)TRUSTBANKLOGO).EndInit();
            ((System.ComponentModel.ISupportInitialize)signUpHeaderImage).EndInit();
            prtBtnsPanel.ResumeLayout(false);
            prtBtnsPanel.PerformLayout();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            passwordRequirementsPanel.ResumeLayout(false);
            passwordRequirementsPanel.PerformLayout();
            parentRegistrationPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TRUSTBANKLBLONLY;
        private PictureBox TRUSTBANKLOGO;
        private Label HEADERLBLONLY;
        private PictureBox signUpHeaderImage;
        private Button btnNext;
        private Panel LINE1;
        private ReaLTaiizor.Controls.ParrotButton prtBtn1;
        private ReaLTaiizor.Controls.ParrotButton prtBtn5;
        private ReaLTaiizor.Controls.ParrotButton prtBtn2;
        private ReaLTaiizor.Controls.ParrotButton prtBtn4;
        private ReaLTaiizor.Controls.ParrotButton prtBtn3;
        private Panel LINE2;
        private Panel LINE3;
        private Panel LINE4;
        private Panel prtBtnsPanel;
        private ReaLTaiizor.Controls.ParrotGradientPanel gradientPanel;
        private Panel detailsPanel;
        private Label lblDone;
        private Label lblVerification;
        private Label lblConfirmation;
        private Label lblPasscode;
        private Label lblDetails;
        private Label lblUsernameFillUp;
        private Label lblPasswordFillUp;
        private Panel parentRegistrationPanel;
        private Label lblEmailAddressFillUp;
        private TextBox txtBxEmailAddress;
        private Label lblLastNameFillUp;
        private TextBox txtBxLastName;
        private Label lblMiddleNameFillUp;
        private TextBox txtBxMiddleName;
        private Label lblFirstNameFillUp;
        private TextBox txtBxFirstName;
        private Button btnDeposit;
        private Button btnSavings;
        private Label lblMobileNumberFillUp;
        private TextBox txtBxMobileNumber;
        private Label lblAccountAliasFillUp;
        private TextBox txtBxAccountAlias;
        private Label lblAccountNumberFillUp;
        private TextBox txtBxAccountNumber;
        private ReaLTaiizor.Controls.MetroCheckBox checkBxMetroTermsAndService;
        private Label lblTermsAndService1;
        private Label lblTermsAndService4;
        private Label lblTermsAndService3;
        private Label lblTermsAndService2;
        private Button button1;
        private TextBox txtBxPassword;
        private TextBox txtBxUsername;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblDigitReq;
        private Label lblUppercaseReq;
        private Panel passwordRequirementsPanel;
        private Label label13;
        private Label lblNumberOfCharactersReq;
        private Label lblSpecialCharacterReq;
        private ComboBox mobileNumberPrefix;
    }
}