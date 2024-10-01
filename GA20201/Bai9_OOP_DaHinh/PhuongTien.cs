using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_OOP_DaHinh
{
    internal class PhuongTien
    {
        public virtual void Chay() // Sử dụng từ khóa virtual để xác định phương thức sẽ b
            //ghi đè trong tương lại, nếu không ghi đè sử dụng khai báo mặc định
           
        {
            Console.WriteLine("Phương tiện đang chạy");
        }
    }
}
