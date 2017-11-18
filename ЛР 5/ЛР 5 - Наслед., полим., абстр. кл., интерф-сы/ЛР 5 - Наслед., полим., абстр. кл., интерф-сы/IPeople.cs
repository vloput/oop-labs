using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    interface IPeople
    {
        string FirstName { get; set; }
        string Surname { get; set; }
        void Show();
    }
}
