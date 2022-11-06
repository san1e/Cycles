using System;

namespace Повнi_квадрати
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int num1 = Convert.ToInt32(data[0]);
            int num2 = Convert.ToInt32(data[1]);
            int pow = 0;
            int a = num1;
            if (num1 == num2 && (num1 != 1  && num2 != 1))
            {
                
                    Console.WriteLine(-1);
                
            }
            else if (a <= num2 )
            {
                while (a < num2)
                {
                    pow++;
                    a = (int) Math.Pow(pow, 2);
                    if (a > num2)
                    {
                        break;
                    }
                    else if (a >= num1)
                    {
                        Console.Write( $"{a}");
                    }
                }
            }
        }
    }
}
