using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_OOP_TruuTuong
{
    internal abstract class Hinh2D  // Lớp trừu tượng
    {
       
        public abstract double TinhChuVi(); // Phương thức trừu tượng kết thúc bằng dấu ;

        public abstract double TinhDienTich();

        public virtual void HienThi() 
        {
        }
    }
}
