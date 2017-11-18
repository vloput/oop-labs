using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{
    class TVProgram
    {
        private string _name;
        private int _dayWhenShown;
        private int _numberOfAds;
        private int _duration;
        private int _year;

        public string Name { get => _name; set => _name = value; }
        public int DayWhenShown { get => _dayWhenShown; set => _dayWhenShown = value; }
        public int Year
        {
            get => _year;
            set
            {
                try
                {
                    if (value >= 1850)
                    {
                        _year = value;
                    }
                    else
                    {
                        throw new WrongInputException("Неверный год.");
                    }
                }
                catch (WrongInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int NumberOfAds
        {
            get => _numberOfAds;
            set
            {
                if (value >= 0)
                {
                    _numberOfAds = value;
                }
            }
        }

        public int Duration { get => _duration; set => _duration = value; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
