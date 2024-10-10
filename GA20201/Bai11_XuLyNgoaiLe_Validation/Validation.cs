using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Bai11_XuLyNgoaiLe_Validation
{
    internal class Validation
    {
        public static int CheckInt(string mess, int min, int max) // Kiểm tra đầu vào của 1 chuỗi có phải số nguyên không
        {
            while (true)
            {
                int result = 0;
            intput: Console.Write(mess);
                string input = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(input)) // nếu nhập vào trống
                    {
                        Console.WriteLine("Nhập vào trống");
                        goto intput;
                    }
                    result = Convert.ToInt32(input);
                    if (result < min || result > max) // Kiểm soát cận trên, cận dưới
                    {
                        Console.WriteLine("Số nhập vào phải nhỏ hơn {0} và lớn hơn {1}", max, min);
                        goto intput;
                    }

                    return result;



                }
                catch (Exception e)
                {
                    Console.WriteLine("Xảy ra lỗi {0}", e.Message);

                }
            }

        }


        public static double CheckDouble(string mess, double min, double max) // Kiểm tra đầu vào của 1 chuỗi có phải số nguyên không
        {
            while (true)
            {
                double result = 0;
                Console.Write(mess);
                string input = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(input)) // nếu nhập vào trống
                    {
                        Console.WriteLine("Nhập vào trống");
                    }
                    result = Convert.ToDouble(input);
                    if (result < min || result > max) // Kiểm soát cận trên, cận dưới
                    {
                        Console.WriteLine("Số nhập vào phải nhỏ hơn {0} và lớn hơn {1}", max, min);
                    }
                    else
                    {
                        return result;
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Xảy ra lỗi {0}", e.Message);

                }
            }

        }

        public static string CheckEmail(string mess) // Kiểm tra nhập vào có phải email không
        {

            Regex emailPartend = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); // quy định mẫu string phải nhập vào
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                if (emailPartend.IsMatch(input))
                {
                    Console.WriteLine("Email đúng mẫu");
                    return input;
                }
                Console.WriteLine("Chưa đúng mẫu email!");
            }
        }



    }
}
