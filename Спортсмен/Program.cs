using System;

namespace Спортсмен
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double firstDay = Convert.ToDouble(data[0]);
            double need = Convert.ToDouble(data[1]);
            int i = 1;
            while (firstDay < need)
            {
                firstDay += firstDay * 1.0 / 10;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
