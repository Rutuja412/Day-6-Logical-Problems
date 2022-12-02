using System;
using System.Linq;

namespace Coupon_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a coupon number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                Random random = new Random();
                string result = new string(Enumerable.Repeat(chars, 9).Select(s => s[random.Next(s.Length)]).ToArray());
                Console.WriteLine(result);
            }
        }
    }
}
