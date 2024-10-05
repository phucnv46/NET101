using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6
{
    internal abstract class DongCo
    {
        public long Id { get; set; }

        public string Ten { get; set; }

        public bool TrangThai { get; set; } = false;

        public abstract void KhoiDong();

        public abstract void TatDongCo();

        public abstract void HienThi();
        

        
    }
}
