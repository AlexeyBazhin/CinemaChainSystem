using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaChainSystem
{
    public class Cinema
    {
        private int id;
        private string name;
        private string address;
        private string phone;
        private DateTime openingDate;
        private DateTime closingDate;
        private int cityID;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime OpeningDate { get => openingDate; set => openingDate = value; }
        public DateTime ClosingDate { get => closingDate; set => closingDate = value; }
        private int CityID { get => cityID; set => cityID = value; }

        public Cinema()
        {

        }
        public Cinema(int id, string name, string adress, string phone, DateTime openingDate, int cityID)
        {
            ID = id;
            Name = name;
            Address = adress;
            Phone = phone;
            OpeningDate = openingDate;
            CityID = cityID;
        }
        public Cinema(int id, string name, string adress, string phone, DateTime openingDate, DateTime closingDate, int cityID)
        {
            ID = id;
            Name = name;
            Address = adress;
            Phone = phone;
            OpeningDate = openingDate;
            ClosingDate = closingDate;
            CityID = cityID;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Cinema source = (Cinema)obj;
            return source.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"{Name}({Address})";
        }
    }
}
