using System;

namespace Strategy
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Initial\n");
            var calc = new Calc();
            Console.WriteLine(calc.Execute(2, "+", 3));
            Console.WriteLine(calc.Execute(2, "-", 3));
            Console.WriteLine(calc.Execute(2, "/", 3));
            Console.WriteLine(calc.Execute(2, "*", 3));
        }
    }
}
