using System;

namespace Важливе_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int count = num2;
            if (count == num2)
            {
                count = 0;
                while (count != num2)
                {
                    count++;
                    Console.WriteLine(num1);
                }
            }
        }
    }
}
