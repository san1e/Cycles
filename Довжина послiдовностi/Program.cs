using System;

namespace Довжина_послiдовностi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1 ;
           
            int count = 0;
            while (num != 0)
            {
                num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                count++;
                if (num == 0)
                {
                    count -= 1;
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
