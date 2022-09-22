

namespace ArithmeticOperationApi
{
    public interface Imath
    {
        double sum(double a, double b);
        double dif(double a, double b);
        double mul(double a, double b);
        double div(double a, double b);
    }

    public class Math : Imath
    {
        public double dif(double a, double b)
        {
            return a - b;
        }

        public double div(double a, double b)
        {
            return a / b;
        }

        public double mul(double a, double b)
        {
            return a * b;
        }

        public double sum(double a, double b)
        {
            return a + b;
        }
    }
}
