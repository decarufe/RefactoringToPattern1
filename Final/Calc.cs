using System;
using System.Collections.Generic;

namespace Final
{
    public class Calc : ICalc
    {
        private Calc()
        {
        }

        public static ICalc Create()
        {
            ICalc calc = new Calc();
            ILogger logger = new Logger();
            calc = new LoggerDecorator(calc, logger);
            return calc;
        }

        private readonly IDictionary<string, Type> _operationMap = new Dictionary<string, Type>
        {
            { "+", typeof(AddOperation) },
            { "-", typeof(SubstractOperation) },
            { "/", typeof(DivideOperation) },
            { "*", typeof(MultiplyOperation) }
        };

        public double Execute(double a, string operation, double b)
        {
            var instance = (IOperation)Activator.CreateInstance(_operationMap[operation]);
            var result = instance.Execute(a, b);
            return result;
        }
    }
}