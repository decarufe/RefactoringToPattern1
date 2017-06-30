using System;

namespace Decorator
{
    public class Calc
    {
        public double Execute(double a, IOperation operation, double b)
        {
            // TODO: Refactor to decorator
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Executing {a} {operation} {b}");
            Console.ForegroundColor = currentColor;

            var result = operation.Execute(a, b);
            
            // TODO: Refactor to decorator
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Executed {a} {operation} {b} = {result}");
            Console.ForegroundColor = currentColor;

            return result;
        }
    }
}