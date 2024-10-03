using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_OOP_TruuTuong
{
    internal class MayBay : IFlyable,IChay
    {
        public void Bay()
        {
            Console.WriteLine("Bay bằng động cơ");
        }

        public void Chay()
        {
            Console.WriteLine("Lăn bánh");
        }
    }
}
