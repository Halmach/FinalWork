using System;

namespace Task2
{
    class Program
    {
        private static ILogger logger;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слагаемые:");
            try
            {
                logger = new Logger();
                ICalculator calc = new Calculator(logger);
                int result = calc.Addition(Console.ReadLine(), Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
        }
    }

    public interface ILogger
    {
        void Event(string message);

        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Event(string message)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
        }
        public void Error(string message)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }

    interface ICalculator
    {

        int Addition(string s1, string s2);
    }

    class Calculator : ICalculator
    {
        private ILogger logger;

        public Calculator(ILogger logger)
        {
            this.logger = logger;
        }
        public int Addition(string s1, string s2)
        {
            int a = 0;
            int b = 0;
            if (s1.Trim() == "")
            {
                logger.Error("Не введено первое слагаемое");
                return 0;
            }
            else a = Convert.ToInt32(s1);

            if (s2.Trim() == "")
            {
                logger.Error("Не введено второе слагаемое");
                return 0;
            }
            else b = Convert.ToInt32(s2);
            int result = a + b;
            logger.Event("Результат:" + result);
            return result;
        }
    }
}