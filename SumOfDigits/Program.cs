using System;
using System.Runtime.InteropServices;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input  a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int evenSum = 0;
            int count = 0;
            while (n != 0)
            {
                sum += n % 10;
                if (count % 2 != 0)
                {
                    evenSum += n % 10;
                }
                n /= 10;
                count++;
            }
            Console.WriteLine("Sum of the digits you entered is: " + sum);
            Console.WriteLine("Sum of the digits with even positions is: " + evenSum);
            Console.WriteLine("Thank you");

        }
    }
}
