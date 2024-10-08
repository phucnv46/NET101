using System.Text;

namespace Bai11_XuLyNgoaiLe_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*int a = Validation.CheckInt("Xin mời nhập số nguyên:",int.MinValue, int.MaxValue);*/
            string email = Validation.CheckEmail("Xin mời nhập email: ");
        }
    }
}
