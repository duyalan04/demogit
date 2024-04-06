using QLSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmThemSV : Form
    {
        public List<LopHoc> DsLopHoc { get; set; }
        public List<SinhVien> DsSinhVien { get; set; }

        public int SelectedId { get; set; }

        public frmThemSV()
        {
            InitializeComponent();
        }

        private void frmThemSV_Load(object sender, EventArgs e)
        {
            cbLopHoc.DataSource = DsLopHoc;
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.SelectedIndex = SelectedId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DsSinhVien.Add(new()
            {
                MSSV = (int)txtMSSV.Value,
                MaLop = ((LopHoc)cbLopHoc.SelectedItem).MaLop,
                TenSV = txtTen.Text,
                GioiTinh = chkGioiTinh.Checked,
                NgaySinh = DateTime.Parse(dtNgaySinh.Text),
            });

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
