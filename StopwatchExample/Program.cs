using System;
using System.Diagnostics;


namespace StopwatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + "\n");
            }
            watch.Stop();
            Console.WriteLine($"Execution time :{watch.ElapsedMilliseconds} ms");
        }
    }
}
