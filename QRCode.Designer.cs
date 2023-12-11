namespace Trustbank
{
    partial class QRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCode));
            pboxQR = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxQR).BeginInit();
            SuspendLayout();
            // 
            // pboxQR
            // 
            pboxQR.Image = (Image)resources.GetObject("pboxQR.Image");
            pboxQR.Location = new Point(1, -1);
            pboxQR.Name = "pboxQR";
            pboxQR.Size = new Size(653, 453);
            pboxQR.SizeMode = PictureBoxSizeMode.Zoom;
            pboxQR.TabIndex = 0;
            pboxQR.TabStop = false;
            // 
            // QRCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(652, 451);
            Controls.Add(pboxQR);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QRCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QRCode";
            ((System.ComponentModel.ISupportInitialize)pboxQR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pboxQR;
    }
}