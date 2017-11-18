using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1
{
    partial class Rectangle
    {
        //Поля
        private int x;
        private int y;
        private static int numberOfObjects = 0;
        public readonly int ID;

        //Свойства
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (X > 0)
                {
                    x = X;
                }
                else
                {
                    Console.WriteLine("Ширина задана неверно.");
                }
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (Y > 0)
                {
                    y = Y;
                }
                else
                {
                    Console.WriteLine("Высота задана неверно.");
                }
            }
        }
        public static int NumberOfObjects
        {
            get
            {
                return numberOfObjects;
            }
        }

        //Методы
        public int getArea()
        {
            return x * y;
        }

        public int getPerimeter()
        {
            return (x * 2) + (y * 2);
        }

        public static void getClassInfo()
        {
            Console.WriteLine($"Из класса Rectangle создано {NumberOfObjects} экземпляров.");
        }

        public void calculatePerimeter(ref int x, ref int y, out int Perimeter)
        {
            Perimeter = (2 * x) + (2 * y);
        }
    }
}