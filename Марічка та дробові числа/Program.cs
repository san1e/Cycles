using System;

namespace Марічка_та_дробові_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal N = Convert.ToDecimal(Console.ReadLine());
            decimal num1 = 1;
            for (decimal i = 0; i <= N/10; i+=0.1M)
            {
                num1 *= i + 1;
            }
            Console.WriteLine(Math.Round(num1,10));
        }
    }
}
