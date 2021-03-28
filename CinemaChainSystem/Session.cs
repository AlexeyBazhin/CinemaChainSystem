using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChainSystem
{
    public class Session
    {
        private int id;
        private DateTime date;
        private decimal price;
        private string type;
        private int filmID;
        private int hallID;

        public int ID { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public int FilmID { get => filmID; set => filmID = value; }    
        public int HallID { get => hallID; set => hallID = value; }

        public Session()
        {
            
        }
        public Session(DateTime date)
        {
            Date = date;
        }
        public Session(int id, DateTime date, decimal price, string type, int filmID, int hallID)
        {
            ID = id;
            Date = date;
            Price = price;
            Type = type;
            FilmID = filmID;
            HallID = hallID;
        }

        public int CompareTo(object obj)
        {
            
            Session p = (Session)obj;
            if (this.ID > p.ID) return 1;
            if (this.ID < p.ID) return -1;
            return 0;
            //return DateTime.Compare(this.Date, p.Date);
            //if (DateTime.S this.Date p.Date < 0) return 1;
            //if (this.Date < p.Date) return -1;            
            //return 0;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Session source = (Session)obj;
            return source.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"{date}";
        }
    }
}
