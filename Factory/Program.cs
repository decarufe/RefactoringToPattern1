using System;

namespace Factory
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Decorator\n");
            // TODO - Replace with factory
            ILogger logger = new Logger();
            var calc = new LoggerDecorator(new Calc(), logger);
            Console.WriteLine("6 + 2 = {0}", calc.Execute(6, new AddOperation(), 2));
            Console.WriteLine("6 - 2 = {0}", calc.Execute(6, new SubstractOperation(), 2));
            Console.WriteLine("6 / 2 = {0}", calc.Execute(6, new DivideOperation(), 2));
            Console.WriteLine("6 * 2 = {0}", calc.Execute(6, new MultiplyOperation(), 2));
        }
    }
}
