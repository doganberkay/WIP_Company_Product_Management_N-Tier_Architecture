using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Domain.Entities;

namespace Application.Features.Companies.Rules
{
    public class CompanyBusinessRules
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyBusinessRules(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task CompanyNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Company> result = await _companyRepository.GetListAsync(b => b.CompanyName == name);
            if (result.Items.Any()) throw new BusinessException("Company name exists.");
        }
    }
}
