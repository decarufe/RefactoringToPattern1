namespace Factory
{
    public class SubstractOperation : IOperation
    {
        public double Execute(double a, double b)
        {
            return a - b;
        }
    }
}