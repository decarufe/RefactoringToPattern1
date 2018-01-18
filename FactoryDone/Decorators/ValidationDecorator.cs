using System;
using FactoryDone.Strategy;

namespace FactoryDone.Decorators
{
    public class ValidationDecorator : CalcDecorator
    {
        public ValidationDecorator(ICalc calc) : base(calc)
        {
        }

        protected override bool Executing(double a, IOperation operation, double b)
        {
            if (operation is DivideOperation && b == 0.0)
            {
                Console.WriteLine("Divide By 0");
                return false;
            }
            return base.Executing(a, operation, b);
        }
    }
}