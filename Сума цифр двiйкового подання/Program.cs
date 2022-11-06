using System;

namespace Сума_цифр_двiйкового_подання
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            while (true)
            {
                result += num % 2; 
                num = num / 2;
                if (num == 0)
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
