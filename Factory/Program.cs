using System;

namespace Factory
{
    static class Program
    {
        static void Main()
        {
            // TODO - Replace with factory
            ILogger logger = new Logger();
            var calc = new LoggerDecorator(new Calc(), logger);
            Console.WriteLine(calc.Execute(2, "+", 3));
            Console.WriteLine(calc.Execute(2, "-", 3));
            Console.WriteLine(calc.Execute(2, "/", 3));
            Console.WriteLine(calc.Execute(2, "*", 3));
        }
    }
}
