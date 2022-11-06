using System;

namespace Марiчка_та_будильники
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split();
            int hour = int.Parse(time[0]);
            int min = int.Parse(time[1]);
            int count = 1;
            int i = Convert.ToInt32(Console.ReadLine());
            while (count <= i)
            {
                int a = hour * 60 + min; 
                hour = a / 60;
                min = a % 60;
                if (hour >= 24)
                {
                    hour = hour - 24;
                }
                Console.WriteLine($"{hour:d2}:{min:d2}");
                min += 5;
                count++;
            }
        }
    }
}
