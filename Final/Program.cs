using System;

namespace Final
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Factory Method\n");
            var calc = Calc.Create();
            Console.WriteLine(calc.Execute(2, new AddOperation(), 3));
            Console.WriteLine(calc.Execute(2, new SubstractOperation(), 3));
            Console.WriteLine(calc.Execute(2, new DivideOperation(), 3));
            Console.WriteLine(calc.Execute(2, new MultiplyOperation(), 3));
        }
    }
}
