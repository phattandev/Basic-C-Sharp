using System;
using System.Collections.Specialized;
using System.Threading.Channels;

namespace MyNamespace
{
	class MyClass
	{
		static void Main(string[] args)
		{
            Console.Write("Moi nhap so luong phan tu cho mang: ");
            string value = Console.ReadLine();
            int[] arr = new int[0];
			while (true)
			{
				if (int.TryParse(value, out int n))
				{
					arr = new int[n];
					NhapMang(ref arr);
					XuatSCP(arr);
					Console.WriteLine("\n");
					XuatSHT(arr);
                    Console.WriteLine("\n");
                    XuatSNT(arr);
                    break;
				}
				else
				{
					Console.Write("Nhap sai. Moi nhap lai so luong phan tu cho mang: ");
                    value = Console.ReadLine();
                }
			}
		}

        static void NhapMang(ref int[] arr)
        {
            Console.WriteLine("-----Nhap Mang------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Moi nhap phan tu " + i + ": ");
                string InPut = Console.ReadLine();
                if (InPut == "-99") break;
                while (int.TryParse(InPut, out arr[i]) == false)
                {
                    Console.WriteLine("Nhap sai!!!; Moi nhap lai: ");
                    Console.Write("Moi nhap phan tu " + i + ": ");
                    InPut = Console.ReadLine();
                }

            }
        }

        static bool KTSNT(int num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static bool KTSCP(int num)
		{
			double temp = Math.Sqrt(num);
			int kq = (int)temp;
			return ((kq * kq) == num) ? true : false;
		}

		static bool KTSHT(int num)
		{
			int sum = 0;
			for (int i = 1; i < num; i++)
			{
				if (num % i == 0)
					sum += i;
			}
			return (sum == num) ? true : false;
		}

		static void XuatSCP(int[] arr)
		{
            Console.WriteLine("So chinh phuong co trong mang: ");
            for (int i = 0; i < arr.Length; i++)
			{
				if (KTSCP(arr[i]) == true)
					Console.Write(arr[i] + " ");
            }
		}

        static void XuatSHT(int[] arr)
        {
            Console.WriteLine("So hoan thien co trong mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (KTSHT(arr[i]) == true)
                    Console.Write(arr[i] + " ");
            }
        }

        static void XuatSNT(int[] arr)
        {
            Console.WriteLine("So nguyen to co trong mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (KTSNT(arr[i]) == true)
                    Console.Write(arr[i] + " ");
            }
        }

    }
}