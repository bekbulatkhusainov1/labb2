namespace ConsoleApp12
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длину основания треугольника: ");
            if (!double.TryParse(Console.ReadLine(), out double a) && a <= 0)
            {
                Console.WriteLine("Ошибка: введите корректное значение длины основания треугольника");
                return;
            }

            Console.WriteLine("Введите длину боковой стороны треугольника: ");
            if (!double.TryParse(Console.ReadLine(), out double b) && b <= 0)
            {
                Console.WriteLine("Ошибка: введите корректное значение длины боковой стороны треугольника");
                return;
            }

            if (b >= 2 * a)
            {
                Console.WriteLine("Ошибка: боковая сторона не может быть больше или равна удвоенной длине основания");
                return;
            }

            double height = Math.Sqrt(Math.Pow(a, 2) - Math.Pow(b / 2, 2));
            Console.WriteLine($"Высота треугольника, опущенная на основание, равна {height}");
        }
    }
}