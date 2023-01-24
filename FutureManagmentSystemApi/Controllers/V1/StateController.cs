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
    public class StateController : ControllerBase
    {
        private readonly IMasterService<State> master;
        private readonly IMapper mapper;
        public StateController(IMasterService<State> master, IMapper mapper)
        {
            this.master = master;
            this.mapper = mapper;
        }
        [HttpPost("PostState")]

        public async Task<IActionResult> PostState(StateDto dto)
        {
            try
            {
                var result= mapper.Map<State>(dto);
              await master.AddData(result);
                return Ok("Data posted");

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
