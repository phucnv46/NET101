using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_OOP_TruuTuong
{
    internal class HinhTron : Hinh2D
    {
        private double _banKinh;

        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }

        public override double TinhChuVi() // Đã sử dụng từ khóa abstract chắc chắn phải overide
        {
            return BanKinh * 2 * Math.PI;
        }

        public override double TinhDienTich()
        {
                return BanKinh*BanKinh*Math.PI;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Chu vi hình tròn: {TinhChuVi()}, Diện tích hình tròn: {TinhDienTich()}");
        }


    }
}
