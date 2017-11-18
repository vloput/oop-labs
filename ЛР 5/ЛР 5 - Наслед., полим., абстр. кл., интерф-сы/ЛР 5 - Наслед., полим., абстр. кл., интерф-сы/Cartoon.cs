using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    class Cartoon : Film
    {
        private string _voices;
        public string Voices
        {
            get
            {
                return _voices;
            }
            set
            {
                _voices = value;
            }
        }

        

        public override void ShowCasting()
        {
            Console.WriteLine($"Озвучка: {Voices}");
        }

        public override string ToString()
        {
            return $"Мультфильм {Name}";
        }
    }
}
