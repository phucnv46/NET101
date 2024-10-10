using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BaiFinal_Generics_Reflection
{
    internal class Validation
    {
        public static TNumber GetValidNumber<TNumber>(string mess,TNumber min, TNumber max) where TNumber : INumber<TNumber>
        {
            while (true)
            {
                Console.Write(mess);
                string input = Console.ReadLine();
                TNumber result;
                try
                {
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Bạn chưa nhập vào!");
                    }
                    result = (TNumber) Convert.ChangeType(input,typeof(TNumber));
                    if (result < min || result > max)
                    {
                        Console.WriteLine("Số phải trong khoảng {0}- {1}", min , max);
                    }
                    else
                    {
                         return result;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Số nhập vào không hợp lệ!");
                }
                
                
            }
        }
    }
}
