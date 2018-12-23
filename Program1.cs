using System;
using System.Collections;
using System.Linq;
using System.Text;
using static System.Math;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.WriteLine("Введите тип фигуры, площадь которой вы хотите найти:\n" +
                                 "1 - Прямоугольник\n" + "2 - Квадрат\n" + "3 - круг\n" + "0 - выход из программы");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.Write("Введите Высоту и ширину: ");
                        Rectangle rect = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                        rect.Print();
                        break;

                    case 2:
                        Console.Write("Введите сторону квадрата: ");
                        Square sq = new Square(double.Parse(Console.ReadLine()));
                        sq.Print();
                        break;

                    case 3:
                        Console.Write("Введите радиус: ");
                        Circle cir = new Circle(double.Parse(Console.ReadLine()));
                        cir.Print();
                        break;
                    case 0:
                        break;
                    default:
                        Console.Write("Вы ввели некорректный символ, попробуйте снова: ");
                        n = int.Parse(Console.ReadLine());
                        break;
                }

            } while (n != 0);

        }
    }
}
