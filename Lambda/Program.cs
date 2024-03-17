using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
namespace maybe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[20];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.NextDouble();
            }

            var sum = (double x, double y) => x + y;
            var result = (double x, double y) => x * y;
            var smallOne = (double l, double g) =>
            {
                if (l > g)
                    return g;
                else
                    return l;
            };
            for (double x = 0; x < numbers.Length-1; x++)
            {
                Console.WriteLine($"Numbers you are using: {numbers[(int)x]}  and  {numbers[(int)(x+1)]}");
                Console.WriteLine($"The sum is: {sum(numbers[(int)x], numbers[(int)(x+1)])}");
                Console.WriteLine($"The difference is: {result(numbers[(int)x], numbers[(int)(x + 1)])}");
                Console.WriteLine($"The larger value is: {smallOne(numbers[(int)x], numbers[(int)(x + 1)])}");
                Console.WriteLine();
            }
        }
    }
}