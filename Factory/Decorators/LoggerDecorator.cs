using System;

namespace Factory
{
    public class LoggerDecorator : CalcDecorator
    {
        private readonly ILogger _logger;

        public LoggerDecorator(ICalc calc, ILogger logger) : base(calc)
        {
            _logger = logger;
        }

        protected override void Executing(double a, IOperation operation, double b)
        {
            _logger.Log($"Executing {a} {operation} {b}");
        }

        protected override void Executed(double a, IOperation operation, double b, double result)
        {
            _logger.Log($"Executed {a} {operation} {b} = {result}");
        }
    }
}