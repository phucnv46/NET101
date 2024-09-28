using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_KeThua
{
    internal class DongVat
    {
        public double ChieuCao { get; set; }

        public double CanNang { get; set; }

        public double TuoiTho { get; set; }

        public GioiTinh GioiTinh { get; set; }

        public string TenLoai { get; set; } = "Chưa xác định";

        public DongVat ThienDich { get; set; } = null;

        public string SinhSan()
        {
            return "Đẻ";
        }

        public void An()
        {
            Console.WriteLine("Chưa ro");
        }
        
    }



    public enum GioiTinh
    {
        Duc,Cai,LuongTinh
    }
    
}
