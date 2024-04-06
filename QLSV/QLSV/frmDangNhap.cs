namespace QLSV
{
    public partial class frmDangNhap : Form
    {
        public bool IsOk { get; set; }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            const string user = "admin";
            const string password = "123";

            if (user.Equals(txtTaiKhoan.Text) &&
                password.Equals(txtMatKhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                frmMain mainForm = new frmMain();
                mainForm.Show();
                this.Hide();
                /*IsOk = true;*/
              
            }
            else
            {
                MessageBox.Show("Sai tk hoặc mk", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
