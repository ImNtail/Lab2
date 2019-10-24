using System;

namespace Lab2
{
    class Program
    {
        public static long Factorial(long factorial)
        {
            long temp = factorial, fct = 1;
            for (long i = 1; i < temp; temp--)
                fct *= temp;
            return fct;
        }
        static void Main(string[] args)
        {
            /*
            1. Написать программу для решения квадратного уравнения ax^2 +bx+c=0 . Числа
            a, b и c вводятся с клавиатуры. Если уравнение имеет два действительных
            корня, программа должна вывести оба корня на экран; если один корень –
            вывести только один; если уравнение не имеет действительных корней, то
            вывести результат в виде записи двух комплексных чисел: x+iy и x–iy .
            */

            /*
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant == 0)
            {
                double x = -b / 2 / a;
                Console.WriteLine("The root of the equation x = {0}", x);
                Console.ReadKey();
            }
            else 
            if (discriminant < 0)
            {
                double x = -b / 2 / a;
                double imaginaryY = Math.Sqrt(Math.Abs(discriminant)) / 2 / a;
                Console.WriteLine("The roots of the equation: x1 = {0} + {1}i and x2 = {0} - {1}i", x, imaginaryY);
                Console.ReadKey();
            }
            else
            {
                double x1 = (-b - Math.Sqrt(discriminant))/ 2 / a;
                double x2 = (-b + Math.Sqrt(discriminant)) / 2 / a;
                Console.WriteLine("The roots of the equation: x1 = {0} and x2 = {1}", x1, x2);
                Console.ReadKey();
            }
            */


            /*
            2. Написать программу для приближенного вычисления числа π на основе
            следующей формулы (количество слагаемых ввести с клавиатуры)
            */

            /*
            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("The number cannot be equal or less then 0!");
                Console.ReadKey();
            }
            else
            {
                double Pi = 1;
                for (double i = 1, q = 3; i <= n; i++, q += 2)
                {
                    Console.WriteLine("q = " + q);
                    Console.WriteLine("i = " + i);
                    if (i % 2 != 0)
                    {
                        Pi -= 1 / q;
                        Console.WriteLine("Pi = " + Pi);
                    }
                    if (i % 2 == 0)
                    {
                        Pi += 1 / q;
                        Console.WriteLine("Pi = " + Pi);
                    }
                }
                Pi *= 4;
                Console.WriteLine("Pi = " + Pi);
                Console.ReadKey();
            */


            /*
            3. Написать программу, которая определяет количество четырехзначных чисел
            в ряде Фибоначчи. Ряд Фибоначчи ( 1, 1, 2, 3, 5, 8, 13, 21, … ) – это такая
            последовательность натуральных чисел, каждый член которой является
            суммой предыдущих двух (первые два члены равны 1)
            */


            /*
            Console.Write("Enter the number of numbers: ");
            uint NumOfNums = uint.Parse(Console.ReadLine());
            uint f0 = 1, f1 = 1, fi = 0, k = 0;
            for (uint i = 0; i < NumOfNums; i++)
            {
                fi = f0 + f1;
                f0 = f1;
                f1 = fi;
                if (fi>999 && fi<10000)
                k++;
            }
            Console.WriteLine("The number of four-digit numbers is " + k);
            Console.ReadKey();
            */


            /*
            4. Написать программу для вычисления приближенного значения cos(x) на
            основе формулы ряда Тейлора (необходимо ввести с клавиатуры числа х и
            q; если значение по модулю очередного слагаемого окажется меньше q, то
            расчет суммы нужно остановить, на экран надо вывести также количество
            учтенных слагаемых)
            */

            /*
            Console.Write("Enter the angle in radians: ");
            double angle = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of terms: ");
            int q = int.Parse(Console.ReadLine());
            double cosX = 1;
            for (int i = 0, grade = 2; i < q; i++, grade += 2)
            {
                int f = grade;
                int n = i + 1;
                if (n % 2 == 0)
                    cosX += Math.Pow(angle, grade) / Factorial(f);

                if (n % 2 != 0)
                    cosX -= Math.Pow(angle, grade) / Factorial(f);
            }
            Console.WriteLine("Cos of angle is {0: 0.###}", cosX);
            Console.ReadKey();
            */


            /*
            5. Написать программу, которая позволяет ввести с клавиатуры натуральное
            число N и вывести на экран все комбинации натуральных чисел x, y, z,
            таких что x^3 + y^3 + z^3 = N . Если число N невозможно разложить по кубам x, y, z,
            программа должна выводить сообщение «No such combinations!».
            */

            /*
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int x = 0, y = 0, z = 0;
            bool solution = false;
            for (x = 0; x <= n; x++)
            {
                for (y = 0; y <= n; y++)
                {
                    for (z = 0; z <= n; z++)
                    {
                        if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == n)
                        {
                            Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);
                            solution = true;
                        }
                    }
                }
            }
            if (solution == false)
                Console.WriteLine("No such combinations!");
            Console.ReadKey();
            */


            /*
            6. Написать программу, которая позволяет ввести с клавиатуры число N от 1
            до 100 и вывести на экран грамматически верную фразу вида « N [лет | год |
            года] ». Например: «21 год», «32 года», «57 лет» и т.д.
            */

            /*
            Console.Write("Enter the number from 1 to 100: ");
            int year = int.Parse(Console.ReadLine());
            while (year <= 1 && year >= 100)
            {
                Console.Write("Uncorrect number! Please try again: ");
                year = int.Parse(Console.ReadLine());
            }
                if (year % 10 == 1)
                    Console.WriteLine(year + " год");
                if (year % 10 > 1 && year % 10 < 5)
                    Console.WriteLine(year + " года");
                if (year % 10 > 4 && year % 10 < 10 || year % 10 == 0)
                    Console.WriteLine(year + " лет");
            Console.ReadKey();
            */


            //individual
            /*
            1. Ввести с экрана координаты точки (2 вещественных числа). Если хотя бы одна из
            координат равна 0, вывести на экран число 0. Иначе – вывести на экран номер четверти, в
            которой находится точка.
            */

            /*
            Console.WriteLine("Enter the point coordinates: ");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            if (x == 0 || y == 0)
                Console.WriteLine("0");
            else
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("The point is in the first quarter.");
                if (x < 0 && y > 0)
                    Console.WriteLine("The point is in the second quarter.");
                if (x < 0 && y < 0)
                    Console.WriteLine("The point is in the third quarter.");
                if (x > 0 && y < 0)
                    Console.WriteLine("The point is in the fourth quarter.");
            }
            Console.ReadKey();
            */

            /*
            2.Ввести число от 1 до 10000.Вывести на экран все четные делители числа.
            */

            /*
            Console.Write("Enter the number from 1 to 10000: ");
            int x = int.Parse(Console.ReadLine());
            while (x < 1 || x > 10000)
            {
                    Console.Write("Uncorrect number! Please try again: ");
                    x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            bool exist = false;
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0 && x % i == 0)
                {
                    Console.WriteLine(i);
                    exist = true;
                }
            }
            if (exist == false)
                Console.WriteLine("There are no dividers of the entered number.");
            Console.ReadKey();
            */
        }
    }
}
