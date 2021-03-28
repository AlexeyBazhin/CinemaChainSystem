using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChainSystem
{
    class Ticket
    {
        private int id;
        private DateTime saleDate;
        private string status;
        private int placeID;

        public int ID { get => id; set => id = value; }
        public DateTime SaleDate { get => saleDate; set => saleDate = value; }
        public string Status { get => status; set => status = value; }        
        public int PlaceID { get => placeID; set => placeID = value; }

        public Ticket(int id, DateTime openingDate, string status, int placeID)
        {
            ID = id;
            SaleDate = openingDate;
            Status = status;
            PlaceID = placeID;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Ticket source = (Ticket)obj;
            return source.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"Номер билета:{ID}";
        }
    }
}
