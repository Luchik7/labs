using System;
using System.Collections;
using System.Text;
using System.Linq;


namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите коэффициенты для квадратного уравнения:");
            Trying(out a);
            Trying(out b);
            Trying(out c);
            Square(ref a, ref b, ref c);
        }


        public static void Square(ref double a, ref double b, ref double c)
        {
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("D > 0, уравнение имеет два корня:");
                Console.WriteLine("Первый корень уравнения - {0}", x1);
                Console.WriteLine("Второй корень уравнения - {0}", x2);
            }
            else if (d < 0)
            {
                Console.WriteLine("D < 0, действительных корней не существует");
            }
            else
            {
                double x = -b / 2 * a;
                Console.WriteLine("D = 0, единственный корень уравнения - {0}", x);
            }
        }

        public static void Trying(out double z)
        {
            try
            {
                z = double.Parse(Console.ReadLine());
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Вы ввели некорректный коэффициент, попробуйте снова");
                Console.WriteLine(e.Message);
                Console.Write("Введите коэффициент снова: ");
                z = double.Parse(Console.ReadLine());
            }

        }

    }
}



