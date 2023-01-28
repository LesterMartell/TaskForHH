using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


            Console.Write("Укажите, площадь какой фигуры требуется вычислить:\n1. Треугольник\n2. Окружность\n\nВведите номер фигуры - ");

            int choose; 
            bool _try = Int32.TryParse(Console.ReadLine(), out choose);

            if (_try && choose == 1) // Треугольник
            {
                double a, b, c;

                Console.WriteLine("\nВведите данные 3-х сторон треугольника для рассчета периметра:\n");

                Console.Write("Сторона A = ");

                while (!Double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    ErrorPrint();

                    Console.Write("Сторона A = ");
                }
                Console.Write("Сторона B = ");
                while (!Double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    ErrorPrint();

                    Console.WriteLine($"Сторона A = {a}");
                    Console.Write("Сторона B = ");
                }
                Console.Write("Сторона C = ");
                while (!Double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    ErrorPrint();

                    Console.WriteLine($"Сторона A = {a}\nСторона B = {b}");
                    Console.Write("Сторона C = ");
                }

                var res = TriangleSquare(a,b,c);

                if (!double.IsNaN(res))
                {
                    Console.WriteLine($"\nПлощадь треугольника со сторонами {a}, {b}, {c} = {res}");
                }
                else
                {
                    Console.WriteLine($"\nТреугольника со сторонами {a}, {b}, {c} не существует.");
                }


                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;
            }
            else if (_try && choose == 2)
            {
                double r;

                Console.WriteLine("\nВведите данные радиуса окружности:\n");

                Console.Write("Радиус r = ");

                while (!Double.TryParse(Console.ReadLine(), out r) || r <= 0)
                {
                    ErrorPrint();

                    Console.Write("Радиус r = ");
                }

                var res = CircleSquare(r);

                Console.WriteLine($"\nПлощадь окружности с радиусом {r} = {res}");

                break;
            }
            else
            {
                Console.WriteLine("\nВведено некорректное значение.\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
            }

            Console.WriteLine();
            }
        }

        static double TriangleSquare(double a, double b, double c)
        {
            // Площадь треугольника S = √(p·(p - a)·(p - b)·(p - c)), P = (a+b+c)/2
            double p = (a+b+c)/2; // Полупериметр

            double result = Math.Sqrt(p*(p-a)*(p-b)*(p-c));;

            return result;
        }

        static double CircleSquare(double r)
        {
            // Площадь круга S=πR²
            
            double result = Math.Pow(r, 2) * Math.PI;

            return result;
        }

        static void ErrorPrint()
        {
            Console.WriteLine("\nВведено неверное значение, попробуйте ещё раз.\n");
        }
    }
}