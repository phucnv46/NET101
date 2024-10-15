using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeMau1
{
    internal class SinhVienUDPM : SinhVien
    {
        
        private double _diemJava;

        public double DiemJava
        {
            get { return _diemJava; }
            set { _diemJava = value; }
        }
        
        private double _diemCSharp;

        public double DiemCSharp
        {
            get { return _diemCSharp; }
            set { _diemCSharp = value; }
        }

        public SinhVienUDPM(string maSV,string ten,int namSinh,double diemJava,double diemCSharp) : base(maSV,ten,namSinh)
        {
        
        }

        public SinhVienUDPM()
        {
            
        }

        public override void InThongTin()
        {
            base.InThongTin();
            System.Console.Write($" ,Điểm java: {DiemJava},Điểm CSharp: {DiemCSharp}");
        }
    }
}
