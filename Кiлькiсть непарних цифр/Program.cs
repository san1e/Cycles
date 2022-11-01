using System;
using System.Linq;

namespace Кiлькiсть_непарних_цифр
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int odd = 0;
            while (Math.Abs(num) > 0) 
            {
                if (num % 2 != 0)
                {
                    odd += 1;
                }
               
                num = num / 10;
            }
            Console.WriteLine(odd);

        }
    }
}
