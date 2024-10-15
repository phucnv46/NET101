using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ChuaDeMau1
{
    internal class SERVICE
    {
        List<SinhVien> sinhViens = new List<SinhVien>()
        {
            new SinhVien(){MaSV="PH01",Ten="Phuc",NamSinh=2004},
            new SinhVien(){MaSV="PH02",Ten="Hieu",NamSinh=2003},
            new SinhVien(){MaSV="PH03",Ten="Hoang",NamSinh=2001},
        };

        public void NhapSinhVien()
        {
            SinhVien sinhVien = new SinhVien();
            Console.Write("Xin mời nhập mã sinh viên: ");
            sinhVien.MaSV = Console.ReadLine();
            Console.Write("Xin mời nhập tên: ");
            sinhVien.Ten = Console.ReadLine();
            int tuoi = 0;
            while (tuoi <= 18)
            {
                Console.Write("Xin mời nhập năm sinh: ");
                int namSinh;
                int.TryParse(Console.ReadLine(), out namSinh);
                sinhVien.NamSinh = namSinh;
                tuoi = DateTime.Now.Year - namSinh;
            }
            sinhViens.Add(sinhVien);

        }

        public void HienThiDanhSach()
        {
            sinhViens.ForEach(sv =>{
                sv.InThongTin();
                System.Console.WriteLine();
                } ); // LinQ
           /* foreach (var sv in sinhViens)
            {
                sv.InThongTin();
            }*/
        }

        public SinhVien TimSinhVien()
        {
            Console.Write("Vui lòng nhập mã sv cần tìm: ");
            string ma = Console.ReadLine();

            foreach (var sinhVien in sinhViens)
            {
                
                if (sinhVien.MaSV.Equals(ma,StringComparison.OrdinalIgnoreCase))
                {
                    sinhVien.InThongTin();
                    return sinhVien;
                } 
            }

            Console.WriteLine("Không tìm thấy sinh viên! ");
            return null;
        }

        public void KeThua()
        {   SinhVienUDPM sinhVien = new SinhVienUDPM();
            Console.Write("Xin mời nhập mã sinh viên: ");
            sinhVien.MaSV = Console.ReadLine();
            Console.Write("Xin mời nhập tên: ");
            sinhVien.Ten = Console.ReadLine();
            int tuoi = 0;
            while (tuoi <= 18)
            {
                Console.Write("Xin mời nhập năm sinh: ");
                int namSinh;
                int.TryParse(Console.ReadLine(), out namSinh);
                sinhVien.NamSinh = namSinh;
                tuoi = DateTime.Now.Year - namSinh;
            }
            System.Console.Write("Xin mời nhập điểm Java: ");
            double diemJava=0;
            double.TryParse(Console.ReadLine(),out diemJava);
             System.Console.Write("Xin mời nhập điểm Csharp: ");
            double diemCSharp=0;
            double.TryParse(Console.ReadLine(),out diemCSharp);
            sinhVien.DiemJava = diemJava;
            sinhVien.DiemCSharp = diemCSharp;   
            sinhVien.InThongTin();
        }

      

    }
}
