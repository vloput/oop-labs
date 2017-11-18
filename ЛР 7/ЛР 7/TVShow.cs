using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{
    class TVShow : TVProgram
    {
        private string _showman;

        public string Showman { get => _showman; set => _showman = value; }
    }
}
