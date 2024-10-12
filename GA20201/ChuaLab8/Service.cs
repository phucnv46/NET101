using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaLab8
{
    internal class Service
    {
        List<GiaoVien> giaoViens = new List<GiaoVien>() {
       new GiaoVien() { ID=1,SoGioDay=25,Ten="Phúc"},
            new GiaoVien() { ID=2,SoGioDay=32,Ten="Thanh"},
         

        };


        public void NhapThongTin()
        {
            GiaoVien giaoVien = new GiaoVien();
            Console.Write("Nhập ID của giáo viên: ");
            /*   int id;
               int.TryParse(Console.ReadLine(),out id);*/
            giaoVien.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tên của giáo viên: ");
            giaoVien.Ten = Console.ReadLine();
            Console.Write("Nhập số giờ dậy của giáo viên: ");
            giaoVien.SoGioDay = double.Parse(Console.ReadLine());
            giaoViens.Add(giaoVien); // Thêm giao viên vào danh sách giáo viên
        }

        public void HienThiDanhSach()
        {
            /*   foreach (var giaoVien in giaoViens)
               {
                   giaoVien.InRaThongTin();
               }*/

            giaoViens.ForEach(giaoVien => giaoVien.InRaThongTin()); // linq
        }

        private GiaoVien TimGiaoVien(int id)
        {
            /*foreach (var giaoVien in giaoViens)
            {
                if (giaoVien.ID == id)
                {
                    return giaoVien;
                }
            }
            return null;*/

            return giaoViens.Find(x => x.ID == id);
        }

        public void Xoa()
        {

            Console.Write("Nhập ID của giáo viên muốn xóa: ");
            int id = Convert.ToInt32(Console.ReadLine());
            GiaoVien giaoVienCanXoa = TimGiaoVien(id);
            if (giaoVienCanXoa is null)
            {
                Console.WriteLine("Không tìm thấy ID của giáo viên muốn xóa");
                return;
            }

            giaoViens.Remove(giaoVienCanXoa);
            HienThiDanhSach();
        }

        public void KeThua()
        {
            GiaoVienPoly giaoVienPoly = new GiaoVienPoly();
            Console.Write("Nhập ID của giáo viên: ");
            /*   int id;
               int.TryParse(Console.ReadLine(),out id);*/
            giaoVienPoly.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tên của giáo viên: ");
            giaoVienPoly.Ten = Console.ReadLine();
            Console.Write("Nhập số giờ dậy của giáo viên: ");
            giaoVienPoly.SoGioDay = double.Parse(Console.ReadLine());
            Console.Write("Nhập số ngành dậy của giáo viên: ");
            giaoVienPoly.NganhDay =Console.ReadLine();

            giaoVienPoly.InRaThongTin();
        }


    }
}
