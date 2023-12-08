namespace Trustbank
{
    partial class PasscodeUserControl
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
            LBLSECUREONLY = new Label();
            txtBxPasscode1 = new TextBox();
            txtBxPasscode2 = new TextBox();
            txtBxPasscode3 = new TextBox();
            passcodePanel = new Panel();
            btnCancel = new Button();
            btnNext = new Button();
            btnShowPasscode = new Button();
            LBLNEVERONLY = new Label();
            passcodeTextboxesPanel = new TableLayoutPanel();
            txtBxPasscode5 = new TextBox();
            txtBxPasscode4 = new TextBox();
            txtBxPasscode6 = new TextBox();
            passcodePanel.SuspendLayout();
            passcodeTextboxesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LBLSECUREONLY
            // 
            LBLSECUREONLY.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLSECUREONLY.Location = new Point(348, 86);
            LBLSECUREONLY.Name = "LBLSECUREONLY";
            LBLSECUREONLY.Size = new Size(751, 40);
            LBLSECUREONLY.TabIndex = 0;
            LBLSECUREONLY.Text = "To further secure your account, create a passcode  to authorize transactions.";
            // 
            // txtBxPasscode1
            // 
            txtBxPasscode1.Anchor = AnchorStyles.None;
            txtBxPasscode1.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode1.BorderStyle = BorderStyle.None;
            txtBxPasscode1.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode1.Location = new Point(33, 18);
            txtBxPasscode1.MaxLength = 1;
            txtBxPasscode1.Multiline = true;
            txtBxPasscode1.Name = "txtBxPasscode1";
            txtBxPasscode1.Size = new Size(72, 64);
            txtBxPasscode1.TabIndex = 1;
            txtBxPasscode1.TextAlign = HorizontalAlignment.Center;
            txtBxPasscode1.KeyDown += btnNextIsValid;
            txtBxPasscode1.KeyUp += btnNextIsValid;
            // 
            // txtBxPasscode2
            // 
            txtBxPasscode2.Anchor = AnchorStyles.None;
            txtBxPasscode2.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode2.BorderStyle = BorderStyle.None;
            txtBxPasscode2.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode2.Location = new Point(172, 18);
            txtBxPasscode2.MaxLength = 1;
            txtBxPasscode2.Multiline = true;
            txtBxPasscode2.Name = "txtBxPasscode2";
            txtBxPasscode2.Size = new Size(72, 64);
            txtBxPasscode2.TabIndex = 2;
            txtBxPasscode2.TextAlign = HorizontalAlignment.Center;
            txtBxPasscode2.KeyDown += btnNextIsValid;
            txtBxPasscode2.KeyUp += btnNextIsValid;
            // 
            // txtBxPasscode3
            // 
            txtBxPasscode3.Anchor = AnchorStyles.None;
            txtBxPasscode3.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode3.BorderStyle = BorderStyle.None;
            txtBxPasscode3.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode3.Location = new Point(311, 18);
            txtBxPasscode3.MaxLength = 1;
            txtBxPasscode3.Multiline = true;
            txtBxPasscode3.Name = "txtBxPasscode3";
            txtBxPasscode3.Size = new Size(72, 64);
            txtBxPasscode3.TabIndex = 3;
            txtBxPasscode3.TextAlign = HorizontalAlignment.Center;
            txtBxPasscode3.KeyDown += btnNextIsValid;
            txtBxPasscode3.KeyUp += btnNextIsValid;
            // 
            // passcodePanel
            // 
            passcodePanel.Controls.Add(btnCancel);
            passcodePanel.Controls.Add(btnNext);
            passcodePanel.Controls.Add(btnShowPasscode);
            passcodePanel.Controls.Add(LBLNEVERONLY);
            passcodePanel.Controls.Add(passcodeTextboxesPanel);
            passcodePanel.Controls.Add(LBLSECUREONLY);
            passcodePanel.Location = new Point(0, 0);
            passcodePanel.Name = "passcodePanel";
            passcodePanel.Size = new Size(1421, 438);
            passcodePanel.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(217, 217, 217);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(0, 26, 136);
            btnCancel.Location = new Point(375, 335);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(288, 55);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Back";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 26, 136);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(746, 335);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(288, 55);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnShowPasscode
            // 
            btnShowPasscode.FlatAppearance.BorderSize = 0;
            btnShowPasscode.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnShowPasscode.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShowPasscode.FlatStyle = FlatStyle.Flat;
            btnShowPasscode.Font = new Font("Gothic A1 SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowPasscode.ForeColor = Color.FromArgb(149, 149, 149);
            btnShowPasscode.Location = new Point(1140, 169);
            btnShowPasscode.Name = "btnShowPasscode";
            btnShowPasscode.Size = new Size(94, 49);
            btnShowPasscode.TabIndex = 0;
            btnShowPasscode.Text = "Show";
            btnShowPasscode.UseVisualStyleBackColor = true;
            btnShowPasscode.Click += btnShowPasscode_Click;
            // 
            // LBLNEVERONLY
            // 
            LBLNEVERONLY.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLNEVERONLY.Location = new Point(523, 258);
            LBLNEVERONLY.Name = "LBLNEVERONLY";
            LBLNEVERONLY.Size = new Size(345, 41);
            LBLNEVERONLY.TabIndex = 0;
            LBLNEVERONLY.Text = "Never give your passcode to anyone.";
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
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode1, 0, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode2, 1, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode5, 4, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode3, 2, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode4, 3, 0);
            passcodeTextboxesPanel.Controls.Add(txtBxPasscode6, 5, 0);
            passcodeTextboxesPanel.Location = new Point(280, 141);
            passcodeTextboxesPanel.Name = "passcodeTextboxesPanel";
            passcodeTextboxesPanel.RowCount = 1;
            passcodeTextboxesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            passcodeTextboxesPanel.Size = new Size(839, 100);
            passcodeTextboxesPanel.TabIndex = 7;
            // 
            // txtBxPasscode5
            // 
            txtBxPasscode5.Anchor = AnchorStyles.None;
            txtBxPasscode5.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode5.BorderStyle = BorderStyle.None;
            txtBxPasscode5.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode5.Location = new Point(589, 18);
            txtBxPasscode5.MaxLength = 1;
            txtBxPasscode5.Multiline = true;
            txtBxPasscode5.Name = "txtBxPasscode5";
            txtBxPasscode5.Size = new Size(72, 64);
            txtBxPasscode5.TabIndex = 5;
            txtBxPasscode5.TextAlign = HorizontalAlignment.Center;
            txtBxPasscode5.KeyDown += btnNextIsValid;
            txtBxPasscode5.KeyUp += btnNextIsValid;
            // 
            // txtBxPasscode4
            // 
            txtBxPasscode4.Anchor = AnchorStyles.None;
            txtBxPasscode4.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode4.BorderStyle = BorderStyle.None;
            txtBxPasscode4.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode4.Location = new Point(450, 18);
            txtBxPasscode4.MaxLength = 1;
            txtBxPasscode4.Multiline = true;
            txtBxPasscode4.Name = "txtBxPasscode4";
            txtBxPasscode4.Size = new Size(72, 64);
            txtBxPasscode4.TabIndex = 4;
            txtBxPasscode4.TextAlign = HorizontalAlignment.Center;
            txtBxPasscode4.KeyDown += btnNextIsValid;
            txtBxPasscode4.KeyUp += btnNextIsValid;
            // 
            // txtBxPasscode6
            // 
            txtBxPasscode6.Anchor = AnchorStyles.None;
            txtBxPasscode6.BackColor = Color.FromArgb(217, 217, 217);
            txtBxPasscode6.BorderStyle = BorderStyle.None;
            txtBxPasscode6.Font = new Font("Gothic A1", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxPasscode6.Location = new Point(731, 18);
            txtBxPasscode6.MaxLength = 1;
            txtBxPasscode6.Multiline = true;
            txtBxPasscode6.Name = "txtBxPasscode6";
            txtBxPasscode6.Size = new Size(72, 64);
            txtBxPasscode6.TabIndex = 6;
            txtBxPasscode6.TextAlign = HorizontalAlignment.Center;
            txtBxPasscode6.KeyDown += btnNextIsValid;
            txtBxPasscode6.KeyUp += btnNextIsValid;
            // 
            // PasscodeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(passcodePanel);
            Name = "PasscodeUserControl";
            Size = new Size(1421, 438);
            passcodePanel.ResumeLayout(false);
            passcodeTextboxesPanel.ResumeLayout(false);
            passcodeTextboxesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LBLSECUREONLY;
        private TextBox txtBxPasscode1;
        private TextBox txtBxPasscode2;
        private TextBox txtBxPasscode3;
        private Panel passcodePanel;
        private TableLayoutPanel passcodeTextboxesPanel;
        private TextBox txtBxPasscode6;
        private TextBox txtBxPasscode5;
        private TextBox txtBxPasscode4;
        private Label LBLNEVERONLY;
        private Button btnShowPasscode;
        private Button btnNext;
        private Button btnCancel;
    }
}
