using System;

namespace Сума_послiдовностi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while (num != 0)
            {
                
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
