namespace Decorator
{
    public class AddOperation : IOperation
    {
        public double Execute(double a, double b)
        {
            return a + b;
        }
    }
}