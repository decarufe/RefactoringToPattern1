using System;
using FactoryDone.Decorators;
using FactoryDone.Logging;
using FactoryDone.Strategy;

namespace FactoryDone
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Factory Done\n");
            var calc = Calc.Create();
            Console.WriteLine("6 + 2 = {0}", calc.Execute(6, new AddOperation(), 2));
            Console.WriteLine("6 - 2 = {0}", calc.Execute(6, new SubstractOperation(), 2));
            Console.WriteLine("6 / 2 = {0}", calc.Execute(6, new DivideOperation(), 2));
            Console.WriteLine("6 * 2 = {0}", calc.Execute(6, new MultiplyOperation(), 2));
        }
    }
}
