namespace Factory
{
    public abstract class CalcDecorator : ICalc
    {
        private readonly ICalc _calc;

        protected CalcDecorator(ICalc calc)
        {
            _calc = calc;
        }

        public double Execute(double a, string operation, double b)
        {
            Executing(a, operation, b);
            var result = _calc.Execute(a, operation, b);
            Executed(a, operation, b, result);
            return result;
        }

        protected virtual void Executing(double a, string operation, double b)
        {
        }

        protected virtual void Executed(double a, string operation, double b, double result)
        {
        }
    }
}