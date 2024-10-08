using System.Runtime;
using System.Text;


namespace Lab5_6
{
    internal class Program
    {
        static List<Oto> otos = new()
        {
            new Oto(){Id=1,Ten="Fadil",DongCo = new DongCoXang(){Id = 1, Ten = "Turbo 2.5"},NamSX = 2013 },
            new Oto(){Id=2,Ten="LuxA",DongCo = new DongCoDien(){Id = 2, Ten = "Turbo 3.5V"},NamSX = 2023},
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
                Console.Write("Vui lòng nhập lựa chọn:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0: return;
                    case 5: HienThiDanhSach(); break;
                    case 1: NhapOto(); break;
                    case 2:
                        Oto oto = TimOto();
                        if (oto != null)
                        {
                            oto.HienThi();

                        }
                        else
                        {
                            Console.WriteLine("\nKhông tìm thấy xe");
                        }
                        break;
                    case 3: CapNhatOto(); break;
                    case 4: XoaXe(); break;
                    case 7: ChayXe(); break;
                    case 8: PhanLoaiXe(); break;
                    case 6: CapNhatDongCo(); break;


                }

                Console.WriteLine("\n");
            }


        }

        private static void CapNhatDongCo()
        {
            Oto oto = TimOto();
            if (oto != null)
            {
                Console.WriteLine("Thông tin động cơ hiện tại:");
                oto.DongCo.HienThi();
                Console.Write("Có muốn tiếp tục cập nhật(Y/N): ");
                if (Console.ReadLine().ToLower().Equals("y"))
                {
                    Console.WriteLine("Chọn loại động cơ \n 1.Động cơ điện   2.Đông cơ xăng");
                    int choice = int.Parse(Console.ReadLine());
                    DongCo dongCo;
                    Console.Write("Xin mời nhập tên động cơ: ");
                    string ten = Console.ReadLine();
                    if (choice == 1)
                    {
                        dongCo = new DongCoDien();

                    }
                    else if (choice == 2)
                    {
                        dongCo = new DongCoXang();

                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn sai");
                        return;
                    }

                      dongCo.Ten = ten;
            oto.DongCo = dongCo;

                }
                else
                {
                    return;
                }
            }
        }

        private static void PhanLoaiXe()
        {
            Console.WriteLine("1.Đông cơ xăng \t2.Động cơ điện");
            Console.Write("Chọn loại xe muốn tìm:");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice!=1 && choice!=2 )
            {
                Console.WriteLine("Vui lòng chọn lại");
                return;
            }
            else
            {
                foreach (var oto in otos)
                {
                    if (oto.DongCo is DongCoXang && choice == 1)
                    {
                        oto.HienThi();
                        oto.DongCo.HienThi();
                    }
                    else if(oto.DongCo is DongCoDien && choice == 2)
                    {
                        oto.HienThi();
                        oto.DongCo.HienThi();
                    }
                }
            }                
        }

        private static void ChayXe()
        {
            Oto oto = TimOto();
            if( oto != null )
            {
                Console.WriteLine();
                oto.DongCo.KhoiDong();
                oto.Chay();
                oto.DongCo.TatDongCo();
            }
            Console.WriteLine("Không tìm thấy xe");

        }

        private static void XoaXe()
        {
            Oto deletedOto = TimOto();
            if( deletedOto != null )
            {
                otos.Remove(deletedOto);
                Console.WriteLine("Xóa thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy Ôto");
            }
        }

        static void CapNhatOto()
        {
            Oto updatedOto = TimOto();
            if( updatedOto != null )
            {
                Console.WriteLine("Nhập tên Oto:");
                updatedOto.Ten = Console.ReadLine();
                Console.WriteLine("Nhập Năm SX");
                updatedOto.NamSX = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Không tìm thấy Ôto");
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
            if (choice == 1)
            {
                dongCo = new DongCoDien();

            }
            else if (choice == 2)
            {
                dongCo = new DongCoXang();

            }
            else
            {
                Console.WriteLine("Lựa chọn sai");
                return;
            }
            dongCo.Id = otos[otos.Count - 1].DongCo.Id + 1;
            dongCo.Ten = ten;
            oto.DongCo = dongCo;
            otos.Add(oto);
        }


        static Oto? TimOto()
        {
            Console.Write("Vui lòng nhập mã xe: ");
            long id = Convert.ToInt64(Console.ReadLine());
            foreach (Oto oto in otos)
            {
                if (oto.Id == id)
                {
                    return oto;
                }
            }
            return null;
        }

        static void HienThiDanhSach()
        {
            Console.WriteLine();
            foreach (var oto in otos)
            {
                Console.WriteLine("Thông tin xe:");
                oto.HienThi();
                Console.WriteLine("Thông tin động cơ xe:");
                oto.DongCo.HienThi();
                Console.WriteLine();

            }
            Console.WriteLine();
        }

    }
}
