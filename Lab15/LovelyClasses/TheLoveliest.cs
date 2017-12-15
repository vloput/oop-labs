using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovelyClasses
{
    public class TheLoveliest : ISpeak
    {
        string speach = "I'm the loveliest class!";

        public string Speak()
        {
            return speach;
        }
    }
}
