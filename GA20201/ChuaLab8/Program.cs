using System.Text;

namespace ChuaLab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Service service = new Service();
            int choice;
            while (true)
            {

                Console.WriteLine("1.Nhập thông tin đối tượng." +
                    "\r\n2.Hiển thị danh sách đối tượng." +
                    "\r\n3.Xóa đối tượng theo ID." +
                    "\r\n4.Thoát." +
                    "\r\n5.Kế thừa");
                Console.Write("Xin mời nhập lựa chọn: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        service.NhapThongTin();
                        break;
                    case 2:
                        service.HienThiDanhSach();
                        break;
                    case 3:
                        service.Xoa();

                        break;
                    case 4: return;
                    case 5: service.KeThua();
                        break;
                    default:
                        return;
                        break;
                }

                Console.WriteLine("\n");
            }
        }
    }
}
