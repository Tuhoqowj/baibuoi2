
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace qlhs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            List<HocSinh> dsHocSinh = new List<HocSinh>
            {
                new HocSinh(1, "An", 10),
                new HocSinh(2, "Binh", 11),
                new HocSinh(5, "Chi", 9),
                new HocSinh(3, "Dung", 9),
                new HocSinh(4, "Em", 12),
            };

            //a
            var danhSachFull = from hs in dsHocSinh
                               select hs;
            Console.WriteLine("Danh sách đầy đủ");
            foreach (HocSinh hs in danhSachFull)
            {
                Console.WriteLine($"Mã: {hs.MaHocSinh}, Họ tên: {hs.HoTen}, Lớp: {hs.Lop}");
            }

            //b
            var danhSachLop = from hs in dsHocSinh
                              where hs.Lop > 9 && hs.Lop < 13
                              select hs;
            Console.WriteLine("Lớp >9 và <13");
            foreach (HocSinh hs in danhSachLop)
            {
                Console.WriteLine($"Mã: {hs.MaHocSinh}, Họ tên: {hs.HoTen}, Lớp: {hs.Lop}");
            }

            //c
            var tenBatDauA = from hs in dsHocSinh
                             where hs.HoTen.StartsWith("A")
                             select hs;

            foreach (HocSinh hs in tenBatDauA)
            {
                Console.WriteLine($"Mã: {hs.MaHocSinh}, Họ tên: {hs.HoTen}, Lớp: {hs.Lop}");
            }

            //d
            int tongLop = dsHocSinh.Sum(hs => hs.Lop);

            Console.WriteLine($"Tổng số lớp: {tongLop}");

            //e
            HocSinh hocSinhLonNhat = dsHocSinh.OrderByDescending(hs => hs.Lop).FirstOrDefault();

            Console.WriteLine($"Học sinh lớp lớn nhất: Mã: {hocSinhLonNhat.MaHocSinh}, Họ tên: {hocSinhLonNhat.HoTen}, Lớp: {hocSinhLonNhat.Lop}");

            //f
            var sapXepDanhSach = dsHocSinh.OrderBy(hs => hs.Lop);
            Console.WriteLine("Sắp xếp theo lớp");
            foreach (var hs in sapXepDanhSach)
            {
                Console.WriteLine($"Mã: {hs.MaHocSinh}, Họ tên: {hs.HoTen}, Lớp: {hs.Lop}");
            }
        }
    }
}
