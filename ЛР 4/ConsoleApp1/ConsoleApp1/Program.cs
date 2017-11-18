using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Set first = new Set(array);
            int[] array2 = { -2, -3, 123 };
            Set second = new Set(array2);

            //Проверка на подмножество
            if (first < second)
            {
                Console.WriteLine("second является подмножеством first");
            }
            else
            {
                Console.WriteLine("second не является подмножеством first");
            }

            //Проверка на принадлежность
            if (0 > first)
            {
                Console.WriteLine("Элемент принадлежит множеству.");
            }
            else
            {
                Console.WriteLine("Элемент не принадлежит множеству.");
            }

            //Проверка на пересечение
            if (first * second)
            {
                Console.WriteLine("Множества пересекаются.");
            }
            else
            {
                Console.WriteLine("Множества не пересекаются.");
            }

            Set my = new Set();
            int[] mm = (int[])first;

            Set.Owner owner = new Set.Owner(101, "Uladzislau", "BSTU");
            Console.WriteLine($"\nВладелец: ID: {owner.ID}, имя: {owner.Name}, " +
                $"организация: {owner.Organisation}");

            Set.Date date = new Set.Date("27.09.2017");
            
            Console.WriteLine($"Дата создания: {date.DateOfCreation}");

            Console.WriteLine($"Мощность первого множества = {MathObject.sizeOfSet(first)}");

            Console.WriteLine(MathObject.firstNumberFromString("Hello 10239 Vlad"));
        }
    }
}
