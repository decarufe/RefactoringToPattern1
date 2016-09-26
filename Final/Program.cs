using System;

namespace Final
{
    static class Program
    {
        static void Main()
        {
            var calc = Calc.Create();
            Console.WriteLine(calc.Execute(2, "+", 3));
            Console.WriteLine(calc.Execute(2, "-", 3));
            Console.WriteLine(calc.Execute(2, "/", 3));
            Console.WriteLine(calc.Execute(2, "*", 3));
        }
    }
}
