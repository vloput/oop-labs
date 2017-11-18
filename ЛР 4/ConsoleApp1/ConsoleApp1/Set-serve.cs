using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Set
    {
        public static bool operator <(int ignoreThis, Set ignoreThisToo)     //Служебная функция
        {
            Console.WriteLine("Служебная функция");
            return false;
        }

        public static bool operator >(Set ignoreThis, Set ignoreThisToo)     //Служебная функция
        {
            Console.WriteLine("Служебная функция");
            return false;
        }
    }
}