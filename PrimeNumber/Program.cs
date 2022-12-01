using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int n, a, m = 0, PrimeIndicator = 0;
            Console.Write("****Enter a number**** : ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (a = 2; a <= m; a++)
            {
                if (n % a == 0)
                {
                    Console.Write("*****Entered number is not prime number***** ");
                    PrimeIndicator = 1;
                    break;
                }
            }
            if (PrimeIndicator == 0)
                Console.Write("****The entered number is a Prime number****** ");
        }
    }
} 
        
            

        
    

