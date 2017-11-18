using System;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    class Printer
    {
        virtual public void IAmPrinting(Television obj)
        {
            if (obj is News)
            {
                Console.WriteLine(obj.ToString()); ;
            }

            if (obj is Ad)
            {
                Console.WriteLine(obj.ToString());
            }

            if (obj is TVProgram)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
