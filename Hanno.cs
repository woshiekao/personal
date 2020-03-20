using System;

namespace ConsoleFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorHanno c = new CalculatorHanno();
            
            Console.WriteLine(c.HannoCalculator(64));

        }
    }
    class CalculatorHanno //类名
    {
        public ulong HannoCalculator(int count) //声明一个长整型变量 盘子总数
        {
            ulong StepForCurrentDish = 1;  //1个盘子至少需要1步
            if (count == 1)
            {
                return StepForCurrentDish; 
            }
            else
            {
                ulong TotalStep = HannoCalculator(count - 1) * 2 + StepForCurrentDish; // F(n) = 2F(n-1) + 1
                return TotalStep; //总步数
            }
        }
    }
}
