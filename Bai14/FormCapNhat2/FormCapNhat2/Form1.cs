namespace FormCapNhat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {
                string strDuLieu = txtTen.Text;
                lstLopA.Items.Add(strDuLieu);
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            void chuyenDuLieu(ListBox lst1, ListBox lst2)
            {
                int i = 0;
                while (i < lst1.Items.Count)
                    if (lst1.GetSelected(i))
                    {
                        string stDuLieu = lst1.Items[i].ToString();
                        lst2.Items.Add(stDuLieu);
                        lst1.Items.RemoveAt(i);
                    }
                    else
                        i++;
            }
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn\nko?!",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh s|ch hiện đang rỗng!", "Chú ý");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            void chuyenDuLieu(ListBox lst1, ListBox lst2)
            {
                int i = 0;
                while (i < lst2.Items.Count)
                    if (lst2.GetSelected(i))
                    {
                        string stDuLieu = lst2.Items[i].ToString();
                        lst1.Items.Add(stDuLieu);
                        lst2.Items.RemoveAt(i);
                    }
                    else
                        i++;
            }
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn\nko?!",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lstLopA, lstLopB); //sua
            }
            else
                MessageBox.Show("Danh s|ch hiện đang rỗng!", "Chú ý");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            void chuyenToanBo(ListBox lst1, ListBox lst2)
            {
                while (lst1.Items.Count != 0)
                {
                    string stDuLieu = lst1.Items[0].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(0);
                }
            }
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn\nko?!",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lstLopA, lstLopB);
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            void chuyenToanBo(ListBox lst1, ListBox lst2)
            {
                while (lst2.Items.Count != 0)
                {
                    string stDuLieu = lst2.Items[0].ToString();
                    lst1.Items.Add(stDuLieu);
                    lst2.Items.RemoveAt(0);
                }
            }
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show(
                    "Bạn có chắc chuyển những dữ liệu đang chọn\nko?!",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lstLopA, lstLopB);//sua
            }
            else
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
        }

        private void xoaA_Click(object sender, EventArgs e)
        {
            void xoaDuLieu(ListBox lst)
            {
                int i = 0;
                while (i < lst.Items.Count)
                    if (lst.GetSelected(i))
                        lst.Items.RemoveAt(i);
                    else
                        i++;
            }
            DialogResult hoiXoa;
            if (lstLopA.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    xoaDuLieu(lstLopA);
            }
            else
                MessageBox.Show("Hiện danh s|ch đang rỗng!", "Chú ý");

        }

        private void xoaB_Click(object sender, EventArgs e)
        {
            void xoaDuLieu(ListBox lst)
            {
                int i = 0;
                while (i < lst.Items.Count)
                    if (lst.GetSelected(i))
                        lst.Items.RemoveAt(i);
                    else
                        i++;
            }
            DialogResult hoiXoa;
            if (lstLopB.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    xoaDuLieu(lstLopB);
            }
            else
                MessageBox.Show("Hiện danh s|ch đang rỗng!", "Chú ý");
        }

        private void ketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
