using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    interface IStrings<T>
    {
        T Material { get; set; }
        int Amount { get; set; }

        void AddString(double thickness);
        void RemoveString(int stringNumber);
        void ShowStrings();
    }
}
