using System;

namespace Decorator
{
    public class Calc
    {
        public double Execute(double a, IOperation operation, double b)
        {
            // TODO: Refactor to decorator
            Console.WriteLine($"Executing {a} {operation} {b}");
            var result = operation.Execute(a, b);
            // TODO: Refactor to decorator
            Console.WriteLine($"Executed {a} {operation} {b} = {result}");
            return result;
        }
    }
}