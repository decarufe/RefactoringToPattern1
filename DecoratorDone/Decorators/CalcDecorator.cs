using DecoratorDone.Strategy;

namespace DecoratorDone.Decorators
{
    public abstract class CalcDecorator : ICalc
    {
        private readonly ICalc _calc;

        protected CalcDecorator(ICalc calc)
        {
            _calc = calc;
        }

        public double Execute(double a, IOperation operation, double b)
        {
            if (!Executing(a, operation, b)) return 0;
            var result = _calc.Execute(a, operation, b);
            Executed(a, operation, b, result);
            return result;
        }

        protected virtual bool Executing(double a, IOperation operation, double b)
        {
            return true;
        }

        protected virtual void Executed(double a, IOperation operation, double b, double result)
        {
        }
    }
}