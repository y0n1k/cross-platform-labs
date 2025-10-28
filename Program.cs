using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static double f(double x)
        {
            return x * x - 4;
        }

        public static double fp(double x, double D)
        {
            return (f(x + D) - f(x)) / D;
        }

        public static double f2p(double x, double D)
        {
            return (f(x + D) + f(x - D) - 2.0 * f(x)) / (D * D);
        }

        public static double Bisection(double a, double b, double eps)
        {
            int Lich = 0;
            double c;

            if (f(a) * f(b) > 0)
            {
                Console.WriteLine("No solution on the interval!");
                return double.NaN;
            }

            while (Math.Abs(b - a) > eps)
            {
                c = 0.5 * (a + b);
                Lich++;

                if (Math.Abs(f(c)) < eps)
                {
                    Console.WriteLine($"MDN: x = {c:F10}, iterations = {Lich}");
                    return c;
                }

                if (f(a) * f(c) < 0)
                    b = c;
                else
                    a = c;
            }

            double result = (a + b) / 2;
            Console.WriteLine($"MDN: x = {result:F10}, iterations = {Lich}");
            return result;
        }

        public static double Newton(double a, double b, double eps, int Kmax, double d)
        {
            double x, Dx;
            int i;

            x = b;

            if (f(x) * f2p(x, d) < 0)
                x = a;

            if (f(x) * (2 * x) <= 0)
            {
                Console.WriteLine("Newton method is not guaranteed!");
            }

            for (i = 1; i <= Kmax; i++)
            {
                Dx = f(x) / fp(x, d);
                x = x - Dx;

                if (Math.Abs(Dx) < eps)
                {
                    Console.WriteLine($"NM: x = {x:F10}, iteration = {i}");
                    return x;
                }
            }

            Console.WriteLine("Solution was not found");
            return double.NaN;
        }

        static void Main(string[] args)
        {
            double a, b, eps, d;
            int Kmax;
            int q = 0;

            Console.WriteLine("f(x) = x^2 - 4\n");

            while (q == 0)
            {
                Console.Write("Enter a: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter b: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter aAccuracy Eps: ");
                eps = Convert.ToDouble(Console.ReadLine());
                d = eps / 100;

                Console.Write("Enter max iteration for NM: ");
                Kmax = int.Parse(Console.ReadLine());

                Console.WriteLine("\nSelect method:");
                Console.WriteLine("1 - MDN");
                Console.WriteLine("2 - NM");
                Console.WriteLine("3 - quit");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Bisection(a, b, eps);
                        break;

                    case 2:
                        Newton(a, b, eps, Kmax, d);
                        break;

                    case 3:
                        Console.WriteLine("Quitting");
                        q = 1;
                        break;

                    default:
                        Console.WriteLine("Wrong!");
                        break;
                }
            }
        }
    }
}
