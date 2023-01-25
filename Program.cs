using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Укажите, площадь какой фигуры требуется вычислить:\n1. Треугольник\n2. Окружность\n\nВведите номер фигуры - ");

            int choose; 
            bool _try = Int32.TryParse(Console.ReadLine(), out choose);

            if (_try && choose == 1)
            {
                Console.WriteLine(TriangleSquare(3,4,5));
            }
            else if (_try && choose == 2)
            {
                Console.WriteLine("\nОкружность.");
            }
            else
            {
                Console.WriteLine("\nВведено некорректное значение.");
            }
        }

        static double TriangleSquare(double a, double b, double c)
        {
            // Площадь треугольника S = √(p·(p - a)·(p - b)·(p - c)), P = (a+b+c)/2
            double p = (a+b+c)/2; // Полупериметр

            double result = Math.Sqrt(p*(p-a)*(p-b)*(p-c));;

            return result;
        }

        static int CircleSquare()
        {
            // Площадь круга S=πR²

            return 0;
        }
    }
}