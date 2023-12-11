namespace Trustbank
{
    partial class FeedbackMainUserControl
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
            txtBxSatisfaction = new TextBox();
            label1 = new Label();
            txtBxSuggestion = new TextBox();
            label3 = new Label();
            btnSubmit = new Button();
            btnBack = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 26, 136);
            label2.Location = new Point(537, 27);
            label2.Name = "label2";
            label2.Size = new Size(313, 55);
            label2.TabIndex = 3;
            label2.Text = "Send a Feedback";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBxSatisfaction
            // 
            txtBxSatisfaction.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxSatisfaction.Location = new Point(361, 139);
            txtBxSatisfaction.Multiline = true;
            txtBxSatisfaction.Name = "txtBxSatisfaction";
            txtBxSatisfaction.Size = new Size(659, 48);
            txtBxSatisfaction.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 26, 136);
            label1.Location = new Point(437, 106);
            label1.Name = "label1";
            label1.Size = new Size(488, 30);
            label1.TabIndex = 5;
            label1.Text = "Please your overall satisfaction in using our services.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBxSuggestion
            // 
            txtBxSuggestion.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxSuggestion.Location = new Point(361, 276);
            txtBxSuggestion.Multiline = true;
            txtBxSuggestion.Name = "txtBxSuggestion";
            txtBxSuggestion.Size = new Size(659, 202);
            txtBxSuggestion.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 26, 136);
            label3.Location = new Point(425, 243);
            label3.Name = "label3";
            label3.Size = new Size(539, 30);
            label3.TabIndex = 7;
            label3.Text = "Is there anything you can suggest to improve our services?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 26, 136);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(500, 520);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(340, 50);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Send Feedback";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
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
            btnBack.TabIndex = 13;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FeedbackMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(txtBxSuggestion);
            Controls.Add(label3);
            Controls.Add(txtBxSatisfaction);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "FeedbackMainUserControl";
            Size = new Size(1405, 616);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtBxSatisfaction;
        private Label label1;
        private TextBox txtBxSuggestion;
        private Label label3;
        private Button btnSubmit;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}
