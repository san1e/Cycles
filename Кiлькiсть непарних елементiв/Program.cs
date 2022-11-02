using System;

namespace Кiлькiсть_непарних_елементiв
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int count = 0;
            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
