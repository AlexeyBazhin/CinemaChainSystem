using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChainSystem
{
    public class Hall
    {
        private int id;
        private int number;
        private string description;
        private int rowsCount;
        private int placesInARow;
        private int cinemaID;

        public int ID { get => id; set => id = value; }
        public int Number { get => number; set => number = value; }
        public string Description { get => description; set => description = value; }
        public int RowsCount { get => rowsCount; set => rowsCount = value; }
        public int PlacesInARow { get => placesInARow; set => placesInARow = value; }
        public int CinemaID { get => cinemaID; set => cinemaID = value; }

        public Hall()
        {

        }
        public Hall(int id, int number, string description, int rowsCount, int placesInARow, int cinemaID)
        {
            ID = id;
            Number = number;
            Description = description;
            RowsCount = rowsCount;
            PlacesInARow = placesInARow;
            CinemaID = cinemaID;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Hall source = (Hall)obj;
            return source.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"Зал №{number}";
        }
    }
}
