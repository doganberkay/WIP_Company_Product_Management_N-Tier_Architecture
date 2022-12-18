using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Companies.Dtos
{
    public class CompanyListDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public bool OrderStatus { get; set; }
        public DateTime OrderPermDateStart { get; set; }
        public DateTime OrderPermDateFinish { get; set; }
    }
}
