using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_10
{
    class TV
    {
        string name;

        public TV(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
