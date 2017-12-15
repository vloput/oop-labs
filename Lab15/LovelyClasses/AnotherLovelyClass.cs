using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovelyClasses
{
    public class AnotherLovelyClass : ISpeak
    {
        string words = "Yeah,I'm lovelu too!";

        public string Speak()
        {
            return words;
        }
    }
}
