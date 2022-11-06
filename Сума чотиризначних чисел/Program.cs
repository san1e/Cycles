using System;

namespace Сума_чотиризначних_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            uint K = uint.Parse(Console.ReadLine());
            uint i = 1;
            uint sum = 0;
            uint res = 0;
            while (K * i < 10000)
            {
                while (K * i < 1000)
                {
                    i++;
                    res = 0;
                }
                res = K * i;
                sum += res;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
