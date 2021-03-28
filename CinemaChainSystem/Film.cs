using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChainSystem
{
    public class Film
    {
        private int id;
        private string name;
        private int length;
        private string poster;
        private string description;
        private DateTime releaseDate;
        private int ratingID;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Length { get => length; set => length = value; }
        public string Poster { get => poster; set => poster = value; }
        public string Description { get => description; set => description = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public int RatingID { get => ratingID; set => ratingID = value; }

        public Film()
        {

        }
        public Film(int id, string name, int length, string poster, string description, DateTime releaseDate, int ratingID)
        {
            ID = id;
            Name = name;
            Length = length;
            Poster = poster;
            Description = description;
            ReleaseDate = releaseDate;
            RatingID = ratingID;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Film source = (Film)obj;
            return source.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"{Name} ({ReleaseDate.Year})";
        }
    }
}
