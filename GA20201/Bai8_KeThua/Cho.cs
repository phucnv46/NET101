using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_KeThua
{
    internal class Cho : DongVatCoVu
    {

        public string Ten { get; set; } = "Chưa đặt";

        public string GiongCho { get; set; } = "Chó cỏ";


        public new string SinhSan() 
        {
            return "Đẻ con";
        }

        public new void An()
        {
            Console.WriteLine("Chó ăn xương,ăn cơm, ăn thịt");
        }

        public void HienThi()
        {
            Console.WriteLine($"Tên:{Ten}, Chiều cao:{ChieuCao} " +
                $",Cân nặng{CanNang},Số lượng vú {SoLuongVu}" +
                $", Cách sinh sản:{SinhSan()}," +
                $" Tuổi thọ {TuoiTho} " +
                $",Thuộc bộ {Bo}");
        }

        public Bo Bo { get; set; }



    }
}
