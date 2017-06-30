using System;

namespace Strategy
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Initial\n");
            var calc = new Calc();
            Console.WriteLine("6 + 2 = {0}", calc.Execute(6, "+", 2));
            Console.WriteLine("6 - 2 = {0}", calc.Execute(6, "-", 2));
            Console.WriteLine("6 / 2 = {0}", calc.Execute(6, "/", 2));
            Console.WriteLine("6 * 2 = {0}", calc.Execute(6, "*", 2));
        }
    }
}
