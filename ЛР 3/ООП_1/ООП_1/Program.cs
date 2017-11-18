using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Анонимный тип
            var circle = new { radius = 5 };
            Console.WriteLine($"Анонимный тип circle с параметром radius = {circle.radius}");
            Console.WriteLine("Нажмите любую клавишу для создания массива объектов.");
            Console.Read();

            //Массив объектов
            int Squares = 0;
            int[] indexesOfSquares = new int[10];
            Rectangle[] rect = new Rectangle[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                rect[i] = new Rectangle(rand.Next(minValue: 1, maxValue: 20), rand.Next(minValue: 1, maxValue: 20));
                if (rect[i].X == rect[i].Y)
                {
                    indexesOfSquares[Squares] = i;
                    Squares++;
                }
            }

            Console.WriteLine("Создан массив объектов:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Прямоугольник #{i} шириной {rect[i].X} и высотой" +
                    $" {rect[i].Y}. Хеш объекта: {rect[i].GetHashCode()}");
                Console.WriteLine($"    Площадь = {rect[i].getArea()}," +
                $" периметр = {rect[i].getPerimeter()}");
            }

            Console.WriteLine($"Количество квадратов = {Squares}");
            Console.WriteLine("Количество прямоугольников = " + (10 - Squares));

            //Нахождение наибольшего и наименьшего
            //Среди квадратов:
            if (Squares != 0)
            {
                int minimal = rect[indexesOfSquares[0]].getArea();
                int maximal = rect[indexesOfSquares[0]].getArea();
                int minIndex = indexesOfSquares[0];
                int maxIndex = minIndex;

                for (int i = 1; i < Squares; i++)
                {
                    if (minimal > rect[indexesOfSquares[i]].getArea())
                    {
                        minimal = rect[indexesOfSquares[i]].getArea();
                        minIndex = indexesOfSquares[i];
                    }
                }
                for (int i = 1; i < Squares; i++)
                {
                    if (maximal < rect[indexesOfSquares[i]].getArea())
                    {
                        maximal = rect[indexesOfSquares[i]].getArea();
                        maxIndex = indexesOfSquares[i];
                    }
                }

                Console.WriteLine($"Наименьшая площадь у квадрата #{minIndex}");
                Console.WriteLine($"Наибольшая площадь у квадрата #{maxIndex}");
            }
            

            //Метод: является ли элемент членом массива
            bool isPartOfArray(int element, int[] array, int arraySize)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    if (element == array[i])
                    {
                        return true;
                    }
                }
                return false;
            }

            //Среди прямоугольников
            if (Squares < 10)
            {

                int indexOfMinArea = 0;
                int minArea = rect[0].getArea();
                int indexOfMaxArea = 0;
                int maxArea = rect[0].getArea();

                for (int i = 1; i < 10; i++)
                {
                    if (isPartOfArray(i, indexesOfSquares, 10))
                    {
                        continue;
                    }
                    if (minArea > rect[i].getArea())
                    {
                        minArea = rect[i].getArea();
                        indexOfMinArea = i;
                    }
                }
                for (int i = 1; i < 10; i++)
                {
                    if (isPartOfArray(i, indexesOfSquares, 10))
                    {
                        continue;
                    }
                    if (maxArea < rect[i].getArea())
                    {
                        maxArea = rect[i].getArea();
                        indexOfMaxArea = i;
                    }
                }
                Console.WriteLine($"Наименьшая площадь у прямоугольника #{indexOfMinArea}");
                Console.WriteLine($"Наибольшая площадь у прямоугольника #{indexOfMaxArea}");
            }
        }
    }
}