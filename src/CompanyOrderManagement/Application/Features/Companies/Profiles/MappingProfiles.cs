using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Companies.Commands.CreateCompany;
using Application.Features.Companies.Dtos;
using Application.Features.Companies.Models;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Companies.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Company, CreatedCompanyDto>().ReverseMap();
            CreateMap<Company, CreateCompanyCommand>().ReverseMap();
            CreateMap<IPaginate<Company>, CompanyListModel>().ReverseMap();
            CreateMap<Company,CompanyListDto>().ReverseMap();
        }
    }
}
