namespace Trustbank
{
    partial class passcodeUserControl
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
            passcodePanel = new Panel();
            textBox1 = new TextBox();
            passcodePanel.SuspendLayout();
            SuspendLayout();
            // 
            // passcodePanel
            // 
            passcodePanel.Controls.Add(textBox1);
            passcodePanel.Location = new Point(0, 0);
            passcodePanel.Name = "passcodePanel";
            passcodePanel.Size = new Size(1322, 420);
            passcodePanel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 23);
            textBox1.TabIndex = 0;
            // 
            // passcodeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(passcodePanel);
            Name = "passcodeUserControl";
            Size = new Size(1421, 438);
            passcodePanel.ResumeLayout(false);
            passcodePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel passcodePanel;
        private TextBox textBox1;
    }
}
