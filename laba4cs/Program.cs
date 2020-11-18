using System;

namespace laba4cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=0, n, m;
            Console.WriteLine("Input n..."); 
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input m...");
            m = int.Parse(Console.ReadLine());
            if(n>=Math.Pow(10, m - 1))
            {
                for (; m > 0; m--)
                {
                    result += n % 10;
                    n /= 10;
                }
                Console.WriteLine($"Result is {result}.");
            }
            else
            {
                Console.WriteLine("M is greater than the number of digits of n");
            }
            Console.ReadKey();
        }
    }
}
