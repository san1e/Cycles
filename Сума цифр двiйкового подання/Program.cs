using System;

namespace Сума_цифр_двiйкового_подання
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string num1 = Convert.ToString(num,2);
            int num2 = Convert.ToInt32(num1);
            Console.WriteLine(num2);
            int sum = 0;
            while (num2 > 0)
            {
                sum = sum + num2 % 10;
                num2 = num2 / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
