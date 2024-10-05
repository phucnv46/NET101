using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6
{
    internal class DongCoXang : DongCo
    {
        public override void HienThi()
        {
            Console.WriteLine($"Id:{Id}, Tên động cơ: {Ten} , Trạng thái: {TrangThai}");
        }

        public override void KhoiDong()
        {
            TrangThai = true;
            Console.WriteLine("Khởi động động cơ xăng");
        }

        public override void TatDongCo()
        {
            TrangThai = false;
            Console.WriteLine("Tắt động cơ xăng");
        }
    }
}
