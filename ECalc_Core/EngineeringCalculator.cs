using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECalc_Core
{
    public class EngineeringCalculator : IScientificCalculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Неможливо поділити на нуль");
            return a / b;
        }
        public double Power(double baseNum, double exponent) => Math.Pow(baseNum, exponent);
        public double SquareRoot(double number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("Неможливо розрахувати квадратний корень з від'ємного числа");
            return Math.Sqrt(number);
        }
        public double Logarithm(double number, double baseNum) => Math.Log(number, baseNum);
        public double NaturalLogarithm(double number) => Math.Log(number);
        public double Sine(double angle) => Math.Sin(angle);
        public double Cosine(double angle) => Math.Cos(angle);
        public double Tangent(double angle) => Math.Tan(angle);
    }
}
