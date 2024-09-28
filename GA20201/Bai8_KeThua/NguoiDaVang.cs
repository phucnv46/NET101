using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_KeThua
{
    internal class NguoiDaVang : ConNguoi
    {
        public string MauDa { get; set; } //Cú pháp viết hoa các chữ cái đầu tiên của thuộc tính

        public new void Noi() //Pascal
        {
            base.Noi(); // Gọi lại phương thức nói ở lớp con người
            Console.WriteLine("Người Việt Nam nói: Xin chào các bạn! "); // Định nghĩa thêm phương thức nói
        }

        public new void NauAn() // Định nghĩa phương thức nấu ăn mới
        {
            Console.WriteLine("Nấu phở"); 
        }
    }
}
