using System;

namespace Кiлькiсть_нулiв
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = Math.Abs(Convert.ToInt64(Console.ReadLine()));
            int count = 0;
            while (N > 0)
            {
                if (N % 10 == 0)
                {
                    count++;
                    N /= 10;
                }
                else
                {
                    N /= 10;
                }
            }
            Console.WriteLine(count);
        }
    }
}
