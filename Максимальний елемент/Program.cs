using System;

namespace Максимальний_елемент
{
    class Program
    {
        static void Main(string[] args)
        {
            int prevNum = Convert.ToInt32(Console.ReadLine());
            int max = prevNum;
            while (prevNum != 0)
            {

                int nextNum = Convert.ToInt32(Console.ReadLine());

                if (nextNum != 0 && max < nextNum)
                {
                    max = nextNum;
                }
                prevNum = nextNum;
                

            }
            Console.WriteLine(max);
        }
    }
}
