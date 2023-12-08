namespace Trustbank
{
    partial class DoneUserControl
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
            btnCheck = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.White;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCheck.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnCheck.IconColor = Color.PaleGreen;
            btnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCheck.IconSize = 250;
            btnCheck.Location = new Point(577, 14);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(271, 236);
            btnCheck.TabIndex = 0;
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(577, 233);
            label1.Name = "label1";
            label1.Size = new Size(276, 51);
            label1.TabIndex = 0;
            label1.Text = "Congratulations!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(557, 284);
            label2.Name = "label2";
            label2.Size = new Size(318, 25);
            label2.TabIndex = 1;
            label2.Text = "You can now experience secure banking.";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 26, 136);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Gothic A1", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(556, 326);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(318, 62);
            btnStart.TabIndex = 2;
            btnStart.Text = "Let's get started";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // DoneUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCheck);
            Name = "DoneUserControl";
            Size = new Size(1421, 438);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCheck;
        private Label label1;
        private Label label2;
        private Button btnStart;
    }
}
