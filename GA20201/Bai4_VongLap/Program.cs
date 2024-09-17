using System.Text;

namespace Bai4_VongLap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //i++ == i=i+1
            /*for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(i+1);
            }*/

            /*  int num = 0;
              while (num < 30)
              {
                  num++;
                  Console.WriteLine(num);
              }
  */
            //do-while
            /* int num = 0;
             do
             {
                 num++;
                 Console.WriteLine(num);
             } while (num <30);*/

            // Dung lap in ra menu 

            for (;;)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----Menu---- \n 1.Trà đá \n 2.Nhân trần \n 3.La Hán \n 0.Exit ");
                    Console.Write("Xin mời lựa chọn: ");
                    uint doUong = Convert.ToUInt32(Console.ReadLine());

                    switch (doUong)
                    {
                        case 1: Console.WriteLine("Trà đá"); break;
                        case 2: Console.WriteLine("Nhân trần"); break;
                        case 3: Console.WriteLine("La Hán"); break;
                        case 0: return;
                        default: Console.WriteLine("Không có trong menu"); break;

                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Chỉ được nhập số!");
                }
            }

            //Bt: Viết menu cho TaiXiu, Chuyen Kenh, ChanLe, TraDa


        }
    }
}
