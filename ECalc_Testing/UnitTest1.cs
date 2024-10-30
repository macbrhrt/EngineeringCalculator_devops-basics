namespace ECalc_Testing
{
    public class Tests
    {
        private ECalc_Core.EngineeringCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new ECalc_Core.EngineeringCalculator();
        }
        [Test]
        public void Add_ReturnCorrect()
        {
            double result = calculator.Add(-12, -11);
            Assert.AreEqual(-23, result);
        }
        [Test]
        public void Add_LargeNumbers()
        {
            double result = calculator.Add(double.MaxValue, double.MaxValue);
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [Test]
        public void Subtract_ReturnCorrect()
        {
            double result = calculator.Subtract(6, -11);
            Assert.AreEqual(17, result);
        }
        [Test]
        public void Subtract_LargeNumbers()
        {
            double result = calculator.Subtract(-double.MaxValue, double.MaxValue);
            Assert.AreEqual(double.NegativeInfinity, result);
        }
        [Test]
        public void Multiply_ReturnCorrect()
        {
            double result = calculator.Multiply(0.9, 100);
            Assert.AreEqual(90, result);
        }
        [Test]
        public void Multiply_LargeNumbers()
        {
            double result = calculator.Multiply(double.MaxValue, 2);
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [Test]
        public void Divide_ReturnCorrect()
        {
            double result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void Divide_LargeNumbers()
        {
            double result = calculator.Divide(double.MaxValue, double.Epsilon);
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [Test]
        public void Divide_ThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0), "Неможливо поділити на нуль");
        }
        [Test]
        public void Power_ReturnCorrect()
        {
            double result = calculator.Power(2, 3);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Power_LargeNumbers()
        {
            double result = calculator.Power(double.MaxValue, 2);
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [Test]
        public void SquareRoot_ReturnCorrect()
        {
            double result = calculator.SquareRoot(9);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void SquareRoot_LargeNumbers()
        {
            double result = calculator.SquareRoot(double.MaxValue);
            Assert.IsTrue(result > 0); 
        }
        [Test]
        public void SquareRoot_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.SquareRoot(-4), "Неможливо розрахувати квадратний корень з від'ємного числа");
        }
        [Test]
        public void Logarithm_ReturnCorrect()
        {
            double result = calculator.Logarithm(8, 2);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void NaturalLogarithm_ReturnCorrect()
        {
            double result = calculator.NaturalLogarithm(Math.E);
            Assert.AreEqual(1, result, 1e-10); 
        }
        [Test]
        public void Sine_ReturnCorrect()
        {
            double result = calculator.Sine(Math.PI / 2);
            Assert.AreEqual(1, result, 1e-10);  
        }
        [Test]
        public void Cosine_ReturnCorrect()
        {
            double result = calculator.Cosine(0);
            Assert.AreEqual(1, result, 1e-10);  
        }
        [Test]
        public void Tangent_ReturnCorrect()
        {
            double result = calculator.Tangent(Math.PI / 4);
            Assert.AreEqual(1, result, 1e-10);  
        }
        [Test]
        public void Logarithm_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Logarithm(144, 0));
        }
    }
}