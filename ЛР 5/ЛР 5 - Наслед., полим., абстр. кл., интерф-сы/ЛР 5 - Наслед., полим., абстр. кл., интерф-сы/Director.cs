using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    class Director : IPeople
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private int _filmsAmount;
        public int FilmsAmount
        {
            get { return _filmsAmount; }
            set { _filmsAmount = value; }
        }

        public void Show()
        {
            Console.WriteLine("Об этом режиссёре пока нет фильма.");
        }

        public override string ToString()
        {
            return $"Режиссёр {FirstName} {Surname}";
        }
    }
}
