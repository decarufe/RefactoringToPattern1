namespace FactoryDone.Strategy
{
    public class MultiplyOperation : IOperation
    {
        public double Execute(double a, double b)
        {
            return a*b;
        }

        public override string ToString()
        {
            return "*";
        }
    }
}