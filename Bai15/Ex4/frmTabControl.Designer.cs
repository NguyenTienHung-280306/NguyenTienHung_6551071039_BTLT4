namespace TabControlDemo
{
    partial class frmTabControl
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
            this.lblChon = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.tabButtons = new System.Windows.Forms.TabPage();
            this.tabIcon = new System.Windows.Forms.TabPage();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.radOK = new System.Windows.Forms.RadioButton();
            this.radOKCancel = new System.Windows.Forms.RadioButton();
            this.radRetryCancel = new System.Windows.Forms.RadioButton();
            this.radYesNo = new System.Windows.Forms.RadioButton();
            this.radYesNoCancel = new System.Windows.Forms.RadioButton();
            this.radError = new System.Windows.Forms.RadioButton();
            this.radInformation = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.radQuestion = new System.Windows.Forms.RadioButton();
            this.radWarning = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.grpTabLayout = new System.Windows.Forms.GroupBox();
            this.radLeft = new System.Windows.Forms.RadioButton();
            this.radRight = new System.Windows.Forms.RadioButton();
            this.radTop = new System.Windows.Forms.RadioButton();
            this.radBottom = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.tabButtons.SuspendLayout();
            this.tabIcon.SuspendLayout();
            this.grpMessage.SuspendLayout();
            this.grpTabLayout.SuspendLayout();
            this.SuspendLayout();

            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(15, 12);
            this.lblChon.Name = "lblChon";
            this.lblChon.Text = "Select options to create a message box:";

            this.tabControl1.Controls.Add(this.tabMessage);
            this.tabControl1.Controls.Add(this.tabButtons);
            this.tabControl1.Controls.Add(this.tabIcon);
            this.tabControl1.Location = new System.Drawing.Point(15, 42);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 230);
            this.tabControl1.TabIndex = 0;

            this.tabMessage.Controls.Add(this.grpMessage);
            this.tabMessage.Controls.Add(this.lblCaption);
            this.tabMessage.Controls.Add(this.txtCaption);
            this.tabMessage.Location = new System.Drawing.Point(4, 29);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessage.Size = new System.Drawing.Size(382, 197);
            this.tabMessage.TabIndex = 0;
            this.tabMessage.Text = "Message";
            this.tabMessage.UseVisualStyleBackColor = true;

            this.grpMessage.Controls.Add(this.txtMessage);
            this.grpMessage.Location = new System.Drawing.Point(15, 10);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(350, 90);
            this.grpMessage.TabStop = false;
            this.grpMessage.Text = "Enter the message to display:";

            this.txtMessage.Location = new System.Drawing.Point(15, 30);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(320, 45);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "Sample Message";

            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(15, 115);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Text = "Enter a Caption for MessageBox:";

            this.txtCaption.Location = new System.Drawing.Point(15, 140);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(350, 27);
            this.txtCaption.TabIndex = 1;
            this.txtCaption.Text = "TabControl Demo";

            this.tabButtons.Controls.Add(this.radOK);
            this.tabButtons.Controls.Add(this.radOKCancel);
            this.tabButtons.Controls.Add(this.radRetryCancel);
            this.tabButtons.Controls.Add(this.radYesNo);
            this.tabButtons.Controls.Add(this.radYesNoCancel);
            this.tabButtons.Location = new System.Drawing.Point(4, 29);
            this.tabButtons.Name = "tabButtons";
            this.tabButtons.Padding = new System.Windows.Forms.Padding(3);
            this.tabButtons.Size = new System.Drawing.Size(382, 197);
            this.tabButtons.TabIndex = 1;
            this.tabButtons.Text = "Buttons";
            this.tabButtons.UseVisualStyleBackColor = true;

            this.tabIcon.Controls.Add(this.radError);
            this.tabIcon.Controls.Add(this.radInformation);
            this.tabIcon.Controls.Add(this.radNone);
            this.tabIcon.Controls.Add(this.radQuestion);
            this.tabIcon.Controls.Add(this.radWarning);
            this.tabIcon.Location = new System.Drawing.Point(4, 29);
            this.tabIcon.Name = "tabIcon";
            this.tabIcon.Padding = new System.Windows.Forms.Padding(3);
            this.tabIcon.Size = new System.Drawing.Size(382, 197);
            this.tabIcon.TabIndex = 2;
            this.tabIcon.Text = "Icon";
            this.tabIcon.UseVisualStyleBackColor = true;

            this.radOK.AutoSize = true;
            this.radOK.Checked = true;
            this.radOK.TabStop = true;
            this.radOK.Location = new System.Drawing.Point(25, 15);
            this.radOK.Name = "radOK";
            this.radOK.Text = "OK";

            this.radOKCancel.AutoSize = true;
            this.radOKCancel.Location = new System.Drawing.Point(25, 49);
            this.radOKCancel.Name = "radOKCancel";
            this.radOKCancel.Text = "OK and Cancel";

            this.radRetryCancel.AutoSize = true;
            this.radRetryCancel.Location = new System.Drawing.Point(25, 83);
            this.radRetryCancel.Name = "radRetryCancel";
            this.radRetryCancel.Text = "Retry and Cancel";

            this.radYesNo.AutoSize = true;
            this.radYesNo.Location = new System.Drawing.Point(25, 117);
            this.radYesNo.Name = "radYesNo";
            this.radYesNo.Text = "Yes and No";

            this.radYesNoCancel.AutoSize = true;
            this.radYesNoCancel.Location = new System.Drawing.Point(25, 151);
            this.radYesNoCancel.Name = "radYesNoCancel";
            this.radYesNoCancel.Text = "Yes, No and Cancel";

            this.radError.AutoSize = true;
            this.radError.Location = new System.Drawing.Point(25, 15);
            this.radError.Name = "radError";
            this.radError.Text = "Error";

            this.radInformation.AutoSize = true;
            this.radInformation.Checked = true;
            this.radInformation.TabStop = true;
            this.radInformation.Location = new System.Drawing.Point(25, 49);
            this.radInformation.Name = "radInformation";
            this.radInformation.Text = "Information";

            this.radNone.AutoSize = true;
            this.radNone.Location = new System.Drawing.Point(25, 83);
            this.radNone.Name = "radNone";
            this.radNone.Text = "None";

            this.radQuestion.AutoSize = true;
            this.radQuestion.Location = new System.Drawing.Point(25, 117);
            this.radQuestion.Name = "radQuestion";
            this.radQuestion.Text = "Question";

            this.radWarning.AutoSize = true;
            this.radWarning.Location = new System.Drawing.Point(25, 151);
            this.radWarning.Name = "radWarning";
            this.radWarning.Text = "Warning";

            this.radLeft.AutoSize = true;
            this.radLeft.Location = new System.Drawing.Point(25, 30);
            this.radLeft.Name = "radLeft";
            this.radLeft.Text = "Left";
            this.radLeft.CheckedChanged += new System.EventHandler(this.radTabLayout_CheckedChanged);

            this.radRight.AutoSize = true;
            this.radRight.Location = new System.Drawing.Point(210, 30);
            this.radRight.Name = "radRight";
            this.radRight.Text = "Right";
            this.radRight.CheckedChanged += new System.EventHandler(this.radTabLayout_CheckedChanged);

            this.radTop.AutoSize = true;
            this.radTop.Checked = true;
            this.radTop.TabStop = true;
            this.radTop.Location = new System.Drawing.Point(25, 62);
            this.radTop.Name = "radTop";
            this.radTop.Text = "Top";
            this.radTop.CheckedChanged += new System.EventHandler(this.radTabLayout_CheckedChanged);

            this.radBottom.AutoSize = true;
            this.radBottom.Location = new System.Drawing.Point(210, 62);
            this.radBottom.Name = "radBottom";
            this.radBottom.Text = "Bottom";
            this.radBottom.CheckedChanged += new System.EventHandler(this.radTabLayout_CheckedChanged);
            this.btnShow.Location = new System.Drawing.Point(150, 285);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 35);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show!";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);

            this.grpTabLayout.Controls.Add(this.radLeft);
            this.grpTabLayout.Controls.Add(this.radRight);
            this.grpTabLayout.Controls.Add(this.radTop);
            this.grpTabLayout.Controls.Add(this.radBottom);
            this.grpTabLayout.Location = new System.Drawing.Point(15, 335);
            this.grpTabLayout.Name = "grpTabLayout";
            this.grpTabLayout.Size = new System.Drawing.Size(390, 100);
            this.grpTabLayout.TabStop = false;
            this.grpTabLayout.Text = "Tab Layout";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.grpTabLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StepByStep2_17";

            this.tabControl1.ResumeLayout(false);
            this.tabMessage.ResumeLayout(false);
            this.tabButtons.ResumeLayout(false);
            this.tabIcon.ResumeLayout(false);
            this.grpMessage.ResumeLayout(false);
            this.grpTabLayout.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMessage;
        private System.Windows.Forms.TabPage tabButtons;
        private System.Windows.Forms.TabPage tabIcon;
        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.RadioButton radOK;
        private System.Windows.Forms.RadioButton radOKCancel;
        private System.Windows.Forms.RadioButton radRetryCancel;
        private System.Windows.Forms.RadioButton radYesNo;
        private System.Windows.Forms.RadioButton radYesNoCancel;
        private System.Windows.Forms.RadioButton radError;
        private System.Windows.Forms.RadioButton radInformation;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.RadioButton radQuestion;
        private System.Windows.Forms.RadioButton radWarning;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox grpTabLayout;
        private System.Windows.Forms.RadioButton radLeft;
        private System.Windows.Forms.RadioButton radRight;
        private System.Windows.Forms.RadioButton radTop;
        private System.Windows.Forms.RadioButton radBottom;
    }
}
