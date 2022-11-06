using System;

namespace Дуже_важливi_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            sbyte numberOfFirst = sbyte.Parse(data[0]);
            sbyte numberOfSecond = sbyte.Parse(data[1]);
            byte number = 0;
            if (numberOfFirst < numberOfSecond)
            {
                for (sbyte i = numberOfFirst; i <= numberOfSecond; i++)
                {
                    number++;
                }
                Console.WriteLine(number + " very important numbers:");
                for (sbyte i = numberOfFirst; i <= numberOfSecond; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (numberOfFirst > numberOfSecond)
            {
                for (sbyte i = numberOfSecond; i <= numberOfFirst; i++)
                {
                    number++;
                }
                Console.WriteLine(number + " very important numbers:");
                for (sbyte i = numberOfFirst; i >= numberOfSecond; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("1 very important numbers:");
                Console.WriteLine(numberOfFirst);
            }
        }
    }
}
