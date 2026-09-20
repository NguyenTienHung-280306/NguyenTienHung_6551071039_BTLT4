namespace StepByStep2_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mcTravel_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStartValue.Text = mcTravel.SelectionStart.ToShortDateString();
            lblEndValue.Text = mcTravel.SelectionEnd.ToShortDateString();
        }

        private void rdoLongDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLongDate.Checked)
            {
                dtpLaunch.Format = DateTimePickerFormat.Long;
            }
        }

        private void rdoShortDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoShortDate.Checked)
            {
                dtpLaunch.Format = DateTimePickerFormat.Short;
            }
        }

        private void lblStartValue_Click(object sender, EventArgs e)
        {

        }
    }
}
