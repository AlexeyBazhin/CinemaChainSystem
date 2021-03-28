using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChainSystem
{
    public class RatingSystem
    {
        private int id;
        private string name;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public RatingSystem()
        {
            
        }
        public RatingSystem(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            RatingSystem source = (RatingSystem)obj;
            return source.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
