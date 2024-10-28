using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECalc_Core
{
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }

    public interface IScientificCalculator : ICalculator
    {
        double Power(double baseNum, double exponent);
        double SquareRoot(double number);
        double Logarithm(double number, double baseNum);
        double NaturalLogarithm(double number);
        double Sine(double angle);
        double Cosine(double angle);
        double Tangent(double angle);
    }

}
