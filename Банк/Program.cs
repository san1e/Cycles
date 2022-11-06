using System;

namespace Банк
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double N = Convert.ToDouble(data[0]); // МАЄТЕ
            double P = Convert.ToDouble(data[1]);
            double M = Convert.ToDouble(data[2]); // Охечете отримати
            int year = 0;
            while (N < M)
            {
                if (N >= 1 && M >= 1 && ( P >= 1 && P <= 100) )
                {
                    N = (N * P / 100) + N;
                    year++;
                }
                
            }
            Console.WriteLine(year);
        }
    }
}
