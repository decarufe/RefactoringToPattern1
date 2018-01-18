using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDone.Strategy;

namespace StrategyDone
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Strategy Done\n");
            var calc = new Calc();
            Console.WriteLine("6 + 2 = {0}", calc.Execute(6, new AddOperation(), 2));
            Console.WriteLine("6 - 2 = {0}", calc.Execute(6, new SubstractOperation(), 2));
            Console.WriteLine("6 / 2 = {0}", calc.Execute(6, new DivideOperation(), 2));
            Console.WriteLine("6 * 2 = {0}", calc.Execute(6, new MultiplyOperation(), 2));
        }
    }
}
