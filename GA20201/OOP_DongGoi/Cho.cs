using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DongGoi
{
    internal class Cho
    {
		private double _canNang;

		public double CanNang
		{
			get { return _canNang; }
			set { _canNang = value; }
		}

		private string _mauLong;

		public string MauLong
		{
			get { return _mauLong; }
			set { _mauLong = value; }
		}

		private bool _gender;

		public bool Gender
		{
			get { return _gender; }
			set { _gender = value; }
		}

		public double ChieuCao { get; set; }

		private DateTime _namSinh;

		public DateTime NamSinh
		{
			get { return _namSinh; }
			set { _namSinh = value; }
		}

		public string Ten { get; set; } = "Chưa đặt";

        public void Chay()
		{
            Console.WriteLine("Chó đang chạy");
        }

		internal void Sua()
		{
            Console.WriteLine("Gâu gâu "+ Ten);
        }


	}
}
