using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    abstract class Television : IVideo
    {
        int IVideo.Year { get; set; }
        abstract public void Show();
    }
}
