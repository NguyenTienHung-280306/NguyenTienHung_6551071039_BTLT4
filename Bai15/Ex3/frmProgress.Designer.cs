namespace ProgressControl
{
    partial class frmProgress
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblProgressCap = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblSlide = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            this.lblProgressCap.AutoSize = true;
            this.lblProgressCap.Location = new System.Drawing.Point(15, 15);
            this.lblProgressCap.Name = "lblProgressCap";
            this.lblProgressCap.Text = "Progress Indicator:";

            this.progressBar1.Location = new System.Drawing.Point(15, 45);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 28);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressBar1.TabIndex = 0;

            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(15, 85);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Text = "Percentage Complete: 0%";

            this.lblSlide.AutoSize = true;
            this.lblSlide.Location = new System.Drawing.Point(15, 130);
            this.lblSlide.Name = "lblSlide";
            this.lblSlide.Text = "Slide the TrackBar to control processing speed:";

            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(15, 160);
            this.trackBar1.Maximum = 10;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(350, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);

            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 230);
            this.Controls.Add(this.lblProgressCap);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblSlide);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StepByStep2_15";
        }

        #endregion

        private System.Windows.Forms.Label lblProgressCap;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblSlide;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
