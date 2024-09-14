using System.Runtime;
using System.Text;

namespace Bai2_Input_ChuyenDoiKieuDuLieu
{
    internal class Program
    {
        /*
        * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
        *
        * Công thức ép kiểu tường minh:
        *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
        *
        * P2: 
        * Chuyển đổi từ string về số
        *  + Phương thức Parse()
        *  + Lớp Convert()
        * Chuyển đổi từ kiểu số về string
        * Sử dụng phương thức toString hoặc + ""
        * 
        * P3: Chuyển kiểu giá trị sang tham chiếu và ngược lại
        * +Boxing: Giá trị sang tham chiếu
        * +Unboxing: tham chiếu sang giá trị
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //PHẦN 1: ÉP KIỂU GIỮA CÁC SỐ
            //ép kiểu ngầm định
            int a = 12;
            double b = a;
            //cw tab
            Console.WriteLine($"a= {a}, kiểu của a: {a.GetType().Name}");
            Console.WriteLine($"b= {b}, kiểu của b: {b.GetType().Name} ");

            //ép kiểu tường minh (casting)
            double c = 9.3;
            int d = (int)c;
            Console.WriteLine($"c= {c}");
            Console.WriteLine($"d= {d}");

            //PHẦN 2: ÉP KIỂU từ STRING về SỐ

            //Để đọc 1 chuỗi các ký tự từ bàn phím ta sử dụng Console.ReadLine()
            Console.WriteLine("Xin mời nhập: ");
            string input = Console.ReadLine(); // Kiểu trả về sau khi thực hiện câu lệnh sẽ là string
            Console.WriteLine("Bạn vừa nhập {0} từ bàn phím!",input);
            string number1 = "8";
            string number2 = "10";
            Console.WriteLine(number1 + number2); // kết quả là 810 thay vì 18 vì đây là string

            //int.Parse => nếu string null => ArgumentNullException:
            int n1 = int.Parse(number1); 
            //Convert.ToInt32 => nếu string là null 
            //=> nhận giá trị mặc định của kiểu dữ liệu vd =0
            int n2 = Convert.ToInt32(number2); // Int32 tương đương với int (32bit)

            Console.WriteLine(n1+n2); // kết quả là 18 vì là kiểu số

            //Đổi từ số sang string 
            string s1 = n1.ToString();
            string s2 = n2 + "";

            Console.WriteLine(s1+s2); //810 vì là kiểu strubg
            /*            *P3: Chuyển kiểu giá trị sang tham chiếu và ngược lại
             *            
             *            Giá trị sang tham chiếu
            */
            int giaTri = -92; // Kiểu giá trị
            object thamChieu = giaTri; // Kiểu tham chiếu

            // Tham chiếu sang giá trị
            object thamChieu1 = 123;// kiểu tham chiếu
            uint giaTri1 = (uint)thamChieu1; // Kiểu giá trị

        
        }
    }
}
