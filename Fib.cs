using System;
using System.Collections.Generic;


namespace Fib
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var fibonacciNumbers = new List<int> { 1, 1 };

        //    while (fibonacciNumbers.Count < 20)
        //    {
        //        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        //        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        //        fibonacciNumbers.Add(previous + previous2);
        //    }
        //    foreach (var item in fibonacciNumbers)
        //        Console.WriteLine(item);
        //}
        static void Main(string[] args) 
        {
            int f1 = 1;
            int f2 = 1;
            int i;

            System.Console.Write(f1 + " " + f2 + " ");

            for (i = 3; i <= 20; i++)
            {
                f2 += f1;
                f1 = f2 - f1;
                if (i % 5 == 0)
                    System.Console.WriteLine(f2 + " ");
                else
                    System.Console.Write(f2 + " ");
            }
        }
    }
}