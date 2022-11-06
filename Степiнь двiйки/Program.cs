using System;

namespace Степiнь_двiйки
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            uint i = 0;
            while (Math.Pow(2, i) <= N)
            {
                Console.Write(" " + Math.Pow(2, i));
                i++;
            }  
        }
    }
}
