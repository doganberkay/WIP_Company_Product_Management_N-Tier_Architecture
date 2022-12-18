using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Companies.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.Companies.Models
{
    public class CompanyListModel:BasePageableModel
    {
        public IList<CompanyListDto> Items { get; set; }
    }
}
