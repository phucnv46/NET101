using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6
{
    internal class Oto
    {
        public long Id { get; set; }

        public string Ten { get; set; }

        public int NamSX { get; set; }

        public DongCo DongCo { get; set; }

        public void Chay()
        {
            if(DongCo != null &&  DongCo is DongCoXang)
            {
                Console.WriteLine("Chạy bằng động cơ xăng");
            }
            else if(DongCo == null)
            {
                Console.WriteLine("Chưa có động cơ");
            }
            else
            {
                Console.WriteLine("Chạy bằng động cơ điện");
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"Id:{Id}, Tên: {Ten}, Năm SX :{NamSX}");
            
        }
    }
}
