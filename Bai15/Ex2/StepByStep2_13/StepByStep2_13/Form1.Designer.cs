namespace StepByStep2_13
{
    partial class Form1
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
            mcTravel = new MonthCalendar();
            lblStartValue = new Label();
            lblEndValue = new Label();
            dtpLaunch = new DateTimePicker();
            rdoLongDate = new RadioButton();
            rdoShortDate = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // mcTravel
            // 
            mcTravel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcTravel.Location = new Point(46, 93);
            mcTravel.MaxSelectionCount = 5;
            mcTravel.Name = "mcTravel";
            mcTravel.TabIndex = 0;
            mcTravel.DateChanged += mcTravel_DateChanged;
            // 
            // lblStartValue
            // 
            lblStartValue.AutoSize = true;
            lblStartValue.Location = new Point(290, 153);
            lblStartValue.Name = "lblStartValue";
            lblStartValue.Size = new Size(0, 20);
            lblStartValue.TabIndex = 1;
            // 
            // lblEndValue
            // 
            lblEndValue.AutoSize = true;
            lblEndValue.Location = new Point(290, 280);
            lblEndValue.Name = "lblEndValue";
            lblEndValue.Size = new Size(0, 20);
            lblEndValue.TabIndex = 2;
            // 
            // dtpLaunch
            // 
            dtpLaunch.Location = new Point(41, 363);
            dtpLaunch.Name = "dtpLaunch";
            dtpLaunch.Size = new Size(250, 27);
            dtpLaunch.TabIndex = 3;
            // 
            // rdoLongDate
            // 
            rdoLongDate.AutoSize = true;
            rdoLongDate.Checked = true;
            rdoLongDate.Location = new Point(41, 421);
            rdoLongDate.Name = "rdoLongDate";
            rdoLongDate.Size = new Size(99, 24);
            rdoLongDate.TabIndex = 4;
            rdoLongDate.TabStop = true;
            rdoLongDate.Text = "Long Date";
            rdoLongDate.UseVisualStyleBackColor = true;
            rdoLongDate.CheckedChanged += rdoLongDate_CheckedChanged;
            // 
            // rdoShortDate
            // 
            rdoShortDate.AutoSize = true;
            rdoShortDate.Location = new Point(172, 421);
            rdoShortDate.Name = "rdoShortDate";
            rdoShortDate.Size = new Size(101, 24);
            rdoShortDate.TabIndex = 5;
            rdoShortDate.Text = "Short Date";
            rdoShortDate.UseVisualStyleBackColor = true;
            rdoShortDate.CheckedChanged += rdoShortDate_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 51);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 6;
            label1.Text = "Select the days you will travel:\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 329);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 7;
            label2.Text = "Product Launch Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 484);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdoShortDate);
            Controls.Add(rdoLongDate);
            Controls.Add(dtpLaunch);
            Controls.Add(lblEndValue);
            Controls.Add(lblStartValue);
            Controls.Add(mcTravel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar mcTravel;
        private Label lblStartValue;
        private Label lblEndValue;
        private DateTimePicker dtpLaunch;
        private RadioButton rdoLongDate;
        private RadioButton rdoShortDate;
        private Label label1;
        private Label label2;
    }
}
