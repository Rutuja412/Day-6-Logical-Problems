using System;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            int n, rem, i, sum = 0;
            Console.WriteLine("Enter a Number :");
            n = int.Parse(Console.ReadLine());

            for(i=1; i<=(n-1); i++)
            {
                rem = n % i;
                if(rem == 0) 
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("{0} is perfect number", n);
            }

            else
            { 
                Console.WriteLine("{0} is not a perfect number", n);
                
            }
        }
    }
}
