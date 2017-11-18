using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    class TVProgram : Television, IPeople
    {
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

        private string _firstName;
        private string _surname;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public void whoIsShowman()
        {
            Console.WriteLine($"Ведущий программы - {FirstName} {Surname}.");
        }

        public override void Show()
        {
            Console.WriteLine($"В эфире программа \"{Name}!\"");
        }

        public override string ToString()
        {
            return $"Телепрограмма {Name}";
        }
    }
}
