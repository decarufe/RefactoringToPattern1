using FactoryDone.Strategy;

namespace FactoryDone
{
    public interface ICalc
    {
        double Execute(double a, IOperation operation, double b);
    }
}