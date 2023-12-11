namespace Trustbank
{
    partial class ConversionRateMainUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionRateMainUserControl));
            label1 = new Label();
            label2 = new Label();
            fromcurrencyPictureBox = new PictureBox();
            fromconversionLabel = new Label();
            fromComboBox = new ComboBox();
            inputBox = new RichTextBox();
            label3 = new Label();
            outputBox = new RichTextBox();
            toComboBox = new ComboBox();
            toconversionLabel = new Label();
            tocurrencyPictureBox = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            dateTimeLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label13 = new Label();
            label14 = new Label();
            exchangerateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)fromcurrencyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tocurrencyPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gothic A1", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 26, 136);
            label1.Location = new Point(67, 35);
            label1.Name = "label1";
            label1.Size = new Size(409, 76);
            label1.TabIndex = 0;
            label1.Text = "Conversion Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gothic A1", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 26, 136);
            label2.Location = new Point(83, 151);
            label2.Name = "label2";
            label2.Size = new Size(155, 55);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // fromcurrencyPictureBox
            // 
            fromcurrencyPictureBox.Location = new Point(100, 218);
            fromcurrencyPictureBox.Name = "fromcurrencyPictureBox";
            fromcurrencyPictureBox.Size = new Size(80, 80);
            fromcurrencyPictureBox.TabIndex = 2;
            fromcurrencyPictureBox.TabStop = false;
            // 
            // fromconversionLabel
            // 
            fromconversionLabel.AutoSize = true;
            fromconversionLabel.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            fromconversionLabel.ForeColor = Color.FromArgb(0, 26, 136);
            fromconversionLabel.Location = new Point(202, 237);
            fromconversionLabel.Name = "fromconversionLabel";
            fromconversionLabel.Size = new Size(221, 43);
            fromconversionLabel.TabIndex = 0;
            fromconversionLabel.Text = "Philippine Peso";
            // 
            // fromComboBox
            // 
            fromComboBox.FormattingEnabled = true;
            fromComboBox.Items.AddRange(new object[] { "PHP", "USD", "EUR", "GBP", "SGD", "YEN" });
            fromComboBox.Location = new Point(504, 251);
            fromComboBox.Name = "fromComboBox";
            fromComboBox.Size = new Size(121, 23);
            fromComboBox.TabIndex = 3;
            fromComboBox.SelectedIndexChanged += fromComboBox_SelectedIndexChanged;
            // 
            // inputBox
            // 
            inputBox.Anchor = AnchorStyles.None;
            inputBox.BackColor = Color.FromArgb(241, 241, 241);
            inputBox.BorderStyle = BorderStyle.None;
            inputBox.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            inputBox.Location = new Point(638, 227);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(214, 71);
            inputBox.TabIndex = 4;
            inputBox.Text = "";
            inputBox.TextChanged += inputBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gothic A1", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 26, 136);
            label3.Location = new Point(83, 359);
            label3.Name = "label3";
            label3.Size = new Size(340, 55);
            label3.TabIndex = 5;
            label3.Text = "Converted Amount";
            // 
            // outputBox
            // 
            outputBox.Anchor = AnchorStyles.None;
            outputBox.BackColor = Color.FromArgb(241, 241, 241);
            outputBox.BorderStyle = BorderStyle.None;
            outputBox.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            outputBox.Location = new Point(638, 440);
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(214, 71);
            outputBox.TabIndex = 9;
            outputBox.Text = "";
            // 
            // toComboBox
            // 
            toComboBox.FormattingEnabled = true;
            toComboBox.Items.AddRange(new object[] { "PHP", "USD", "EUR", "GBP", "SGD", "YEN" });
            toComboBox.Location = new Point(502, 465);
            toComboBox.Name = "toComboBox";
            toComboBox.Size = new Size(121, 23);
            toComboBox.TabIndex = 8;
            toComboBox.SelectedIndexChanged += toComboBox_SelectedIndexChanged;
            // 
            // toconversionLabel
            // 
            toconversionLabel.AutoSize = true;
            toconversionLabel.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            toconversionLabel.ForeColor = Color.FromArgb(0, 26, 136);
            toconversionLabel.Location = new Point(202, 450);
            toconversionLabel.Name = "toconversionLabel";
            toconversionLabel.Size = new Size(281, 43);
            toconversionLabel.TabIndex = 6;
            toconversionLabel.Text = "United States Dollar";
            // 
            // tocurrencyPictureBox
            // 
            tocurrencyPictureBox.Location = new Point(100, 431);
            tocurrencyPictureBox.Name = "tocurrencyPictureBox";
            tocurrencyPictureBox.Size = new Size(80, 80);
            tocurrencyPictureBox.TabIndex = 7;
            tocurrencyPictureBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gothic A1", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 26, 136);
            label4.Location = new Point(100, 520);
            label4.Name = "label4";
            label4.Size = new Size(233, 30);
            label4.TabIndex = 10;
            label4.Text = "Indicative Exchange Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gothic A1", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 26, 136);
            label5.Location = new Point(994, 60);
            label5.Name = "label5";
            label5.Size = new Size(319, 43);
            label5.TabIndex = 11;
            label5.Text = "Foreign Exchange Rate";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Gothic A1", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeLabel.ForeColor = Color.FromArgb(0, 26, 136);
            dateTimeLabel.Location = new Point(994, 103);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(54, 30);
            dateTimeLabel.TabIndex = 12;
            dateTimeLabel.Text = "as of";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(994, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 80);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 26, 136);
            label8.Location = new Point(124, 40);
            label8.Name = "label8";
            label8.Size = new Size(151, 24);
            label8.TabIndex = 15;
            label8.Text = "1 PHP = 0.018 USD ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 26, 136);
            label7.Location = new Point(100, 7);
            label7.Name = "label7";
            label7.Size = new Size(214, 33);
            label7.TabIndex = 14;
            label7.Text = "United States Dollar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(994, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 80);
            panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 26, 136);
            label9.Location = new Point(124, 42);
            label9.Name = "label9";
            label9.Size = new Size(151, 24);
            label9.TabIndex = 15;
            label9.Text = "1 PHP = 0.017 USD ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 26, 136);
            label10.Location = new Point(169, 9);
            label10.Name = "label10";
            label10.Size = new Size(60, 33);
            label10.TabIndex = 14;
            label10.Text = "Euro";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(994, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 80);
            panel3.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 26, 136);
            label11.Location = new Point(124, 42);
            label11.Name = "label11";
            label11.Size = new Size(151, 24);
            label11.TabIndex = 15;
            label11.Text = "1 PHP = 0.018 GBP ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 26, 136);
            label12.Location = new Point(100, 7);
            label12.Name = "label12";
            label12.Size = new Size(231, 33);
            label12.TabIndex = 14;
            label12.Text = "British Pound Sterling";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(994, 485);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 80);
            panel4.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(71, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Gothic A1 SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 26, 136);
            label13.Location = new Point(124, 40);
            label13.Name = "label13";
            label13.Size = new Size(147, 24);
            label13.TabIndex = 15;
            label13.Text = "1 PHP = 0.024 SGD";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Gothic A1", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 26, 136);
            label14.Location = new Point(124, 7);
            label14.Name = "label14";
            label14.Size = new Size(180, 33);
            label14.TabIndex = 14;
            label14.Text = "Singapore Dollar";
            // 
            // exchangerateLabel
            // 
            exchangerateLabel.AutoSize = true;
            exchangerateLabel.Font = new Font("Gothic A1", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            exchangerateLabel.ForeColor = Color.FromArgb(0, 26, 136);
            exchangerateLabel.Location = new Point(100, 550);
            exchangerateLabel.Name = "exchangerateLabel";
            exchangerateLabel.Size = new Size(0, 30);
            exchangerateLabel.TabIndex = 19;
            // 
            // ConversionRateMainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(exchangerateLabel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dateTimeLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(outputBox);
            Controls.Add(toComboBox);
            Controls.Add(toconversionLabel);
            Controls.Add(tocurrencyPictureBox);
            Controls.Add(label3);
            Controls.Add(inputBox);
            Controls.Add(fromComboBox);
            Controls.Add(fromconversionLabel);
            Controls.Add(fromcurrencyPictureBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConversionRateMainUserControl";
            Size = new Size(1405, 616);
            ((System.ComponentModel.ISupportInitialize)fromcurrencyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tocurrencyPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox fromcurrencyPictureBox;
        private Label fromconversionLabel;
        private ComboBox fromComboBox;
        private RichTextBox inputBox;
        private Label label3;
        private RichTextBox outputBox;
        private ComboBox toComboBox;
        private Label toconversionLabel;
        private PictureBox tocurrencyPictureBox;
        private Label label4;
        private Label label5;
        private Label dateTimeLabel;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label10;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label11;
        private Label label12;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label13;
        private Label label14;
        private Label exchangerateLabel;
    }
}
