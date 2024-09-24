using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DongGoi
{
    /*Tính chất đóng gói
	 Mô tả các đặc điểm của đói tươngj
	 
	 */
    internal class SinhVien
    {
        private string _maSV; // Trường thông tin

        public string MaSV // Thuộc tính
        {
            get { return "PH" + _maSV; }  // Giá trị sẽ trả về của thuộc tính
            set { _maSV = value; } // value là thuộc tính sẽ được nhận giá trị gán vào
        }

        public string Ho { get; set; } = "Chưa rõ"; // Khởi tạo giá trị

        public string Ten { get; set; } = "Chưa rõ";

        public string HoVaTen
        {

            get
            {
                return Ho +" "+ Ten;
            }
        }

        public DateTime NgaySinh { get; set; }  // Datetime kiểu biểu diễn thời gian

        public int Tuoi {

            get
            {
                return DateTime.Now.Year - NgaySinh.Year; // Năm hiện tại -Năm Sinh
            }

        }

        private double _diem;


        public double Diem
        {
            get { return _diem; }
            set { _diem = value; }
        }

        public string HocLuc { 
            get
            {
                if (Diem >= 9) { return "Xuất sắc"; }
                else if (Diem>=7.5) { return "Giỏi"; }
                else if (Diem >= 5 && Diem <= 6.5) { return "Trung bình"; }
                else if(Diem>=5 && Diem<= 6.5) { return "Trung bình"; }
                return "Yếu";
            }
                }


        // Hành vi - Phương thức

        public void XinChao()
        {
            Console.WriteLine("Xin chào, Tôi là {0}",HoVaTen);
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("Thông tin sinh viên");
            Console.WriteLine("Mã SV :{0} \nHọ và tên: {1}\nNgày sinh:{2:d} \nTuổi:{3}"
                ,MaSV,HoVaTen,NgaySinh,Tuoi);

        }


    }
}
