using System;

namespace For10
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = Decimal.Parse(Console.ReadLine());
            decimal S =0;
            for (decimal i = 1; i <= n; i++)
            {
                S += 1 / i;
            }
            Console.WriteLine(S);
        }
    }
}