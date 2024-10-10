using System.Text;
using System.IO;

namespace Bai11_XuLyNgoaiLe_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a =  Validation.CheckInt("Xin mời nhập số nguyên:", int.MinValue, int.MaxValue);
            string email = Validation.CheckEmail("Xin mời nhập email: ");
            Math.Min(1, 2);

            /*   string path = "../../../test.txt";
               string content = "Xin chào\n Thêm 1 dòng";

               Console.WriteLine(Path.GetFullPath(path));

               File.WriteAllText(path, content);
               string read = File.ReadAllText(path);

               Console.WriteLine(read);*/
        }
    }
}
