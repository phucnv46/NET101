using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TapHop_PhuongThuc
{
    internal class Program
    {

/*
 P1: Tập hợp
 -Mảng : <Kiểu dữ liêu>[] <Tên biến> = new <Kiểu dữ liêu>[số lượng phần tử]  { các phần tử }
  Là kiểu tập hợp cố định kiểu phần tử
- Danh sách
-ArrayList
-Dictionary

 P2: Phương thức (hàm)
 -Hàm có trả về
-hàm không trả về
- Hàm có hoặc không tham số
-Tham số optional
-Từ khóa params
 */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Mảng
            int[] numbers = new int[10]; // index 0-9
            int[] numbers2 = {1,2,3,4,2};

            numbers[0] = 5;
            numbers[1] = 6;
            numbers[5] = 7;
          //  Console.WriteLine(numbers2[7]); // Index ngoài giới hạn của array

            //Danh sách
            List<double> reals = new List<double>();
          
            reals.Add(-7);
            reals.Add(12);
            reals.Add(3);
            reals.Add(-25);
            reals.Add(142);
            reals.Add(-34);

            //Console.WriteLine("Số lượng phần tử của danh sách {0}", reals.Count);

            /*   foreach (double d in reals) // Vòng lặp duyệt qua tất cả phần tử trong mảng
               {
                   if(d < 0) Console.WriteLine(d);
               }*/

            /*reals.Sort(delegate(double a, double b)
            {
                return b.CompareTo(a);
            } 
            );

            Console.WriteLine("Danh sách theo thứ tự giảm dần:");

            foreach (double d in reals)
            {
                Console.Write($"{d} ");
            }*/

            // Bài tập 
            // Bài 1: Khai báo 1 mảng và in ra các số chẵn

            uint[] sos = {4,52,47,31,17,86,42,11};

            //C1:
            /* Console.WriteLine("Các số chẵn trong mảng là:");*/
            /*  foreach (uint so in sos)
              {
                  if (so%2==0) Console.Write($"{so} ");
              }*/

            //C2:
            /*  for (int i = 0; i < sos.Length; i++) 
              {
                  if (sos[i] % 2 != 0) continue; // Bỏ qua các số lẻ
                  Console.Write($"{sos[i]} "); // Còn lại số chẵn
              }*/

            // Bài 2: Khai báo 1 danh sách số thực
            //  sắp xếp và in ra số lớn nhất

            /* List<double> soThucs = new List<double>() { 12,3,42,-231,-32 };

             Console.WriteLine("Danh sách số thực");
             foreach (int so in soThucs)
             {
                 Console.Write(so+" ");
             }

             soThucs.Sort();

             Console.WriteLine("\nSố nhỏ nhất trong danh sách {0}",soThucs[0]);

             // Dictionary
             Dictionary<int, string> idTens = new Dictionary<int, string>() // Danh sách dạng chìa - khóa
             {
                 {1,"Nguyễn Văn Phúc"} , {452,"Công Phượng"}
             }
                 ;
             Console.WriteLine(Tong2So(3,-6));
             SayHello();*/

            //Bài tập in ra số nhỏ nhất trong mảng
            int[] sos2 = {4,-2,-12,-23,9,10};

            /*  int min = sos2[0];
              foreach (int i in sos2) 
              {
                  if (min>i)
                  {
                      min = i;
                  }
              }
              Console.WriteLine("Số nhỏ nhất là {0}", min);*/

           Min(3, 34, 5, -45, -78,4,5,6,7,5,5);

           //Arraylist  // List không ràng buộc về kiểu
           ArrayList list = new ArrayList() { "1",1,-2.3};

           //Bài tập
           //1.Viết hàm max sử dụng params
           //2. Viết hàm tính tổng các số chẵn sử dụng params
           
        }

        static int Tong2So(int a,int b)  // Hàm có trả về có tham số
        {
            return a + b;
        }

        static void SayHello(string ten="Tên Mặc Định") // Tham số optional , nêu không truyền tham số sẽ sử dụng khởi tạo
        {
            Console.WriteLine("Hello {0}", ten);
        }

        static int Min(params int[] numbers) 
            // Từ khóa params cho phép chuyển vào không giới hạn số lượng tham số cùng loại
        {
            int min = numbers[0];
            foreach (int i in numbers)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            Console.WriteLine("Số nhỏ nhất là {0}", min);
            return min;
        }



    }
}
