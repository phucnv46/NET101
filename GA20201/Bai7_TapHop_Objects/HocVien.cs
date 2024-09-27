using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_TapHop_Objects
{
    internal class HocVien
    {
        public long MaHocVien { get; set; }
        public string HoTen { get; set; } = "Chưa nhập";

        public float Diem { get; set; } = 0;

        public string Email { get; set; } = "Chưa nhập";

        public string HocLuc
        {
            get
            {
                if (Diem < 3) return "Kém";
                else if (Diem >= 3 && Diem < 5) return "Yếu";
                else if (Diem >= 5 && Diem < 6.5) return "TB";
                else if (Diem >= 6.5 && Diem < 7.5) return "Khá";
                else if (Diem >= 7.5 && Diem < 9) return "Giỏi";
                else return "Xuất sắc";
            }

        }
    }
}
