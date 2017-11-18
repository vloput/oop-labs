using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    class Data
    {
        uint day;
        uint mounth;
        uint year;

        public uint Day
        {
            get => day;
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public uint Mounth
        {
            get => mounth;
            set
            {
                if (value >= 1 && value <= 12)
                {
                    mounth = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public uint Year
        {
            get => year;
            set
            {
                if (!value.ToString().Contains('.'))
                {
                    year = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
