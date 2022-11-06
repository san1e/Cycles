using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Число_у_вертикальнiй_рамцi
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPrev = int.Parse(Console.ReadLine());
            int numNext = numPrev;
            int div = 10;
            int a = 0;
            int count = 0;
            Console.WriteLine("***");
            if (numNext < 0)
            {
                Console.WriteLine("*-*");
            }
            while (numNext != 0)
            {
                int b = numNext % 10;
                numNext /= 10;
                count++;
            }
            div = (int)Math.Pow(div, count - 1);
            while (div >= 1)
            {
                a = Math.Abs(numPrev) / div;
                numPrev %= div;
                div /= 10;
                Console.WriteLine($"*{a}*");
            }
            Console.Write("***");

        }
    }
}
