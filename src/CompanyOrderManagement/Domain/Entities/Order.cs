using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
    internal class Order:Entity
    {
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }

        public Order() { }

        public Order(int id, DateTime orderDate)
        {
            Id = id;
            OrderDate = orderDate;

        }
    }
}
