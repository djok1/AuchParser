using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuchParser
{
    class Listing
    {
        private int Price;
        private int Quantity;
        private string Name;
        private int ID;

        public Listing(int price, int quantity, string name, int id)
        {
            Price = price;
            Quantity = quantity;
            Name = name;
            ID = id;
        }
        public int getPrice()
        {
            return Price;
        }
        public int getQuantity()
        {
            return Quantity;
        }
        public int getID()
        {
            return ID;
        }
        public int pricePer()
        {
            return Price / Quantity;
        }
        public string getName()
        {
            return Name;
        }
        public string listView()
        {
            return "Name:" + Name + " ID:" + ID + " Price GGSSCC:" + Price + " Quantity:"+ Quantity + " Price Per Item:"+ pricePer();
        }
    }
}
