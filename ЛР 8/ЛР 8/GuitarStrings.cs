using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    class Strings<T> : IStrings<T>
    {

        public Strings(int amount, T material)
        {
            if (amount > 0)
            {
                _amount = amount;
            }
            else
            {
                Console.WriteLine("Число струн не может быть меньше 1");
            }

            _material = material;
        }

        public Strings(int amount, T material, params double[] thickness)
        {
            if (amount > 0)
            {
                _amount = amount;
            }
            else
            {
                Console.WriteLine("Число струн не может быть меньше 1");
            }

            _material = material;

            for (int i = 0; i < thickness.Length; i++)
            {
                ListOfStrings.Add(thickness[i]);
            }
        }

        protected T _material;
        protected int _amount;


        public T Material { get => _material; set => _material = value; }
        public int Amount { get => _amount; set => _amount = value; }

        protected List<double> ListOfStrings = new List<double>();

        public void AddString(double thickness)
        {
            if (ListOfStrings.Count < _amount)
            {
                ListOfStrings.Add(thickness);
                Console.WriteLine($"Струна {thickness} добавлена.");
            }
            else
            {
                Console.WriteLine("Не удаётся добавить струну: комплект собран.");
            }

            Console.WriteLine();
        }

        public void RemoveString(int stringIndex)
        {
            if (stringIndex > 0 && stringIndex < ListOfStrings.Count)
            {
                ListOfStrings.RemoveAt(stringIndex);
                Console.WriteLine("Струна удалена.");
            }
            else
            {
                Console.WriteLine("Струны с таким индексом не существует.");
            }
        }

        public void ShowStrings()
        {
            if (_material is int)
            {
                Console.WriteLine($"Код материала струн - {_material}");
            }
            else
            {
                Console.WriteLine($"Материал струн - {_material}");
            }

            for (int i = 0; i < ListOfStrings.Count; i++)
            {
                Console.WriteLine($"Струна #{i + 1} толщиной {ListOfStrings[i]}");
            }
            Console.WriteLine();
        }
    }
}
