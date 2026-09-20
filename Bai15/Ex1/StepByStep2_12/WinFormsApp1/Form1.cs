using System;
using System.Drawing;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class nudSize : Form
    {
        public nudSize()
        {
            InitializeComponent();
        }

        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown dudColor = (DomainUpDown)sender;

            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudSize = (NumericUpDown)sender;

            lblSampleText.Font = new Font(
                lblSampleText.Font.FontFamily,
                (float)nudSize.Value
            );
        }
    }
}
