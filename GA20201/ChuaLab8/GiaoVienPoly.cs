using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaLab8
{
    internal class GiaoVienPoly : GiaoVien
    {
		private string _nganhDay;

        public GiaoVienPoly(int id, string ten, double soGioDay, string nganhDay) : base(id,ten,soGioDay)
        {
            NganhDay = nganhDay;
        }

        public GiaoVienPoly()
        {
                
        }

        public string NganhDay
		{
			get { return _nganhDay; }
			set { _nganhDay = value; }
		}

        public override void InRaThongTin()
        {
            base.InRaThongTin();
            Console.Write($",Ngành dạy: {NganhDay}");
        }
    }
}
