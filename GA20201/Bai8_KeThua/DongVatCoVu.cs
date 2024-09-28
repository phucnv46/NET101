using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_KeThua
{
    internal class DongVatCoVu : DongVat
    {
        public uint SoLuongVu { get; set; }

    }

    public enum Bo // Tập hợp các thuộc tính cố đinhj
    {
        GamNham,Doi,AnThit,LinhTruong,Eulipotyphla
    }
}
