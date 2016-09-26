﻿namespace Decorator
{
    public class DivideOperation : IOperation
    {
        public double Execute(double a, double b)
        {
            return a/b;
        }
    }
}