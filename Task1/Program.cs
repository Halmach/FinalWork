using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слагаемые:");
            try
            {
                ICalculator calc = new Calculator();
                int result = calc.Addition(Convert.ToInt32(Console.ReadLine()),
                    Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    interface ICalculator
    {
        int Addition(int a, int b);
    }

    class Calculator : ICalculator
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
    }
}