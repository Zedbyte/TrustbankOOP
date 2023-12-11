namespace Trustbank
{
    partial class TicketMainUserControl
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
            label2 = new Label();
            label1 = new Label();
            txtBxIssue = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBxDescription = new TextBox();
            btnSubmit = new Button();
            pBoxImageTicket = new PictureBox();
            btnAddImage = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            btnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pBoxImageTicket).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 26, 136);
            label2.Location = new Point(554, 23);
            label2.Name = "label2";
            label2.Size = new Size(285, 55);
            label2.TabIndex = 2;
            label2.Text = "Submit a Ticket";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 26, 136);
            label1.Location = new Point(351, 79);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 3;
            label1.Text = "Issue:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBxIssue
            // 
            txtBxIssue.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxIssue.Location = new Point(360, 112);
            txtBxIssue.Multiline = true;
            txtBxIssue.Name = "txtBxIssue";
            txtBxIssue.Size = new Size(659, 35);
            txtBxIssue.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 26, 136);
            label3.Location = new Point(360, 150);
            label3.Name = "label3";
            label3.Size = new Size(460, 30);
            label3.TabIndex = 5;
            label3.Text = "Please provide a brief description of the problem.";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 26, 136);
            label4.Location = new Point(360, 180);
            label4.Name = "label4";
            label4.Size = new Size(218, 48);
            label4.TabIndex = 6;
            label4.Text = "• When did this issue occur? \r\n• Is this a recurring issue?";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBxDescription
            // 
            txtBxDescription.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxDescription.Location = new Point(360, 231);
            txtBxDescription.Multiline = true;
            txtBxDescription.Name = "txtBxDescription";
            txtBxDescription.Size = new Size(659, 164);
            txtBxDescription.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 26, 136);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(515, 540);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(340, 50);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit Ticket";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pBoxImageTicket
            // 
            pBoxImageTicket.Location = new Point(830, 445);
            pBoxImageTicket.Name = "pBoxImageTicket";
            pBoxImageTicket.Size = new Size(189, 68);
            pBoxImageTicket.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxImageTicket.TabIndex = 9;
            pBoxImageTicket.TabStop = false;
            // 
            // btnAddImage
            // 
            btnAddImage.FlatAppearance.BorderColor = Color.FromArgb(0, 26, 136);
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddImage.ForeColor = Color.FromArgb(0, 26, 136);
            btnAddImage.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAddImage.IconColor = Color.Black;
            btnAddImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddImage.Location = new Point(360, 445);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(460, 68);
            btnAddImage.TabIndex = 10;
            btnAddImage.Text = "Add files here";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 26, 136);
            label5.Location = new Point(360, 403);
            label5.Name = "label5";
            label5.Size = new Size(527, 30);
            label5.TabIndex = 11;
            label5.Text = "Please attach a screenshot of the problem (if applicable)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.Location = new Point(197, 46);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(70, 63);
            btnBack.TabIndex = 12;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // TicketMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(btnAddImage);
            Controls.Add(pBoxImageTicket);
            Controls.Add(btnSubmit);
            Controls.Add(txtBxDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBxIssue);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "TicketMainUserControl";
            Size = new Size(1405, 616);
            ((System.ComponentModel.ISupportInitialize)pBoxImageTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtBxIssue;
        private Label label3;
        private Label label4;
        private TextBox txtBxDescription;
        private Button btnSubmit;
        private PictureBox pBoxImageTicket;
        private FontAwesome.Sharp.IconButton btnAddImage;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}
