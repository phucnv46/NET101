using System.Text;

namespace Lab5_6
{
    internal class Program
    {
        static List<Oto> otos = new()
        {
            new Oto(){Id=1,Ten="Fadil",DongCo = new DongCoXang(){Id = 1, Ten = "Turbo 2.5"},NamSX = 2013 },
            new Oto(){Id=1,Ten="LuxA",DongCo = new DongCoDien(){Id = 2, Ten = "Turbo 3.5V"},NamSX = 2023},
        };
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("1.Thêm thông tin oto và đông cơ" +
                    "\r\n2.Tìm và Hiển thị thông tin xe" +
                    "\r\n3.Cập nhật Thông tin xe (Chưa cần cập nhat DongCo)" +
                    "\r\n4.Xóa xe\r\n5.Hiển thị danh sách xe\r\n" +
                    "6.Cập nhật thông tin đông cơ bao gồm cả đổi loại đông cơ" +
                    "\r\n7.Cho 1 xe cụ thể chạy\r\n8.Hiển thị danh sách xe theo loại động cơ\r\n0.Thoát");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 0: return;
                    case 5: HienThiDanhSach(); break;
                    case 1: NhapOto(); break;

                }
            }
        }


        static void NhapOto()
        {
            Oto oto = new Oto();
            Console.WriteLine("Nhập tên Oto:");
            oto.Ten = Console.ReadLine();
            oto.Id = otos[otos.Count - 1].Id + 1;
            Console.WriteLine("Nhập Năm SX");
            oto.NamSX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chọn loại động cơ \n 1.Động cơ điện   2.Đông cơ xăng");
            int choice = int.Parse(Console.ReadLine());
            DongCo dongCo;
            Console.WriteLine("Xin mời nhập tên động cơ");
            string ten = Console.ReadLine();    
            if (choice==1)
            {
                dongCo = new DongCoDien();
                dongCo.Ten = ten;
               
            }
            else if(choice == 2)
            {
                dongCo = new DongCoXang();
                dongCo.Ten = ten;

            }
            else
            {
                Console.WriteLine("Lựa chọn sai");
                return;
            }

            oto.DongCo = dongCo;
            otos.Add(oto);
        }

        static void HienThiDanhSach()
        {
            Console.WriteLine();
            foreach (var oto in otos)
            {
                oto.HienThi();
                Console.WriteLine("Thông tin động cơ xe");
                oto.DongCo.HienThi();
                Console.WriteLine();

            }
            Console.WriteLine();
        }

    }
}
