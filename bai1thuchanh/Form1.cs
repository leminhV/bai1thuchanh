namespace bai1thuchanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton =this.btnDangNhap;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkNho_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNho.Checked) {
                MessageBox.Show("Bạn đã chọn ghi nhớ");
            }
            else
            {
                MessageBox.Show("Bạn đã bỏ chọn ghi nhớ");
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string thongbao = "Tên Đăng Nhập" + user + Environment.NewLine
                            + "Mật Khẩu" + pass + Environment.NewLine;
        }

        private void bthXoa_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            chkNho.Checked = false;
            txtUser.Focus();
        }

        private void bthDung_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
