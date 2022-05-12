namespace HelloWorld
{
    static class Constant
    {
        public const double Pi = 3.14159;
    }

    class Program
    {
        public static (double, double) trianglesAreaAndPmWithLegs(double a, double b)
        {
            // Функция принимает катеты прямоугольного треугольника и возвращает его периметр и площадь. Задание 1.

            // Находим периметр и плозадь треугольника.
            double perimeter = a + b + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double area = a * b / 2;

            return (perimeter, area);
        }

        public static (double, double) trianglesAreaAndPmWithCoords(double ax, double ay, double bx, double by, double cx, double cy)
        {
            // Функция принимает координаты вершин прямоугольного треугольника и возвращает его периметр и площадь. Задание 2.

            // Находим длины сторон треугольника.
            double a = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double b = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            double c = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));

            // Находим периметр треугольника.
            double perimeter = a + b + c;

            // Находим полупериметр треугольника.
            double semiPerimeter = perimeter / 2;

            // Находим площадь треугольника.
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            return (perimeter, area);
        }

        public static (double, double) circleLengthAndAreaWithRadius(double R)
        {
            // Функция принимает радиус окружности и возвращает его длину и площадь. Задание 3.

            // Находим длину окружности.
            double length =  2 * Constant.Pi * R;

            // Находим площадь окружности.
            double area = Constant.Pi * Math.Pow(R, 2);

            return (length, area);
        }

        public static bool checkAmbiguityAndParity(double N)
        {
            // Функция принимает число и возвращает Истину, если оно четно и двузначно. В противном случае, Ложь. Задание 5.

            if (N % 2 == 0 && N/100 < 1)
            {
                return true;
            }
            
            return false;
            
        }

        public static bool checkEquilateralismOfTriangle(double a, double b, double c)
        {
            // Функция принимает длину сторон треугольника и возвращает Истину, если треугольник равносторонний. В противном случае, Ложь. Задание 6.

            if (a == b && b == c)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(checkEquilateralismOfTriangle(4, 2, 4));
            Console.ReadKey();
        }
    }
}