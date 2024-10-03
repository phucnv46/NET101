using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_OOP_TruuTuong
{
    internal class HinhChuNhat : Hinh2D
    {
        private double _chieuDai;

        public double ChieuDai
        {
            get { return _chieuDai; }
            set { _chieuDai = value; }
        }


        private double _chieuRong;

        public double ChieuRong
        {
            get { return _chieuRong; }
            set { _chieuRong = value; }
        }

        public override double TinhChuVi() //Bắt buộc phải ghi đè phương thức trừu tượng
        {
            return (ChieuDai + ChieuRong)*2;
        }

        public override double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Diện tích HCN:{TinhDienTich()}, Chu vi:{TinhChuVi()}");
        }
    }
}
