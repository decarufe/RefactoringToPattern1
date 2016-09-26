using System;

namespace Strategy
{
    public class Calc
    {
        public double Execute(double a, string operation, double b)
        {
            double result = 0;
            Console.WriteLine($"Executing {a} {operation} {b}");
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
            Console.WriteLine($"Executed {a} {operation} {b} = {result}");
            return result;
        }
    }
}