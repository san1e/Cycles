using System;

namespace Середнє_арифметичне
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1;
            double sum = 0;
            double count = 0;
            
            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                count++;
                if (num == 0)
                {
                    count -= 1;
                }
            }
            double a = sum / count;
            Console.WriteLine(a);

        }
    }
}
