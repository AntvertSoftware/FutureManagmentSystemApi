using FutureManagmentSystemApi.Models.Bussiness;
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

        public AdmissionController(IMasterService<Admission> master)
        {
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
        public async Task<IActionResult> PostData(Admission data)
        {
            try
            {
                await master.AddData(data);
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
