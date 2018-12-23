using System;
using System.Collections;
using System.Linq;
using System.Text;
using static System.Math;

namespace lab2
{
    class Circle : Figure, Iprint
    {
        /// <summary>
        /// Радиус Круга 
        /// </summary>
        double radius;

        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }

        public override double Area()
        {
            double Result = PI * this.radius * this.radius;
            return Result;
        }

        /// <summary>
        /// Переопределение виртуального метода класса object, приведение всего этого безобразия к строке 
        /// </summary>
        public override string ToString()
        {
            return this.Type + "c радиусом " + this.radius.ToString() + 
                        " имеет площадь " + this.Area().ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
