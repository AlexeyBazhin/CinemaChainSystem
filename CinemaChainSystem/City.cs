using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChainSystem
{
    public class City
    {
        private int id;
        private string name;
        private string region;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Region { get => region; set => region = value; }

        public City()
        {
           
        }
        public City(int id, string name, string region)
        {
            ID = id;
            Name = name;
            Region = region;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            City source = (City)obj;
            //return city.ID == this.ID && city.Name == this.Name && city.Region == this.Region;
            return source.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"{Name}({Region})";
        }
    }
}
