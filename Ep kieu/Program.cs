using System;

namespace Project3
{
    class Program
    {

        static void Main(string[] args)
        {
            string strA, strB;
            int A, B;
            double Nghiem;

            Console.Write("Moi nhap so A: ");
            strA = Console.ReadLine();
            Console.Write("Moi nhap so B: ");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine("Du lieu nhap vao sai!!!");
            }
            else
            {
                Console.WriteLine($"Phuong trinh ban vua nhap la: {A}x + {B} = 0");

                if (A == 0)
                    Console.WriteLine("Phuong trinh vo nghiem.");
                else if (B == 0)
                    Console.WriteLine("Phuong trinh co nghiem x = 0.");
                else
                {
                    Nghiem = (double)-B / A;
                    Console.WriteLine($"Phuong trinh co nghiem x = {Nghiem}.");
                }
                Console.ReadKey();

            }
        }
    }
}