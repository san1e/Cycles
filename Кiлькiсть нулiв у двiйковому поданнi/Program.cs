using System;

namespace Кiлькiсть_нулiв_у_двiйковому_поданнi
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());
            string a = Convert.ToString(num, 2);
            int count = 0;
            foreach (var character in a)
            {
                if (character == '0') count++;
            }
            Console.WriteLine(count);
        
        }
    }
}
