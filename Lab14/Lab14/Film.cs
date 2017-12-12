using System;
using System.Runtime.Serialization;

namespace Lab14
{
    [DataContract]
    [Serializable]
    public class Film
    {
        private string _name;
        private string _country;
        private double _budget;

        [DataMember]
        public string Name { get => _name; set => _name = value; }
        public string Country { get => _country; set => _country = value; }
        public double Budget { get => _budget; set => _budget = value; }

        public virtual void ShowCasting()
        {

        }

        public override string ToString()
        {
            return $"Фильм {Name}";
        }
    }
}
