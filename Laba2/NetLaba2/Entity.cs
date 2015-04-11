using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLaba2
{
    class Entity
    {
        private int id;
        private String name;
        private int count;
        private double price;

        public Entity() { }

        public Entity(String name, int count, double price)
        {
            id = 1;
            this.Name = name;
            this.Count = count;
            this.Price = price;
        }

        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public String Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Count
        {
            set { count = value; }
            get { return count; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
}
