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
    public class AdmissionController : ControllerBase
    {
        private readonly IMasterService<Admission> master;
        private readonly IMapper mapper;

        public AdmissionController(IMasterService<Admission> master, IMapper mapper)
        {
            this.mapper = mapper;
            this.master = master;
        }
        [HttpGet("GetData")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Admission>))]
        public async Task<IActionResult> GetDate()
        {
            try
            {
                var result = await master.GetAll();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("PostData")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Admission))]
        public async Task<IActionResult> PostData(AdmissionDto data)
        {
            try
            {
                var result =  mapper.Map<Admission>(data);
                await master.AddData(result);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteData")]
        public async Task<IActionResult> DeleteData(int id)
        {
            try
            {
                await master.Delete(id);
                return Ok("Deleted succesfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        
        [HttpPut("UpdateData")]
        public async Task<IActionResult> UpdateData(Admission data)
        {
            try
            {
                await master.Update(data);
                return Ok("Data updated succesfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
