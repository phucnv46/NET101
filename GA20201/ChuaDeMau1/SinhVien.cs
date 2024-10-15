using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeMau1
{
    internal class SinhVien
    {
		private string _maSV;

		public string MaSV
		{
			get { return _maSV; }
			set { _maSV = value; }
		}

		private string _ten;

		public string Ten
		{
			get { return _ten; }
			set { _ten = value; }
		}

		private int _namSinh;

        public SinhVien(string maSV, string ten, int namSinh)
        {
            _maSV = maSV;
            _ten = ten;
            _namSinh = namSinh;
        }


        public SinhVien()
        {
            
        }

        public int NamSinh
		{
			get { return _namSinh; }
			set { _namSinh = value; }
		}

		public virtual void InThongTin()
		{
            Console.Write("Mã sinh viên: {1},Tên {0},Năm Sinh {2}",Ten,MaSV,NamSinh);
        }



	}
}
