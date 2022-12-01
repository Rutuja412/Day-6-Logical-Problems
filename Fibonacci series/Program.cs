using System;

namespace Fibonacci_series
{
    internal class Program
    {
        static void Series (int n,int first,int second)
        {
            Console.WriteLine( first + "\n" + second  );
            int counter = 0, n3;

            while ( counter < n ) 
            {
            n3= first + second;
                Console.WriteLine( n3 + "");
                first = second;
                second = n3;
                counter++;

            }
        }
        public static void Main ()
        {
            int n = 10,  first = 1, second=2 ;
            Series (n, first,second);
        }
    }
}
