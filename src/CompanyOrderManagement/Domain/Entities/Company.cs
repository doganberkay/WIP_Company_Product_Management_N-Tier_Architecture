using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company:Entity
    {
        public string CompanyName { get; set; }
        public bool OrderStatus { get; set; }
        public DateTime OrderPermDateStart { get; set; }
        public DateTime OrderPermDateFinish { get; set; }


        public Company()
        {

        }

        public Company(int id,string name, bool orderStatus, DateTime orderPermDateStart, DateTime orderPermDateFinish) : this()
        {
            Id = id;
            CompanyName = name;
            OrderStatus = orderStatus;
            OrderPermDateStart= orderPermDateStart;
            OrderPermDateFinish= orderPermDateFinish;
        }
    }
}
