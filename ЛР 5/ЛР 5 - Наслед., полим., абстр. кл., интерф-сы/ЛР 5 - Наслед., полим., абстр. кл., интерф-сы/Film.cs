using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    class Film : IFilms
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _country;
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

        private double _budget;
        public double Budget
        {
            get
            {
                return _budget;
            }
            set
            {
                _budget = value;
            }
        }

        public string dima;

        virtual public void ShowCasting()
        {

        }

        public override string ToString()
        {
            return $"Фильм {Name}";
        }
    }
}
