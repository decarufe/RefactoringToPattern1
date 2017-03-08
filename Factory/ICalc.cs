namespace Factory
{
    public interface ICalc
    {
        double Execute(double a, IOperation operation, double b);
    }
}