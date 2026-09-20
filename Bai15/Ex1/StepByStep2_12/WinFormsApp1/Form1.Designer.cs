namespace WinFormsApp1
{
    partial class nudSize
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblColor = new Label();
            lblSize = new Label();
            dudColor = new DomainUpDown();
            numericUpDown1 = new NumericUpDown();
            lblSampleText = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(88, 106);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 20);
            lblColor.TabIndex = 0;
            lblColor.Text = "Color:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(97, 194);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 20);
            lblSize.TabIndex = 1;
            lblSize.Text = "Size:";
            // 
            // dudColor
            // 
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Yellow");
            dudColor.Location = new Point(184, 104);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(150, 27);
            dudColor.TabIndex = 2;
            dudColor.Text = "domainUpDown1";
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(184, 194);
            numericUpDown1.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSampleText.Location = new Point(158, 301);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(176, 38);
            lblSampleText.TabIndex = 4;
            lblSampleText.Text = "Sample Text";
            // 
            // nudSize
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 386);
            Controls.Add(lblSampleText);
            Controls.Add(numericUpDown1);
            Controls.Add(dudColor);
            Controls.Add(lblSize);
            Controls.Add(lblColor);
            Name = "nudSize";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColor;
        private Label lblSize;
        private DomainUpDown dudColor;
        private NumericUpDown numericUpDown1;
        private Label lblSampleText;
    }
}
