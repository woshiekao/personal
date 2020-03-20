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
    class CalculatorHanno //����
    {
        public ulong HannoCalculator(int count) //����һ�������ͱ��� ��������
        {
            ulong StepForCurrentDish = 1;  //1������������Ҫ1��
            if (count == 1)
            {
                return StepForCurrentDish; 
            }
            else
            {
                ulong TotalStep = HannoCalculator(count - 1) * 2 + StepForCurrentDish; // F(n) = 2F(n-1) + 1
                return TotalStep; //�ܲ���
            }
        }
    }
}
