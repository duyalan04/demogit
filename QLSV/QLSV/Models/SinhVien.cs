using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Models
{
    public class SinhVien
    {
        public int MSSV { get; set; }
        public string TenSV { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public float Diem {  get; set; }
        public int MaLop { get; set; }
    }
}
