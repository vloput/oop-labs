using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ЛР_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings<string> acousticGuitarStrings = new Strings<string>(6, "Бронза");
            acousticGuitarStrings.AddString(0.11);
            acousticGuitarStrings.AddString(0.14);
            acousticGuitarStrings.AddString(0.18);
            acousticGuitarStrings.AddString(0.3);
            acousticGuitarStrings.AddString(0.42);
            acousticGuitarStrings.AddString(0.52);

            acousticGuitarStrings.ShowStrings();

            Strings<int> banjoStrings = new Strings<int>(5, 463, 0.009, 0.01, 0.013, 0.02, 0.009);
            banjoStrings.ShowStrings();

            StringForMachine<int> bassStrings = new StringForMachine<int>(4, 231, 0.50, 0.70, 0.85, 1.05);
            bassStrings.ShowStrings();
            bassStrings.makeStrings();

            StringForMachine<int> violinStrings = new StringForMachine<int>(4, 583);
            violinStrings.makeStrings();

            //Запись в файл
            StreamWriter file = new StreamWriter("D:\\strings.txt");


        }
    }
}
