using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : Entity
    {
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(int id, string productName, int stock, double price)
        {
            Id = id;
            ProductName = productName;
            Stock = stock;
            Price = price;
        }
    }
}
