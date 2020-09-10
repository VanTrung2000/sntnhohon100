using System;

namespace sntnhohon100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập n :");
            int n = int.Parse(Console.ReadLine());
            hienthi(n);
            Console.ReadLine();
        }

        private static void hienthi(int n)
        {
            int dem = 0;
            Console.Write($"Cac so nguyen to trong khoang {n} la:");
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                }

                if (dem == 2)
                {
                    Console.Write($"{i},");
                }
                dem = 0;
            }
        }
    }
}
