using System.Text;

namespace Bai8_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NguoiDaVang nguoiVietNam = new NguoiDaVang();
            nguoiVietNam.Ten = "Phuc";
            nguoiVietNam.CanNang = 86.5;
            nguoiVietNam.ChieuCao = 181;
            nguoiVietNam.Noi();
            nguoiVietNam.NauAn();


            //Bài tập luyện tập
            // DongVat , DongVatCoVu : DongVat, Cho : DongVatCoVu

            Cho cho = new Cho();
            cho.CanNang = 30;
            cho.ChieuCao = 1.53;
            cho.TuoiTho = 20;
            cho.GioiTinh = GioiTinh.Duc;
            cho.ThienDich = null;
            cho.TenLoai = "Chó";
            cho.Bo = Bo.AnThit;
            cho.Ten = "Trump";
            cho.SoLuongVu = 8;

            cho.HienThi();

            ChoCon choCon = new();
            string ss= choCon.SinhSan();
            Console.WriteLine(ss);
        }
    }
}
