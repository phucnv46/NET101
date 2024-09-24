using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DongGoi
{
    internal class HinhChuNhat
    {
		private double _chieuDai;
		
		public double ChieuDai
		{
			get {return _chieuDai; }
			set { _chieuDai = value; }
		}

		private double _chieuRong;


        public double ChieuRong
		{
			get { return _chieuRong; }
            set { _chieuRong = value; }
		}

		public void HienThi()
		{
			double temp;
			if(ChieuDai < ChieuRong)
			{
				temp = ChieuDai;
				ChieuDai = _chieuRong;
				ChieuRong = temp;
			}
            Console.WriteLine("Chiều dài là: {0}, Chiều rộng là: {1}", ChieuDai, ChieuRong);
        }

		public double ChuVi()
		{
			return (ChieuDai + ChieuRong) * 2;
		}

        public double DienTich()
        {
			return ChieuDai * ChieuRong;
        }


    }
}
