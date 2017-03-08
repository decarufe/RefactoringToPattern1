using System;
using System.Collections.Generic;

namespace Factory
{
    public class Calc : ICalc
    {
        public double Execute(double a, IOperation operation, double b)
        {
            var result = operation.Execute(a, b);
            return result;
        }
    }
}