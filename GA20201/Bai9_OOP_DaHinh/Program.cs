using System.Text;

namespace Bai9_OOP_DaHinh
{
    internal class Program
    {
        static List<Oto> otos = new List<Oto>()
        {
            new Oto(){Ma = "MEC1", Ten="Mecedes E300",NamSx=2024},
            new Oto(){Ma = "mec1", Ten="Mecedes G63",NamSx=2024},
            new Oto(){Ma = "Vin1", Ten="Vin vf8",NamSx=2024},
          
        };
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*  int sum = Add(3, 5);
              string concat = Add("3", "5");
              int sum3 = Add(3, 4, 2);
              Console.WriteLine($"{sum} Kiểu: {sum.GetType().Name}");
              Console.WriteLine($"{concat} Kiểu: {concat.GetType().Name}");*/
          /*  InRa("Chào các bạn");
            InRa(3);
            InRa(4.23);

            Oto oto = new Oto();
            oto.Chay();*/


        }

        static Oto TimOto(string ma)
        {
            foreach (var oto in otos)
            {
                if (oto.Ma.Equals(ma,StringComparison.OrdinalIgnoreCase))
                {
                    oto.HienThi();
                    return oto;
                }
            }
            return null;
        }

        static void CapNhat(Oto oto)
        {
            Oto updatedOto = TimOto(oto.Ma);
            if(updatedOto==null)
            {
                Console.WriteLine("Không tìm thấy xe");
                return;
            }

            updatedOto.NamSx = oto.NamSx;
            updatedOto.Ten = oto.Ten;
           
        }

        static void Xoa(string ma)
        {
            Oto deletedOto = TimOto(ma); //Sử dụng lại hàm tìm oto
            if (deletedOto == null)
            {
                Console.WriteLine("Không tìm thấy xe");
                return;
            }

            otos.Remove(deletedOto);
            Console.WriteLine("Xóa thành công");

        }



        //Cùng 1 phương thức nhưng có tham số khác nhau,hoặc kiểu trả về khác nhau
        //Thì được gọi là Nạp chồng (overloads)
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Add(int x,int y, int z)
        {
            return (x + y + z);
        }

        static string Add(string x, string y)
        {
            return x + y;
        }


        //Bài tập
        // Viết phương thức in ra tham số và kiểu của tham số có 3 overloads
        
        static void InRa(string mess)
        {
            Console.WriteLine($"In ra:{mess}, Kiểu: {mess.GetType().Name}");
        }

        static void InRa(int so)
        {
            Console.WriteLine($"In ra:{so}, Kiểu: {so.GetType().Name}");

        }

        static void InRa(double so)
        {
            Console.WriteLine($"In ra:{so}, Kiểu: {so.GetType().Name}");

        }
    }
}
