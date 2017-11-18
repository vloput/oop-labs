using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    sealed class News : Television
    {
        private string _chanel;
        public string Chanel
        {
            get { return _chanel; }
            set { _chanel = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _showsPerWeek;
        public int ShowsPerWeek
        {
            get { return _showsPerWeek; }
            set
            {
                if (value > 0)
                {
                    _showsPerWeek = value;
                }
            }
        }

        public override void Show()
        {
            Console.WriteLine($"It's {Name} on {Chanel}, {ShowsPerWeek} times a week!");
        }

        public override string ToString()
        {
            return $"Новости на канале \"{Chanel}\"";
        }
    }
}
