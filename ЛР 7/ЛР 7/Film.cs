using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{
    class Film : TVProgram
    {
        private string _director;

        public string Director { get => _director; set => _director = value; }
    }
}
