using DecoratorDone.Strategy;

namespace DecoratorDone
{
    public interface ICalc
    {
        double Execute(double a, IOperation operation, double b);
    }
}