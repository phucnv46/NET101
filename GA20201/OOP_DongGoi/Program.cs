using System.Text;

namespace OOP_DongGoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
                        SinhVien sinhVienFPL = new SinhVien() // Sử dụng từ khóa new để khởi tạo đối tượng cụ thể
                        { MaSV="140098", Ho="Nguyễn", Ten="Văn Phúc",NgaySinh=new DateTime(2006,12,23)}; */
            /*sinhVienFPL.MaSV = "322423";
            sinhVienFPL.Ho = "Nguyễn";
            sinhVienFPL.Ten = "Văn Phúc";
            sinhVienFPL.NgaySinh = new DateTime(2006, 1, 31);*/
            /* sinhVienFPL.XinChao();
             sinhVienFPL.HienThiThongTin();*/

            // Khai báo và in ra thông tin Sinh viên trường khác
            // Tạo lớp hình chữ nhật, mô tả và viết phương thức

            /*  HinhChuNhat box = new();
              box.ChieuDai = 1.5;
              box.ChieuRong = 5;
              box.HienThi();
  */

            Cho pitBull = new Cho()
            {
                Ten = "Nix",
                Gender = true,
                ChieuCao = 1.34,
                CanNang = 30,
                MauLong = "Đen",
                NamSinh = new DateTime(2023, 12, 3)
            };
            pitBull.Chay();
            pitBull.Sua();

        }

        //Bài tập về nhà:
        // Tạo class Oto khai báo thuộc tính (tối thiểu 5) và phương thức của nó

    }
}
