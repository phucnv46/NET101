namespace Bai12_Delegate
{
    public delegate int TinhToan(int a, int b);

    public delegate bool DieuKien(int num);

   
    internal class Program
    {

        static List<int> numbers = new List<int>() { 3, 4, 2, -32, 23, 2, 5 };
        static void Main(string[] args)
        {
           /* InSoChan(XetDieuKien2);*/

            IEnumerable<int> list = numbers.MyWhere(
                x => x % 2 == 0
                );
            foreach (int i in list) 
            {
                Console.WriteLine(i);
            }
          
        }

        static bool XetDieuKien(int num)
        {
            if (num%2==0)
            {
                return true;
            }
            return false;
        }


        static bool XetDieuKien2(int num)
        {
            if (num >2)
            {
                return true;
            }
            return false;
        }


        static int Tong(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        static int Hieu(int a, int b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }

        static int Tich(int a, int b)
        {
            return a * b;
        }

        static void InSoChan(DieuKien dieuKien)
        {
            if (dieuKien != null)
            {
                foreach (var number in numbers)
                {
                    if (dieuKien(number))
                        Console.Write (number+ " ");
                }
            }
        }


    }
}
