namespace calcul
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Простой калькулятор");

            try
            {
                Console.Write("Первое число: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Оператор (+, -, *, /): ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = Calculate(num1, op, num2);
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректные числа!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static double Calculate(double a, char op, double b)
        {
            return op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b != 0 ? a / b : throw new DivideByZeroException(),
                _ => throw new ArgumentException("Неизвестный оператор")
            };
        }
    }
}

