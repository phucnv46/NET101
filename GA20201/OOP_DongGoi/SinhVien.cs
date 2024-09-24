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
                return Ho + Ten;
            }
        }

        public DateTime NgaySinh { get; set; }  // Datetime kiểu biểu diễn thời gian

        public int Tuoi {

            get
            {
                return DateTime.Now.Year - NgaySinh.Year; // Năm hiện tại -Năm Sinh
            }

        }

        


    }
}
