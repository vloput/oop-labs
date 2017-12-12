using System;
using System.Runtime.Serialization;

namespace Lab14
{
    [DataContract]
    [Serializable]
    public class Cartoon : Film
    {

        string _voices;

        public Cartoon() { }
        
        public Cartoon(string name, string voices)
        {
            Name = name;
            _voices = voices;
        }

        [DataMember]
        public string Voices { get => _voices; set => _voices = value; }

        public override void ShowCasting()
        {
            Console.WriteLine($"Озвучка: {Voices}");
        }

        public override string ToString()
        {
            return $"Мультфильм {Name}";
        }
    }
}
