using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{

    [Serializable]
    public class NoFilmsFindedException : WrongInputException
    {
        public NoFilmsFindedException() { }
        public NoFilmsFindedException(string message) : base(message) { }
        public NoFilmsFindedException(string message, Exception inner) : base(message, inner) { }
        protected NoFilmsFindedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
