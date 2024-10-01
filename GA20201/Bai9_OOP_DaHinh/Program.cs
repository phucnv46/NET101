using System.Text;

namespace Bai9_OOP_DaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*  int sum = Add(3, 5);
              string concat = Add("3", "5");
              int sum3 = Add(3, 4, 2);
              Console.WriteLine($"{sum} Kiểu: {sum.GetType().Name}");
              Console.WriteLine($"{concat} Kiểu: {concat.GetType().Name}");*/
            InRa("Chào các bạn");
            InRa(3);
            InRa(4.23);

            Oto oto = new Oto();
            oto.Chay();
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
