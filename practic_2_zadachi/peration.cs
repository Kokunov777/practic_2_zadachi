using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_2_zadachi
{
    public enum OperationType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Exponentiation,
        SquareRoot
    }

    public class Calculator
    {
        public static int DoOperation(OperationType operation, int a, int b)
        {
            switch (operation)
            {
                case OperationType.Addition:
                    return a + b;
                case OperationType.Subtraction:
                    return a - b;
                case OperationType.Multiplication:
                    return a * b;
                case OperationType.Division:
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль недопустимо.");
                    }
                    return a / b;
                case OperationType.Exponentiation:
                    return (int)Math.Pow(a, b);
                case OperationType.SquareRoot:
                    if (a < 0)
                    {
                        throw new ArgumentException("Квадратный корень из отрицательного числа невозможен.");
                    }
                    return (int)Math.Sqrt(a);
                default:
                    throw new ArgumentException("Неизвестный тип операции.");
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(DoOperation(OperationType.Addition, 5, 3)); // 8
                Console.WriteLine(DoOperation(OperationType.Subtraction, 5, 3)); // 2
                Console.WriteLine(DoOperation(OperationType.Multiplication, 5, 3)); // 15
                Console.WriteLine(DoOperation(OperationType.Division, 5, 3)); // 1
                Console.WriteLine(DoOperation(OperationType.Exponentiation, 5, 3)); // 125
                Console.WriteLine(DoOperation(OperationType.SquareRoot, 16, 0)); // 4
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}