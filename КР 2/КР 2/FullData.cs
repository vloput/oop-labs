using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    class FullData : Data
    {
        uint hour;
        uint minute;

        public uint Hour { get => hour; set => hour = value; }
        public uint Minute { get => minute; set => minute = value; }

        public override bool Equals(object obj)
        {
            if (obj as FullData != null)
            {
                FullData data = obj as FullData;

                return (Hour == data.Hour && Minute == data.Minute && Day == data.Day && Mounth == data.Mounth &&
                    Year == data.Year);
            }
            else if (obj as Data != null)
            {
                Data data = obj as Data;
                return (Day == data.Day && Mounth == data.Mounth && Year == data.Year);
            }
            return false;
        }
    }
}
