using System;

namespace Марiчка_та_квадрати
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int A = Convert.ToInt32(data[0]);
            int B = Convert.ToInt32(data[1]);
            int count = A;
            int a = 0;
            int sum = 0;
            while (count <= B)
            {
                count++;
                a = (int)Math.Pow(A++, 2);
                sum += a ;
                
            }
            Console.WriteLine(sum);
          
          


            
        }
    }
}
