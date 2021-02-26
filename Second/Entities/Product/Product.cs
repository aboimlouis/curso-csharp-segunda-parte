using System;
using System.Collections.Generic;
using System.Text;

namespace Second.Entities.Product
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(Price);
            return sb.ToString();
        }
    }
}
