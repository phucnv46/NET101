using System.Text;
using System.Text.Unicode;

namespace ChuaDeMau1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            SERVICE service = new SERVICE();
            while (true)
            {
                Console.WriteLine("\r\n1.Nhập thông tin đối tượng." +
                    "\r\n2.Hiển thị danh sách đối tượng." +
                    "\r\n3.Tìm kiếm sinh viên theo mã." +
                    "\r\n4.Thoát.\r\n5.Kế thừa");
                Console.Write("\nXin mời nhập lựa chọn:");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {

                    case 1: service.NhapSinhVien(); break;
                    case 2: service.HienThiDanhSach(); break;
                    case 3: service.TimSinhVien(); break;
                    case 4: return;
                    case 5 : service.KeThua(); break;
                    default:  return;
                       
                }
            }
        }
    }
}
