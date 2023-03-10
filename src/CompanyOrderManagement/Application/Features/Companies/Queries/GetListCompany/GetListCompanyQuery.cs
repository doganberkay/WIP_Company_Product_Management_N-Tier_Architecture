using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Companies.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Companies.Queries.GetListCompany
{
    public class GetListCompanyQuery:IRequest<CompanyListModel>
    {

        public PageRequest PageRequest { get; set; }
        public class GetListCompanyQueryHandler:IRequestHandler<GetListCompanyQuery,CompanyListModel>
        {
            private readonly ICompanyRepository _companyRepository;
            private readonly IMapper _mapper;

            public GetListCompanyQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
            {
                _companyRepository = companyRepository;
                _mapper = mapper;
            }
            public async Task<CompanyListModel> Handle(GetListCompanyQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Company> companies = await _companyRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                CompanyListModel mappedCompanyListModel = _mapper.Map<CompanyListModel>(companies);
                return mappedCompanyListModel;
            }
        }
    }
}
