using System;

namespace Степiнь_двiйки
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int pow = 0;
            while (num > Math.Pow(2, pow))
            {
                pow++;
            }
            Console.WriteLine(pow);
        }
    }
}
