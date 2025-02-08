using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapTX2
{
    internal class NhanVien
    {
        public string maNv { get; set; }
        public string ten { get; set; }
        public int tuoi { get; set; }
        public int luong { get; set; }
        public DiaChi diachi { get; set; } = new DiaChi();
        public string dienThoai { get; set; }
        public NhanVien() { }

    }
}
