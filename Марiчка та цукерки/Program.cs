using System;

namespace Марiчка_та_цукерки
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double A = Convert.ToDouble(data[0]);
            double B = Convert.ToDouble(data[1]);
            double hrn = A;
            double cop = B / 100;
            double sum =hrn + cop;
            double count = 0;
            double kg = 1;
            double sum1 = 0;
            Console.WriteLine($" {kg} kg: {sum:f2} UAH");
            while (count <= 7)
            { 
                
                    count++;
                    kg++;
                    sum1 =sum * kg;
                    Console.WriteLine($" {kg} кг: {sum1:f2} UAH");
                
                
            }
            kg++;
            Console.WriteLine($"{kg} кг: {sum*kg:f2} UAH");

        }
    }
}
