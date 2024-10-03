using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_OOP_TruuTuong
{
    internal class DieuKhienBay
    {
        public IFlyable UFO { get; set; } // Đại diện cho những class triển khai interface này
        // Iflyable được triển khai bởi ChimTroi, Maybay, TenLua

        public void Bay()
        {
            if (UFO == null)
            {
                Console.WriteLine("Chưa có đối tượng bay");
            }
            UFO.Bay();
        }
    }
}
