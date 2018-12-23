using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace lab2
{
    class Square : Rectangle, Iprint
    {
        public Square(double side) : base(side, side)
        {
            this.Type = "Квадрат";
        }
    }
}
