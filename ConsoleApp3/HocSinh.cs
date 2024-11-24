
using System;

namespace qlhs
{
    public class HocSinh
    {
        public int MaHocSinh { get; set; }
        public string HoTen { get; set; }
        public int Lop { get; set; }

        public HocSinh()
        {
        }

        public HocSinh(int maHocSinh, string hoTen, int lop)
        {
            MaHocSinh = maHocSinh;
            HoTen = hoTen;
            Lop = lop;
        }
    }
}

