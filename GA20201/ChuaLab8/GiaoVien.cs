using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaLab8
{
    internal class GiaoVien
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _ten;

		public string Ten
		{
			get { return _ten; }
			set { _ten = value; }
		}

		private double _soGioDay;

        public GiaoVien(int id, string ten, double soGioDay)
        {
            _id = id;
            _ten = ten;
            _soGioDay = soGioDay;
        }
        public GiaoVien()
        {
				
        }

        public double SoGioDay
		{
			get { return _soGioDay; }
			set { _soGioDay = value; }
		}

		 public virtual void InRaThongTin()
		{
            Console.WriteLine("Id:{0}, Tên:{1}, Số giờ dậy:{2}",ID,Ten,SoGioDay);
        }



	}
}
