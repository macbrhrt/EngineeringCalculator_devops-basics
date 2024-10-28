using ECalc_Core;
using System.Text;

namespace ECalc_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("[ Інженерний Калькулятор ]");
            do
            {
                var calculator = new EngineeringCalculator();

                Console.WriteLine("==========================");
                Console.WriteLine("Виберіть опреацію:");
                Console.WriteLine("1: Додавання");
                Console.WriteLine("2: Віднімання");
                Console.WriteLine("3: Множення");
                Console.WriteLine("4: Ділення");
                Console.WriteLine("5: Піднесення до степеню");
                Console.WriteLine("6: Квадратний корень");
                Console.WriteLine("7: Логфарифм");
                Console.WriteLine("8: Натуральний логфарифм");
                Console.WriteLine("9: Сінус");
                Console.WriteLine("10: Косінус");
                Console.WriteLine("11: Тангенс");
                Console.WriteLine("Введіть номер операції:");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    double result = choice switch
                    {
                        1 => calculator.Add(ReadDouble("Введіть перше число: "), ReadDouble("Введіть друге число: ")),
                        2 => calculator.Subtract(ReadDouble("Введіть перше число: "), ReadDouble("Введіть друге число: ")),
                        3 => calculator.Multiply(ReadDouble("Введіть перше число: "), ReadDouble("Введіть друге число: ")),
                        4 => calculator.Divide(ReadDouble("Введіть перше число: "), ReadDouble("Введіть друге число: ")),
                        5 => calculator.Power(ReadDouble("Введіть основу: "), ReadDouble("Введіть показник: ")),
                        6 => calculator.SquareRoot(ReadDouble("Введіть число: ")),
                        7 => calculator.Logarithm(ReadDouble("Введіть число: "), ReadDouble("Введіть основу: ")),
                        8 => calculator.NaturalLogarithm(ReadDouble("Введіть число: ")),
                        9 => calculator.Sine(ReadDouble("Введіть кут у радіанах: ")),
                        10 => calculator.Cosine(ReadDouble("Введіть кут у радіанах: ")),
                        11 => calculator.Tangent(ReadDouble("Введіть кут у радіанах: ")),
                        _ => throw new InvalidOperationException("Невірний вибір.")
                    };
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }

                Console.WriteLine("Продовжити? Нажміть Enter");
                Console.ReadLine();
                Console.Clear();
            } while (true);
           
        }

        static double ReadDouble(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }
    }
}