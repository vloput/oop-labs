using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    class FeatureFilm : Film
    {
        private string _casting;
        public string Casting
        {
            get
            {
                return _casting;
            }
            set
            {
                _casting = value;
            }
        }

        public override void ShowCasting()
        {
            Console.WriteLine($"Актёрский состав: {Casting}");
        }

        public override string ToString()
        {
            return $"Художественный фильм {Name}";
        }
    }
}
