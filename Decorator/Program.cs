using System;

namespace Decorator
{
    static class Program
    {
        static void Main()
        {
            var calc = new Calc();
            Console.WriteLine(calc.Execute(2, new AddOperation(), 3));
            Console.WriteLine(calc.Execute(2, new SubstractOperation(), 3));
            Console.WriteLine(calc.Execute(2, new DivideOperation(), 3));
            Console.WriteLine(calc.Execute(2, new MultiplyOperation(), 3));
        }
    }
}
