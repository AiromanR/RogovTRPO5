using System;

namespace RogovTRPO5
{
    internal class Program
    {
        static void Main (string [ ] args)
        {
            Console.WriteLine("Введите N:");
            int n = int.Parse(Console.ReadLine());

            int temp = n, delitel = 1, sum = 0; 

            while(temp > 10)
            {
                temp /=  10;
                delitel *= 10;
            }

            while(delitel > 0)
            {
                temp = n / delitel;
                Console.WriteLine(temp);
                sum += temp;
                delitel /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
