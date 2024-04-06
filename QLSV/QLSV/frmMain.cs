using QLSV.Models;
using System.Data;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class frmMain : Form
    {

        private List<LopHoc> dsLopHoc;
        private List<SinhVien> dsSinhVien;

        string conn = @"Data Source=.;Initial Catalog=DemoWinForm;Integrated Security=True";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dsLopHoc = new List<LopHoc>()
            {
                new(){MaLop = 1, TenLop= "Lớp 1"},
                new(){MaLop = 2, TenLop= "Lớp 2"},
                new(){MaLop = 3, TenLop= "Lớp 3"},
                new(){MaLop = 4, TenLop= "Lớp 4"},
            };

            int id = 1;
            string query1 = @"SELECT *FROM CLASS";
            DataTable data = new DataTable();
            string query = $"exec USP_GetUserById @Id = {id}";
            dgvLopHoc.DataSource = DataProvider.Instance.ExecuteQuery(query,new object[] {id});

            //dgvLopHoc.DataSource = dsLopHoc;

            dsSinhVien = new List<SinhVien>();

            foreach (var lop in dsLopHoc)
            {
                for (int i = 0; i < 5; i++)
                {
                    dsSinhVien.Add(
                         new()
                         {
                             MaLop = lop.MaLop,
                             MSSV = int.Parse($"{lop.MaLop}{i}"),
                             TenSV = $"NV {i}",
                             GioiTinh = i % 2 == 0,
                             NgaySinh = new DateTime(2002, 1, 1)
                         });
                }
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            loadData();
        }

        private void loadData()
        {
            var slectedIndex = dgvLopHoc.CurrentCell.RowIndex;
            var ds = dsSinhVien.Where(sv =>
            sv.MaLop == dsLopHoc[slectedIndex].MaLop).ToList();

            dgvDanhSach.DataSource = ds;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSV themSV = new frmThemSV();
            themSV.DsLopHoc = dsLopHoc;
            themSV.SelectedId = dgvLopHoc.CurrentCell.RowIndex;
            themSV.DsSinhVien = dsSinhVien;
            themSV.FormClosed += ThemSV_FormClosed;
            themSV.ShowDialog();
        }

        private void ThemSV_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var slectedItem = ((List<SinhVien>)dgvDanhSach.DataSource)[dgvDanhSach
                .CurrentCell.RowIndex];
            dsSinhVien.Remove(slectedItem);
            loadData();
        }
    }
}
