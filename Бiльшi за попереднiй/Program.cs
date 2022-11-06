using System;

namespace Бiльшi_за_попереднiй
{
    class Program
    {
        static void Main(string[] args)
        {
            int prevNum = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (prevNum != 0)
            {
                int nextNum = Convert.ToInt32(Console.ReadLine());
                if (nextNum != 0 && nextNum > prevNum)
                {
                    count++;
                    
                }
                prevNum = nextNum;
            }
           
            Console.WriteLine(count);
        }
    }
}
