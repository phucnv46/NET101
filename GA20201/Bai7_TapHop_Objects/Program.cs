using System.Text;

namespace Bai7_TapHop_Objects
{
    internal class Program
    {
        static List<HocVien> _hocViens = new List<HocVien>() { 
            new HocVien() {HoTen = "Nguyễn Văn Phúc", Diem = 10, Email = "phucnv46@fe.edu.vn", MaHocVien =1},
         new HocVien() {HoTen = "Nguyễn Đắc Thành", Diem = 4, Email = "thanhdn23@fe.edu.vn",MaHocVien = 2},
            new HocVien() {HoTen = "Trần Bình", Diem = 5, Email = "binht1@fe.edu.vn" ,MaHocVien=3}};
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
            
        }

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("1.Thêm học viên mới\n" +
               "2.Xuất danh sách học viên\n" +
               "3.Tìm kiếm học viên theo khoảng điểm\n" +
               "0.Exit");
                Console.Write("Xin mời nhập lựa chọn: ");

                int chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0: return;
                    case 1:
                        ThemHocVien();
                        break;
                    case 2:
                        XuatDanhSach(_hocViens); // truyền vào danh sách gốc
                        break;
                    case 3:
                        TimHocVienTheoDiem();
                        break;
                    default:
                        Console.WriteLine("Chon sai"); break;
                }
            }

        }

        static void ThemHocVien()
        {

            HocVien hocVien = new HocVien(); // khởi tạo 1 học viên mới
            hocVien.MaHocVien = _hocViens.Count + 1;
            Console.Write("Nhập tên học viên: ");
            hocVien.HoTen = Console.ReadLine() ;
            Console.Write("Nhập điểm học viên: ");
            hocVien.Diem = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm email của học viên: ");
            hocVien.Email = Console.ReadLine();
            _hocViens.Add(hocVien);
        }

        static void XuatDanhSach(List<HocVien> hocviens) // In ra danh sách học viên truyền vào
        {
        
            Console.WriteLine("---Danh sách học viên----");
           
            foreach (var hv in hocviens)
            {
                Console.WriteLine("Mã học viên: {4} Họ và tên: {0}, Điểm: {1}, Email: {2}, Học lực : {3}",hv.HoTen,hv.Diem,hv.Email,hv.HocLuc,hv.MaHocVien);
            }
            Console.WriteLine("------------------------\n");
        }

        static void TimHocVienTheoDiem()
        {
            Console.Write("Xin mời nhập cận dưới:");
            float min = float.Parse(Console.ReadLine()) ;
            Console.Write("Xin mời nhập cận trên:");
            float max = float.Parse(Console.ReadLine());
          

            List<HocVien> hd = new List<HocVien>(); // danh sách chứa các sinh viên tìm được theo điểm

            foreach (var hv in _hocViens)
            {
                if (hv.Diem >= min && hv.Diem <= max) hd.Add(hv); // Tìm được rồi thì thêm vào danh sách đã tạo phía trên
            }

            if(hd.Count == 0)  // List học viên theo điểm rỗng => không tìm được
            {
                Console.WriteLine("\nKhông tìm được!\n");
            }else
            {
                XuatDanhSach(hd);
            }
           // Xuất danh sách với danh sách truyền vào là danh sách sv đã tiềm được theo điểm


        }



    }
}
