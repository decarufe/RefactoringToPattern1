using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Calc
    {
        private readonly IDictionary<string, Type> _operationMap = new Dictionary<string, Type>
        {
            { "+", typeof(AddOperation) },
            { "-", typeof(SubstractOperation) },
            { "/", typeof(DivideOperation) },
            { "*", typeof(MultiplyOperation) }
        };

        public double Execute(double a, string operation, double b)
        {
            // TODO: Refactor to decorator
            Console.WriteLine($"Executing {a} {operation} {b}");
            var instance = (IOperation)Activator.CreateInstance(_operationMap[operation]);
            var result = instance.Execute(a, b);
            // TODO: Refactor to decorator
            Console.WriteLine($"Executed {a} {operation} {b} = {result}");
            return result;
        }
    }
}