namespace Trustbank
{
    partial class DetailsUserControl
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
            btnNext = new Button();
            detailsPanel.SuspendLayout();
            passwordRequirementsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // detailsPanel
            // 
            detailsPanel.AutoScroll = true;
            detailsPanel.AutoScrollMargin = new Size(0, 100);
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
            detailsPanel.Location = new Point(0, 0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(1421, 438);
            detailsPanel.TabIndex = 8;
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
            txtBxUsername.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtBxPassword.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxPassword.Location = new Point(476, 148);
            txtBxPassword.Multiline = true;
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(459, 36);
            txtBxPassword.TabIndex = 34;
            txtBxPassword.Enter += EnterText;
            txtBxPassword.KeyDown += txtBxPassword_KeyDown;
            txtBxPassword.KeyUp += txtBxPassword_KeyUp;
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
            txtBxAccountAlias.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtBxAccountNumber.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtBxMobileNumber.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtBxEmailAddress.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtBxLastName.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtBxMiddleName.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtBxFirstName.Font = new Font("Gothic A1", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            // DetailsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(detailsPanel);
            Name = "DetailsUserControl";
            Size = new Size(1421, 438);
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            passwordRequirementsPanel.ResumeLayout(false);
            passwordRequirementsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel detailsPanel;
        private ComboBox mobileNumberPrefix;
        private Panel passwordRequirementsPanel;
        private Label lblDigitReq;
        private Label label13;
        private Label lblUppercaseReq;
        private Label lblNumberOfCharactersReq;
        private Label lblSpecialCharacterReq;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBxUsername;
        private TextBox txtBxPassword;
        private Button button1;
        private Label lblTermsAndService4;
        private Label lblTermsAndService3;
        private Label lblTermsAndService2;
        private Label lblTermsAndService1;
        private ReaLTaiizor.Controls.MetroCheckBox checkBxMetroTermsAndService;
        private Label lblAccountAliasFillUp;
        private TextBox txtBxAccountAlias;
        private Label lblAccountNumberFillUp;
        private TextBox txtBxAccountNumber;
        private Label lblMobileNumberFillUp;
        private TextBox txtBxMobileNumber;
        private Button btnDeposit;
        private Button btnSavings;
        private Label lblEmailAddressFillUp;
        private TextBox txtBxEmailAddress;
        private Label lblLastNameFillUp;
        private TextBox txtBxLastName;
        private Label lblMiddleNameFillUp;
        private TextBox txtBxMiddleName;
        private Label lblFirstNameFillUp;
        private TextBox txtBxFirstName;
        private Label lblPasswordFillUp;
        private Label lblUsernameFillUp;
        private Button btnNext;
    }
}
