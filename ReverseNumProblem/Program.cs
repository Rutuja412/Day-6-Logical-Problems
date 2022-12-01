using System;

namespace ReverseNumProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, remainder;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }
            Console.WriteLine("{0} is a reversed number", reverse);
        }
    }
}
