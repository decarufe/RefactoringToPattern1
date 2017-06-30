using System;

namespace Strategy
{
    public class Calc
    {
        public double Execute(double a, string operation, double b)
        {
            double result = 0;

            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Executing {a} {operation} {b}");
            Console.ForegroundColor = currentColor;

            // TODO: Refactor to strategy
            switch (operation.ToLower())
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "/":
                    result = a/b;
                    break;
                case "*":
                    result = a*b;
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Executed {a} {operation} {b} = {result}");
            Console.ForegroundColor = currentColor;
            
            return result;
        }
    }
}