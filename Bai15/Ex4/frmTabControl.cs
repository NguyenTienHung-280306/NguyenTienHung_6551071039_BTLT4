namespace TabControlDemo
{
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBoxButtons nut = MessageBoxButtons.OK;
            if (radOKCancel.Checked)
                nut = MessageBoxButtons.OKCancel;
            else if (radRetryCancel.Checked)
                nut = MessageBoxButtons.RetryCancel;
            else if (radYesNo.Checked)
                nut = MessageBoxButtons.YesNo;
            else if (radYesNoCancel.Checked)
                nut = MessageBoxButtons.YesNoCancel;

            MessageBoxIcon bieuTuong = MessageBoxIcon.None;
            if (radError.Checked)
                bieuTuong = MessageBoxIcon.Error;
            else if (radInformation.Checked)
                bieuTuong = MessageBoxIcon.Information;
            else if (radQuestion.Checked)
                bieuTuong = MessageBoxIcon.Question;
            else if (radWarning.Checked)
                bieuTuong = MessageBoxIcon.Warning;

            MessageBox.Show(txtMessage.Text, txtCaption.Text, nut, bieuTuong);
        }

        private void radTabLayout_CheckedChanged(object sender, EventArgs e)
        {
            if (radLeft.Checked)
                tabControl1.Alignment = TabAlignment.Left;
            else if (radRight.Checked)
                tabControl1.Alignment = TabAlignment.Right;
            else if (radBottom.Checked)
                tabControl1.Alignment = TabAlignment.Bottom;
            else
                tabControl1.Alignment = TabAlignment.Top;
        }
    }
}
