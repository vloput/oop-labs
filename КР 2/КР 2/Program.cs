using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data.Day = 17;
            data.Mounth = 11;
            data.Year = 2017;

            FullData full = new FullData();
            full.Day = 17;
            full.Mounth = 11;
            full.Year = 2017;
            full.Hour = 14;
            full.Minute = 18;

            Console.WriteLine(full.Equals(data));
        }
    }
}
