namespace Trustbank
{
    partial class HelpCenterMainUserControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAbout = new FontAwesome.Sharp.IconButton();
            btnSubmitATicket = new FontAwesome.Sharp.IconButton();
            btnFeedback = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 26, 136);
            label1.Location = new Point(82, 46);
            label1.Name = "label1";
            label1.Size = new Size(305, 76);
            label1.TabIndex = 0;
            label1.Text = "Help Center";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1 SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 26, 136);
            label2.Location = new Point(96, 122);
            label2.Name = "label2";
            label2.Size = new Size(210, 30);
            label2.TabIndex = 1;
            label2.Text = "How can we help you?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnAbout, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSubmitATicket, 0, 0);
            tableLayoutPanel1.Controls.Add(btnFeedback, 2, 0);
            tableLayoutPanel1.Location = new Point(249, 190);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(916, 240);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.None;
            btnAbout.BackColor = Color.FromArgb(241, 241, 241);
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.FromArgb(0, 26, 136);
            btnAbout.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            btnAbout.IconColor = Color.FromArgb(0, 26, 136);
            btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbout.IconSize = 80;
            btnAbout.Location = new Point(339, 15);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(236, 210);
            btnAbout.TabIndex = 5;
            btnAbout.Text = "About";
            btnAbout.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnSubmitATicket
            // 
            btnSubmitATicket.Anchor = AnchorStyles.None;
            btnSubmitATicket.BackColor = Color.FromArgb(241, 241, 241);
            btnSubmitATicket.FlatAppearance.BorderSize = 0;
            btnSubmitATicket.FlatStyle = FlatStyle.Flat;
            btnSubmitATicket.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitATicket.ForeColor = Color.FromArgb(0, 26, 136);
            btnSubmitATicket.IconChar = FontAwesome.Sharp.IconChar.Gears;
            btnSubmitATicket.IconColor = Color.FromArgb(0, 26, 136);
            btnSubmitATicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubmitATicket.IconSize = 80;
            btnSubmitATicket.Location = new Point(34, 15);
            btnSubmitATicket.Name = "btnSubmitATicket";
            btnSubmitATicket.Size = new Size(236, 210);
            btnSubmitATicket.TabIndex = 3;
            btnSubmitATicket.Text = "Submit a Ticket";
            btnSubmitATicket.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSubmitATicket.UseVisualStyleBackColor = false;
            btnSubmitATicket.Click += btnSubmitATicket_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.Anchor = AnchorStyles.None;
            btnFeedback.BackColor = Color.FromArgb(241, 241, 241);
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Gothic A1", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnFeedback.ForeColor = Color.FromArgb(0, 26, 136);
            btnFeedback.IconChar = FontAwesome.Sharp.IconChar.Message;
            btnFeedback.IconColor = Color.FromArgb(0, 26, 136);
            btnFeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFeedback.IconSize = 80;
            btnFeedback.Location = new Point(645, 15);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(236, 210);
            btnFeedback.TabIndex = 4;
            btnFeedback.Text = "Feedback";
            btnFeedback.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // HelpCenterMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HelpCenterMainUserControl";
            Size = new Size(1405, 616);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnSubmitATicket;
        private FontAwesome.Sharp.IconButton btnFeedback;
        private FontAwesome.Sharp.IconButton btnAbout;
    }
}
