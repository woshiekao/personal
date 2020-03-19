using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.PrintSum(4,6);
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public string Today()
        {
            int day = DateTime.Now.Day;
            return day.ToString();
        }

        public void PrintSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
    }

    
     

}

