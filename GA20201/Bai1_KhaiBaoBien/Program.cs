using System.Text;

namespace Bai1_KhaiBaoBien
{
    internal class Program
    {
        /*
        * Bài 1.1 Khai báo biến
        * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến được khởi tạo trong bộ nhớ ảo khi chương trình khởi chạy.
        *
        * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
        *      Khai báo nhiều biến có cùng kiểu dữ liệu trên cùng 1 dòng:
        *      <Kiểu dữ liệu> <Tên Biến1> = <Giá trị>, <Tên Biến2> = <Giá trị>, <tên biến n>;
        * 1. <Kiểu dữ liệu> 
        *  + Số nguyên:sbyte, byte, long, int
        *  + Sô thực: float, double, decimal
        *  + Số nguyên không có dấu (dương) : uint, ushort, ulong
        *  + Chuỗi hoặc ký tự: string, char
        *  + Logic: bool
        *  +object: kiểu dữ liệu cha của mọi kiểu dữ liệu, có thể biến đổi thành các kiểu dữ liệu khác qua unboxing
        *  + var: Kiểu khai báo ngầm định, kiểu dữ liệu được xác định theo kiểu dữ liệu khởi tạo (gán)
        * 2. <Tên Biến>
        *  + Quy tắc:
        *      - Tên biến phải có nghĩa
        *      - Có phân biệt chữ hoa chữ thường
        *      - Không bắt đầu bởi số, không dùng từ khóa
        *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
        *  + Khai báo tên biến với 2 từ trở lên:
        *      - Cách 1: normal = firstname
        *      - Cách 2: CamelCase = FirstName, firstName
        *      - Cách 3: Under_Score = first_name, first_Name (hay còn gọi là snake_case)
        *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
        *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
        *      - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến.
        *      - int _year = 1989;
        * 3.<Giá trị>
        *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
        *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
        *
        */
        //biến toàn cục
        static int _namSinh = 2006;
        static void Main(string[] args)
        {
            //gõ được tiếng việt
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //biến cục bộ
            int a;
            int b = 5;

            double diem = 8.2;
            float chieuCao = 152, can;
            uint nam_sinh = 2004;
           

            char c = 'H'; // 1 ký tự
            //char[] hoTen;
            string hoTen = "Peter Pan";

            bool isBoy = true; //true- nam, false- nữ


            var soNguyen = 50; // Gán là kiểu số nguyên  => int
            var soThuc = 3.5; // Khởi tạo là số thực => double
            object logic = false;
            // object có thể đại diện cho mọi kiểu dữ liệu, nhưng nên hạn chế sử dụng vì
            // sẽ giảm hiệu xuất và tính rõ ràng
          
            // Các cách để chỉnh format in ra 
            Console.WriteLine(hoTen); // cách viết nhanh Console.WriteLine() => cw Tab
            Console.WriteLine("Tên tôi là: " + hoTen + " cao: " + chieuCao);  // Sử dụng dấu +
            Console.WriteLine($"Tên tôi là: {hoTen} cao {chieuCao}"); // Thêm $ rồi truyền các biến vào string
            Console.WriteLine("Tuổi là: {0}",DateTime.Now.Year - nam_sinh); // Sử dụng Formater của string
           
        }

    }
}
