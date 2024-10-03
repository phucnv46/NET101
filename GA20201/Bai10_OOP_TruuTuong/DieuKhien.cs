using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_OOP_TruuTuong
{
    internal class DieuKhien
    {
        private readonly Hinh2D _hinh2D;

        public DieuKhien(Hinh2D hinh2D)
        {
            _hinh2D = hinh2D;
        }

        public void HienThi()
        {
            _hinh2D.HienThi();
        }
    }
}
