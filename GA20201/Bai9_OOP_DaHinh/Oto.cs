using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_OOP_DaHinh
{
    internal class Oto : PhuongTien
    {
        public string Ten { get; set; } = "Chưa rõ";

        public int NamSx { get; set; }
        public override void Chay() // Ghi đè lên phương thức chạy
        {
            Console.WriteLine("Chạy bằng Oto");
        }

        public void HienThi()
        {
            Console.WriteLine($"Mã:{Ma}, Tên:{Ten}, Năm Sx: {NamSx}");
        }
    }
}
