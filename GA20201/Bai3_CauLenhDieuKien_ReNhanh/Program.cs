using System.Text;

namespace Bai3_CauLenhDieuKien_ReNhanh
{
    internal class Program
    {
        /*
         P1: Cấu trúc điều kiện (if -else if -else) 
         == : So sánh bằng (bằng nhau) VD: 2 == 4:2
         != : So sánh khác (không bằng ) VD: 3 != 4
        > : Lớn hơn  VD 6 > 3 (true)
        < : nhỏ hơn VD 9 < 6 (false)
         >= : Lớn hơn  VD 6 >= 3 (true)
        <= : nhỏ hơn hoặc bằng VD 9 < 6 (false)
        && : true && true => true, true && false => false
        ||: true && false => true, ...
         Toán tử 3 ngôi
         P2: Cấu trúc rẽ nhánh (switch -case)
         
         */
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            /*int dayOfWeek = 5;
            if (dayOfWeek > 2)
            {
                Console.WriteLine("Monday");
            }if (dayOfWeek > 4)
            {
                Console.WriteLine("Wesday");
            }
            else if (dayOfWeek > 3) // Khi mà có 1 điều kiện thỏa mãn sẽ không xét các điều kiên khác nữa
            {
                Console.WriteLine("Tuesday");
            }
            if(dayOfWeek > 2 && dayOfWeek <6)
            {
                Console.WriteLine("Else");
            }

            bool gender = false;  // true cho nam, false cho nu
            if (gender!=true)
            {
                Console.WriteLine("Nữ");
            }
            else
            {
                Console.WriteLine("Nam");
            }
            // Toán tử 3 ngôi:
            string sex = gender == true ? "Nam" : "Nữ";
            Console.WriteLine(sex);*/


            // Bài tập
            // Viết điều kiện cho tài - xỉu 
            // xỉu <=9  (3-9)  
            // tài >=10 (10-18)

            TaiXiu();

            // Bài 2:
            // Khai báo 1 số kiểm tra số đấy có là số lẻ hay chẵn ( 3 ngôi )
            // % chai lấy dư
            // số chẵn % 2 == 0

            ChanLe();

            //P2 : Cấu trúc rẽ nhánh

            ChuyenKenh();

            //Bài tập
            /*
             * In ra 1 cái menu lựa chọn đồ uống Trà đá, nước vối, me , ...
             * Viết switch case in ra lựa chọn đồ uống
             * */
            Menu();

            

        }

        static void TaiXiu()
        {

            Console.WriteLine("Xin mời nhập tổng điểm:");
            uint tongDiem = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Bạn vừa nhập {0}", tongDiem);

            if (tongDiem < 3 || tongDiem > 18)
            {
                return;
            }
            if (tongDiem >= 3 && tongDiem < 10)
            {
                Console.WriteLine("Xỉu");
            }
            else
            {
                Console.WriteLine("Tài");
            }
        }

        static void ChanLe()
        {
            Console.Write("Xin mời nhập số: ");
            uint num = Convert.ToUInt32(Console.ReadLine());
            string chanLe = num % 2 == 0 ? "Chẵn" : "Lẻ";
            Console.WriteLine($"Số này là số {chanLe}");
        }

        static void ChuyenKenh()
        {
            Console.Write("Xin mời nhập kênh: ");
            uint kenh = Convert.ToUInt32(Console.ReadLine());
            switch (kenh)
            {
                case 1:
                    Console.WriteLine("VTV1");// nếu chọn 1 sẽ đi đến VTV 1
                    break;
                case 2:
                    Console.WriteLine("VTV2");
                    break;
                case 3:
                    Console.WriteLine("VTV3");
                    break;
                default:
                    Console.WriteLine("Không bắt được sóng");
                    break;
            }
        }

        static void Menu()
        {
            Console.WriteLine("----Menu---- \n 1.Trà đá \n 2.Nhân trần \n 3.La Hán \n 0.Exit ");
            Console.Write("Xin mời lựa chọn: ");
            uint doUong = Convert.ToUInt32(Console.ReadLine());

            switch (doUong)
            {
                case 1: Console.WriteLine("Trà đá"); break;
                case 2: Console.WriteLine("Nhân trần"); break;
                case 3: Console.WriteLine("La Hán"); break;
                case 0: return;
                default: Console.WriteLine("Không có trong menu"); break;

            }
        }
    }

}


