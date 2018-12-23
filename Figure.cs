using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace lab2
{
    public abstract class Figure
    {
        /// <summary>
        /// Тип фигуры 
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        /// <summary>
        /// Вычисление площади фигуры 
        /// </summary>
        public abstract double Area();
    }
}
