using System;
using StrategyDone.Strategy;

namespace StrategyDone
{
    public class Calc
    {
        public double Execute(double a, IOperation operation, double b)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Executing {a} {operation} {b}");
            Console.ForegroundColor = currentColor;

            var result = operation.Execute(a, b);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Executed {a} {operation} {b} = {result}");
            Console.ForegroundColor = currentColor;
            
            return result;
        }
    }
}