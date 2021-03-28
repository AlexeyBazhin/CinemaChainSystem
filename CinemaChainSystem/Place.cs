using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChainSystem
{
    class Place
    {
        private int id;
        private int placeNumber;
        private int rowNumber;
        private int sessionID;

        public int ID { get => id; set => id = ID; }
        public int PlaceNumber { get => placeNumber; set => placeNumber = value; }
        public int RowNumber { get => rowNumber; set => rowNumber = value; }
        public int SessionID { get => sessionID; set => sessionID = value; }

        public Place(int id, int placeNumber, int rowNumber, int sessionID)
        {
            ID = id;
            PlaceNumber = placeNumber;
            RowNumber = rowNumber;
            SessionID = sessionID;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Place source = (Place)obj;
            return source.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"Место: {PlaceNumber} / Ряд: {RowNumber}";
        }
    }
}
