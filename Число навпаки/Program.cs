using System;

namespace Число_навпаки
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = Convert.ToInt32(Console.ReadLine());
            long result = 0;
            while (num > 0)
                {
                    result *= 10;
                    result += num % 10;
                    num /= 10;
                }
                
            while (num < 0)
                {
                    result *= 10;
                    result += num % 10;
                    num /= 10;
                }
                Console.WriteLine(result);
            


        }
    }
    
}
