using FactoryDone.Decorators;
using FactoryDone.Logging;
using FactoryDone.Strategy;

namespace FactoryDone
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
            calc = new ValidationDecorator(calc);
            calc = new LoggerDecorator(calc, logger);
            return calc;
        }

        public double Execute(double a, IOperation operation, double b)
        {
            var result = operation.Execute(a, b);
            return result;
        }
    }
}