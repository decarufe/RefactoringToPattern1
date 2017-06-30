using System;

namespace Decorator
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Strategy\n");
            var calc = new Calc();
            Console.WriteLine("6 + 2 = {0}", calc.Execute(6, new AddOperation(), 2));
            Console.WriteLine("6 - 2 = {0}", calc.Execute(6, new SubstractOperation(), 2));
            Console.WriteLine("6 / 2 = {0}", calc.Execute(6, new DivideOperation(), 2));
            Console.WriteLine("6 * 2 = {0}", calc.Execute(6, new MultiplyOperation(), 2));
        }
    }
}
