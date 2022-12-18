using Application.Features.Companies.Commands.CreateCompany;
using Application.Features.Companies.Dtos;
using Application.Features.Companies.Models;
using Application.Features.Companies.Queries.GetListCompany;
using Core.Application.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCompanyCommand createCompanyCommand)
        {
            CreatedCompanyDto result = await Mediator.Send(createCompanyCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCompanyQuery getListCompanyQuery = new GetListCompanyQuery();
            CompanyListModel result = await Mediator.Send(getListCompanyQuery);
            return Ok(result);
        }
    }
}
