using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_OOP_TruuTuong
{
    internal class ChimTroi : IFlyable,IChay // Có thể implement nhiều interface
    {
        public void Bay()
        {
            Console.WriteLine("Chim vỗ cánh");
        }

        public void Chay()
        {
            Console.WriteLine("Chạy bằng chân");
        }
    }
}
