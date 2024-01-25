using System;
using System.Threading.Channels;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cách 1: Ko dùng biến
            //Console.Write("Moi ban nhap ten: ");
            //Console.WriteLine("Ten cua ban la: ", Console.ReadLine());
            //Console.Write("Moi ban tuoi: ");
            //Console.WriteLine("Tuoi cua ban la:", Console.ReadLine());
            //Console.Write("Moi ban nhap ngay sinh: ");
            //Console.WriteLine("Ngay sinh cua ban la: ", Console.ReadLine());

            //Cách 2: Dùng biến
            /*Console.Write("Moi ban nhap ten: ");
            string ten = Convert.ToString(Console.ReadLine());

            Console.Write("Moi ban nhap tuoi: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());


            Console.Write("Moi nhap diem so: ");
            float diem = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Ten cua ban la: " + ten);
            Console.WriteLine("Ten cua ban la: " + tuoi);
            Console.WriteLine("Diem cua ban la: " + diem);
            */



            //Ép kiểu và thao tác với biến 
            Console.Write("Nhap 1 so de kiem tra: ");
            string strSoNguyen = Console.ReadLine();
            int soNguyen = Convert.ToInt32(strSoNguyen);
            string KetQua = (soNguyen % 2 == 0) ? "so chan" : "so le";

            Console.WriteLine("{0} la {1}", soNguyen, KetQua);

            Console.Write("Nhap 1 so de kiem tra: ");
            string strSoNguyen1 = Console.ReadLine();
            int soNguyen1 = Convert.ToInt32(strSoNguyen1);
            string KetQua1 = (soNguyen1 % 2 == 0) ? "so chan" : "so le";

            //Console.WriteLine("{0} la {1}", soNguyen1, KetQua1);
            //Console.WriteLine(soNguyen1 + " la " + KetQua1);

        }
    }
}