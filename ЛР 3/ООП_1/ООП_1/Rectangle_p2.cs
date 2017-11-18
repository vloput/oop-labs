using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1
{
    partial class Rectangle
    {
        //Конструкторы
        public Rectangle(int x, int y = 1)
        {
            if (x > 0 && y > 0)
            {
                this.x = x;
                this.y = y;
            }
            numberOfObjects++;
            ID = GetHashCode();
        }

        static Rectangle()
        {
            Console.WriteLine("Создан первый прямоугольник.");
        }

        private Rectangle() { }

        //Переопределение методов
        public override int GetHashCode()
        {
            return Convert.ToInt32(Math.Exp(x) + y);
        }

        public override string ToString()
        {
            return $"Прямоугольник шириной {X} и высотой {Y}";
        }
    }
}
