namespace Trustbank
{
    partial class AccountsMainUserControl
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
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblBalancePlaceholder = new Label();
            label4 = new Label();
            label1 = new Label();
            lblAccountNumberPlaceholder = new Label();
            lblNamePlaceholder = new Label();
            lblTypeOfAccountPlaceholder = new Label();
            panel2 = new Panel();
            tableAccountStatus = new TableLayoutPanel();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblAccTypeAccountInfo = new Label();
            lblAccNumberAccountInfo = new Label();
            lblAccUsernameAccountInfo = new Label();
            lblAccPasswordAccountInfo = new Label();
            tableUserStatus = new TableLayoutPanel();
            lblStatusAccountInfo = new Label();
            lblMobileNumberAccountInfo = new Label();
            lblEmailAccountInfo = new Label();
            lblNameAccountInfo = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            btnUpdateInformation = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableAccountStatus.SuspendLayout();
            tableUserStatus.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 244, 244);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(lblBalancePlaceholder);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAccountNumberPlaceholder);
            panel1.Controls.Add(lblNamePlaceholder);
            panel1.Controls.Add(lblTypeOfAccountPlaceholder);
            panel1.Location = new Point(47, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1315, 201);
            panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Gothic A1 ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.FromArgb(0, 26, 136);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(1168, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(133, 38);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Scan QR Code";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblBalancePlaceholder
            // 
            lblBalancePlaceholder.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalancePlaceholder.ForeColor = Color.Black;
            lblBalancePlaceholder.Location = new Point(963, 119);
            lblBalancePlaceholder.Name = "lblBalancePlaceholder";
            lblBalancePlaceholder.Size = new Size(332, 55);
            lblBalancePlaceholder.TabIndex = 0;
            lblBalancePlaceholder.Text = "100, 000.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gothic A1", 33F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(894, 119);
            label4.Name = "label4";
            label4.Size = new Size(62, 69);
            label4.TabIndex = 0;
            label4.Text = "₱";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(149, 149, 149);
            label1.Location = new Point(894, 89);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 0;
            label1.Text = "Balance:";
            // 
            // lblAccountNumberPlaceholder
            // 
            lblAccountNumberPlaceholder.AutoSize = true;
            lblAccountNumberPlaceholder.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountNumberPlaceholder.ForeColor = Color.FromArgb(149, 149, 149);
            lblAccountNumberPlaceholder.Location = new Point(22, 127);
            lblAccountNumberPlaceholder.Name = "lblAccountNumberPlaceholder";
            lblAccountNumberPlaceholder.Size = new Size(153, 38);
            lblAccountNumberPlaceholder.TabIndex = 0;
            lblAccountNumberPlaceholder.Text = "placeholder";
            // 
            // lblNamePlaceholder
            // 
            lblNamePlaceholder.AutoSize = true;
            lblNamePlaceholder.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNamePlaceholder.ForeColor = Color.FromArgb(149, 149, 149);
            lblNamePlaceholder.Location = new Point(22, 74);
            lblNamePlaceholder.Name = "lblNamePlaceholder";
            lblNamePlaceholder.Size = new Size(119, 30);
            lblNamePlaceholder.TabIndex = 0;
            lblNamePlaceholder.Text = "placeholder";
            // 
            // lblTypeOfAccountPlaceholder
            // 
            lblTypeOfAccountPlaceholder.AutoSize = true;
            lblTypeOfAccountPlaceholder.Font = new Font("Gothic A1", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypeOfAccountPlaceholder.ForeColor = Color.FromArgb(0, 26, 136);
            lblTypeOfAccountPlaceholder.Location = new Point(22, 16);
            lblTypeOfAccountPlaceholder.Name = "lblTypeOfAccountPlaceholder";
            lblTypeOfAccountPlaceholder.Size = new Size(184, 46);
            lblTypeOfAccountPlaceholder.TabIndex = 0;
            lblTypeOfAccountPlaceholder.Text = "placeholder";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 244, 244);
            panel2.Controls.Add(tableAccountStatus);
            panel2.Controls.Add(tableUserStatus);
            panel2.Location = new Point(47, 267);
            panel2.Name = "panel2";
            panel2.Size = new Size(1315, 265);
            panel2.TabIndex = 1;
            // 
            // tableAccountStatus
            // 
            tableAccountStatus.ColumnCount = 2;
            tableAccountStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6979866F));
            tableAccountStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.30202F));
            tableAccountStatus.Controls.Add(label13, 0, 3);
            tableAccountStatus.Controls.Add(label10, 0, 0);
            tableAccountStatus.Controls.Add(label11, 0, 1);
            tableAccountStatus.Controls.Add(label12, 0, 2);
            tableAccountStatus.Controls.Add(lblAccTypeAccountInfo, 1, 0);
            tableAccountStatus.Controls.Add(lblAccNumberAccountInfo, 1, 1);
            tableAccountStatus.Controls.Add(lblAccUsernameAccountInfo, 1, 2);
            tableAccountStatus.Controls.Add(lblAccPasswordAccountInfo, 1, 3);
            tableAccountStatus.Location = new Point(685, 66);
            tableAccountStatus.Name = "tableAccountStatus";
            tableAccountStatus.RowCount = 4;
            tableAccountStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableAccountStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableAccountStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableAccountStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableAccountStatus.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableAccountStatus.Size = new Size(596, 182);
            tableAccountStatus.TabIndex = 1;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 146);
            label13.Name = "label13";
            label13.Size = new Size(156, 25);
            label13.TabIndex = 4;
            label13.Text = "Account Password:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 10);
            label10.Name = "label10";
            label10.Size = new Size(121, 25);
            label10.TabIndex = 1;
            label10.Text = "Account Type:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 55);
            label11.Name = "label11";
            label11.Size = new Size(144, 25);
            label11.TabIndex = 2;
            label11.Text = "Account Number:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 100);
            label12.Name = "label12";
            label12.Size = new Size(160, 25);
            label12.TabIndex = 3;
            label12.Text = "Account Username:";
            // 
            // lblAccTypeAccountInfo
            // 
            lblAccTypeAccountInfo.Anchor = AnchorStyles.Right;
            lblAccTypeAccountInfo.AutoSize = true;
            lblAccTypeAccountInfo.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccTypeAccountInfo.Location = new Point(389, 6);
            lblAccTypeAccountInfo.Name = "lblAccTypeAccountInfo";
            lblAccTypeAccountInfo.Size = new Size(204, 33);
            lblAccTypeAccountInfo.TabIndex = 5;
            lblAccTypeAccountInfo.Text = "SAVINGS/DEPOSIT";
            // 
            // lblAccNumberAccountInfo
            // 
            lblAccNumberAccountInfo.Anchor = AnchorStyles.Right;
            lblAccNumberAccountInfo.AutoSize = true;
            lblAccNumberAccountInfo.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccNumberAccountInfo.Location = new Point(389, 51);
            lblAccNumberAccountInfo.Name = "lblAccNumberAccountInfo";
            lblAccNumberAccountInfo.Size = new Size(204, 33);
            lblAccNumberAccountInfo.TabIndex = 6;
            lblAccNumberAccountInfo.Text = "SAVINGS/DEPOSIT";
            // 
            // lblAccUsernameAccountInfo
            // 
            lblAccUsernameAccountInfo.Anchor = AnchorStyles.Right;
            lblAccUsernameAccountInfo.AutoSize = true;
            lblAccUsernameAccountInfo.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccUsernameAccountInfo.Location = new Point(389, 96);
            lblAccUsernameAccountInfo.Name = "lblAccUsernameAccountInfo";
            lblAccUsernameAccountInfo.Size = new Size(204, 33);
            lblAccUsernameAccountInfo.TabIndex = 7;
            lblAccUsernameAccountInfo.Text = "SAVINGS/DEPOSIT";
            // 
            // lblAccPasswordAccountInfo
            // 
            lblAccPasswordAccountInfo.Anchor = AnchorStyles.Right;
            lblAccPasswordAccountInfo.AutoSize = true;
            lblAccPasswordAccountInfo.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccPasswordAccountInfo.Location = new Point(389, 142);
            lblAccPasswordAccountInfo.Name = "lblAccPasswordAccountInfo";
            lblAccPasswordAccountInfo.Size = new Size(204, 33);
            lblAccPasswordAccountInfo.TabIndex = 8;
            lblAccPasswordAccountInfo.Text = "SAVINGS/DEPOSIT";
            // 
            // tableUserStatus
            // 
            tableUserStatus.ColumnCount = 2;
            tableUserStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3097343F));
            tableUserStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.69026F));
            tableUserStatus.Controls.Add(lblStatusAccountInfo, 1, 3);
            tableUserStatus.Controls.Add(lblMobileNumberAccountInfo, 1, 2);
            tableUserStatus.Controls.Add(lblEmailAccountInfo, 1, 1);
            tableUserStatus.Controls.Add(lblNameAccountInfo, 1, 0);
            tableUserStatus.Controls.Add(label6, 0, 0);
            tableUserStatus.Controls.Add(label7, 0, 1);
            tableUserStatus.Controls.Add(label8, 0, 2);
            tableUserStatus.Controls.Add(label9, 0, 3);
            tableUserStatus.Location = new Point(13, 66);
            tableUserStatus.Name = "tableUserStatus";
            tableUserStatus.RowCount = 4;
            tableUserStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableUserStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableUserStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableUserStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableUserStatus.Size = new Size(635, 182);
            tableUserStatus.TabIndex = 0;
            // 
            // lblStatusAccountInfo
            // 
            lblStatusAccountInfo.Anchor = AnchorStyles.Right;
            lblStatusAccountInfo.AutoSize = true;
            lblStatusAccountInfo.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusAccountInfo.Location = new Point(554, 142);
            lblStatusAccountInfo.Name = "lblStatusAccountInfo";
            lblStatusAccountInfo.Size = new Size(78, 33);
            lblStatusAccountInfo.TabIndex = 7;
            lblStatusAccountInfo.Text = "Active";
            // 
            // lblMobileNumberAccountInfo
            // 
            lblMobileNumberAccountInfo.Anchor = AnchorStyles.Right;
            lblMobileNumberAccountInfo.AutoSize = true;
            lblMobileNumberAccountInfo.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMobileNumberAccountInfo.Location = new Point(536, 96);
            lblMobileNumberAccountInfo.Name = "lblMobileNumberAccountInfo";
            lblMobileNumberAccountInfo.Size = new Size(96, 33);
            lblMobileNumberAccountInfo.TabIndex = 6;
            lblMobileNumberAccountInfo.Text = "MOBILE";
            // 
            // lblEmailAccountInfo
            // 
            lblEmailAccountInfo.Anchor = AnchorStyles.Right;
            lblEmailAccountInfo.AutoSize = true;
            lblEmailAccountInfo.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailAccountInfo.Location = new Point(552, 51);
            lblEmailAccountInfo.Name = "lblEmailAccountInfo";
            lblEmailAccountInfo.Size = new Size(80, 33);
            lblEmailAccountInfo.TabIndex = 5;
            lblEmailAccountInfo.Text = "EMAIL";
            // 
            // lblNameAccountInfo
            // 
            lblNameAccountInfo.Anchor = AnchorStyles.Right;
            lblNameAccountInfo.AutoSize = true;
            lblNameAccountInfo.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameAccountInfo.Location = new Point(554, 6);
            lblNameAccountInfo.Name = "lblNameAccountInfo";
            lblNameAccountInfo.Size = new Size(78, 33);
            lblNameAccountInfo.TabIndex = 4;
            lblNameAccountInfo.Text = "NAME";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 0;
            label6.Text = "Name:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 55);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 1;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 100);
            label8.Name = "label8";
            label8.Size = new Size(133, 25);
            label8.TabIndex = 2;
            label8.Text = "Mobile Number:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 146);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 3;
            label9.Text = "Status:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 26, 136);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(47, 267);
            panel3.Name = "panel3";
            panel3.Size = new Size(1315, 60);
            panel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 11);
            label5.Name = "label5";
            label5.Size = new Size(249, 38);
            label5.TabIndex = 2;
            label5.Text = "Account Information";
            // 
            // btnUpdateInformation
            // 
            btnUpdateInformation.BackColor = Color.FromArgb(0, 26, 136);
            btnUpdateInformation.FlatAppearance.BorderSize = 0;
            btnUpdateInformation.FlatStyle = FlatStyle.Flat;
            btnUpdateInformation.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInformation.ForeColor = Color.White;
            btnUpdateInformation.Location = new Point(1010, 551);
            btnUpdateInformation.Name = "btnUpdateInformation";
            btnUpdateInformation.Size = new Size(352, 45);
            btnUpdateInformation.TabIndex = 2;
            btnUpdateInformation.Text = "Update Information";
            btnUpdateInformation.UseVisualStyleBackColor = false;
            // 
            // AccountsMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnUpdateInformation);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AccountsMainUserControl";
            Size = new Size(1405, 616);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableAccountStatus.ResumeLayout(false);
            tableAccountStatus.PerformLayout();
            tableUserStatus.ResumeLayout(false);
            tableUserStatus.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTypeOfAccountPlaceholder;
        private Label lblNamePlaceholder;
        private Label lblAccountNumberPlaceholder;
        private Label label1;
        private Label label4;
        private Label lblBalancePlaceholder;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private TableLayoutPanel tableUserStatus;
        private Label label6;
        private Label lblNameAccountInfo;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblStatusAccountInfo;
        private Label lblMobileNumberAccountInfo;
        private Label lblEmailAccountInfo;
        private TableLayoutPanel tableAccountStatus;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblAccTypeAccountInfo;
        private Label lblAccNumberAccountInfo;
        private Label lblAccUsernameAccountInfo;
        private Label lblAccPasswordAccountInfo;
        private Button btnUpdateInformation;
    }
}
