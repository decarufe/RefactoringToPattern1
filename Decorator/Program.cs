using System;

namespace Decorator
{
    static class Program
    {
        static void Main()
        {
            var calc = new Calc();
            Console.WriteLine(calc.Execute(2, "+", 3));
            Console.WriteLine(calc.Execute(2, "-", 3));
            Console.WriteLine(calc.Execute(2, "/", 3));
            Console.WriteLine(calc.Execute(2, "*", 3));
        }
    }
}
