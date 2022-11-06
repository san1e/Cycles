using System;

namespace Неспадна_пiдпослiдовнiсть
{
    class Program
    {
        static void Main(string[] args)
        {
            int prevNum = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int count2 = 0;
            int nextNum = Convert.ToInt32(Console.ReadLine());
            while (prevNum <= nextNum)
            {
                count2++;
                
                if (nextNum >= prevNum)
                {
                    
                    prevNum = nextNum;
                    nextNum = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            
            Console.WriteLine(count2+1);

        }
    }
}

