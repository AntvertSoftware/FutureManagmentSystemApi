using AutoMapper;
using FutureManagmentSystemApi.Models.Bussiness;
using FutureManagmentSystemApi.Models.Dtos;
using FutureManagmentSystemApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutureManagmentSystemApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IMasterService<City> master;
        private readonly IMapper mapper;
        public CityController(IMasterService<City> master, IMapper mapper)
        {
            this.master = master;
            this.mapper = mapper;
        }
        [HttpPost("Post City")]

        public async Task<IActionResult> PostCity(CityDto dto)
        {
            try
            {
                var result= mapper.Map<City>(dto);
                master.AddData(result);
                return Ok("Posted succesfully");
            }
            catch(Exception xc)
            {
                return BadRequest(xc.Message);
            }
        }
    }
}
