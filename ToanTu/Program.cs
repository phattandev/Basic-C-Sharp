using System;
using System.Collections.Specialized;
using System.Threading.Channels;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[6];
            for (int i = 0; i < x.Length; i++)
            {
                //Loi neu nhap chu
                //Console.Write("Nhap phan tu " + i + ": ");
                //string z = Console.ReadLine();
                //x[i] = Convert.ToInt32(z);

                //Ok roi nhung nhap sai la skip so do luon
                //Console.Write("Nhap phan tu " + i + ": ");
                //string z = Console.ReadLine();
                //if (int.TryParse(z, out x[i]) == false)
                //{
                //    Console.WriteLine("Nhap sai!!!");
                //}

                //toi uu
                string z;
                do
                {
                    Console.Write("Nhap phan tu " + i + ": ");
                    z = Console.ReadLine();
                } while ((int.TryParse(z, out x[i]) == false));
            }
            XuatSNT(x);
            

        }


        static bool ktsnt (int x)
        { 
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void XuatSNT(int[] arr)
        {
            Console.Write("Cac so nguyen to co trong mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                int k = Convert.ToInt32(arr[i]);
                if (ktsnt(k) == true)
                    Console.Write(k + " ");
            }
        }
    }
}