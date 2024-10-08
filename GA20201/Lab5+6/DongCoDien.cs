using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6
{
    internal class DongCoDien : DongCo
    {
        public override void HienThi()
        {
            Console.WriteLine($"Động cơ Điện Id:{Id}, Tên động cơ: {Ten} , Trạng thái: {TrangThai}");
        }

        public override void KhoiDong()
        {
            TrangThai = true;
            Console.WriteLine("Khởi động động cơ Điện");
        }

        public override void TatDongCo()
        {
            TrangThai = false;
            Console.WriteLine("Tắt động cơ điện");
        }
    }
}
