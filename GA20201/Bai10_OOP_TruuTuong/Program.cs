using Bai10_OOP_TruuTuong.Start;
using System.Text;

namespace Bai10_OOP_TruuTuong
{
    internal class Program
    {
        //Trừu tượng là phương thức, tính chất không cần định nghia cụ thể
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /* HinhChuNhat hcn = new HinhChuNhat() { ChieuDai =7, ChieuRong = 3.5};
             HinhTron hinhTron = new HinhTron() { BanKinh = 6 };

             DieuKhien dieuKhien = new DieuKhien(hinhTron);  // Lựa chọn phụ thuộc trong thời điểm thực thi
             dieuKhien.HienThi();*/


            /*DieuKhienBay dieuKhienBay = new DieuKhienBay();
            ChimTroi  chim = new ChimTroi();
            MayBay airBus = new MayBay();

            dieuKhienBay.UFO = airBus;
            dieuKhienBay.Bay();*/

            //Tạo interface IStartable có method Start() : void
            //Implement cho các lớp tương ứng: DongCo, CuocThi, MayTinh, Game, ....
            //Tạo class điều khiển việc khởi động

            Console.WriteLine("Chọn thứ muốn khởi động: \n0.Động cơ" +
                "\n1.Cuộc thi" +
                "\n2.Máy tính" 
                );
            Console.Write("Xin mời: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            IStartable startable = GetStartable(choice);
            if(startable == null) {
                return;
            }
            CongTac congTac = new CongTac(startable);
            congTac.Bat();
        }


        //Mẫu thiết kế (Design Partern Factory)
        public static IStartable GetStartable(int choice = 0)
        {
            if (choice == 0)
            {
                return new DongCo();
            }
            else if(choice == 1)
            {
                return new CuocThi();
            }else if(choice == 2)
            {
                return new MayTinh();
            }
            
            return null;
        }
    }
}
