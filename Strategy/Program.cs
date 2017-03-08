using System;

namespace Strategy
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Refactor to strategy\n");
            var calc = new Calc();
            Console.WriteLine(calc.Execute(2, "+", 3));
            Console.WriteLine(calc.Execute(2, "-", 3));
            Console.WriteLine(calc.Execute(2, "/", 3));
            Console.WriteLine(calc.Execute(2, "*", 3));
        }
    }
}
