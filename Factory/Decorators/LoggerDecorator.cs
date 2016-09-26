﻿using System;

namespace Factory
{
    public class LoggerDecorator : CalcDecorator
    {
        private readonly ILogger _logger;

        public LoggerDecorator(ICalc calc, ILogger logger) : base(calc)
        {
            _logger = logger;
        }

        public LoggerDecorator(ICalc calc) : base(calc)
        {
        }

        protected override void Executing(double a, string operation, double b)
        {
            _logger.Log($"Executing {a} {operation} {b}");
        }

        protected override void Executed(double a, string operation, double b, double result)
        {
            _logger.Log($"Executed {a} {operation} {b} = {result}");
        }
    }
}