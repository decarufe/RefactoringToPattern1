using System;

namespace Factory
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Refactor to factory\n");
            // TODO - Replace with factory
            ILogger logger = new Logger();
            var calc = new LoggerDecorator(new Calc(), logger);
            Console.WriteLine(calc.Execute(2, new AddOperation(), 3));
            Console.WriteLine(calc.Execute(2, new SubstractOperation(), 3));
            Console.WriteLine(calc.Execute(2, new DivideOperation(), 3));
            Console.WriteLine(calc.Execute(2, new MultiplyOperation(), 3));
        }
    }
}
