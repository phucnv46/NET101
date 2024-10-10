using System.Numerics;
using System.Reflection;
using System.Text;

namespace BaiFinal_Generics_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*Add(1, 2.5);
            double total = Total(3,2.5,5);
            int totalInt = Total(2,2,2,5,6,2,34,5);
            Console.WriteLine(totalInt);
*/
            //Bt viết hàm generics tích nhiều số

            /*  Validation.GetValidNumber("Xin mời nhập số: ", 0, 10);*/

            /*PropertyInfo[] properties = typeof(Person).GetProperties();
            
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
        */
            Person person = new Person();
            ReflectionHelper.SetProperties(person);
            ReflectionHelper.InRaThuocTinh(person);
        }

        //Giải pháp dùng <>

        static A Add<A>(A a, A b) where A : INumber<A>
        {
            return a + b;
        }


        static T Total<T>(params T[] numbers) where T : INumber<T>
        {
            T sum = T.Zero;
            foreach (T t in numbers)
            {
                sum += t;
            }
            return sum;
        }

      /*  static int Add(int x, int y)  // Các hàm giống nhau
        {
            return x + y;
        }

        static uint Add(uint x, uint y)
        {
            return x + y;
        }


        static double Add(double x, double y)
        {
            return x + y;
        }*/


    }
}
