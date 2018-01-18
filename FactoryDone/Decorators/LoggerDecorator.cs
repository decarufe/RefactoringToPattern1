using FactoryDone.Logging;
using FactoryDone.Strategy;

namespace FactoryDone.Decorators
{
    public class LoggerDecorator : CalcDecorator
    {
        private readonly ILogger _logger;

        public LoggerDecorator(ICalc calc, ILogger logger) : base(calc)
        {
            _logger = logger;
        }

        protected override bool Executing(double a, IOperation operation, double b)
        {
            _logger.Log($"Executing {a} {operation} {b}");
            return base.Executing(a, operation, b);
        }

        protected override void Executed(double a, IOperation operation, double b, double result)
        {
            _logger.Log($"Executed {a} {operation} {b} = {result}");
            base.Executed(a, operation, b, result);
        }
    }
}