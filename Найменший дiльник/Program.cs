using System;

namespace Найменший_дiльник
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (num % i != 0)
            {
                i++;
                
            }
            Console.WriteLine(i);
        }
    }
}
