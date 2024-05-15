using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model.UpdateDTO;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComissionNumberController : ControllerBase
    {
        private readonly IComissionNumberService _comissionNumber;


        public ComissionNumberController(IComissionNumberService comissionNumber)
        {
            _comissionNumber = comissionNumber;
        }


        [HttpGet("GetAllComissionNumber")]
        public async Task<IActionResult> GetAllComissionNumber()
        {
            try
            {
                var response = await _comissionNumber.GetAllComissionNumber();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddNumber")]
        public async Task<IActionResult> AddNumber([FromBody] ComissionNumberDTO comissionNumberDTO)
        {
            try
            {


                var response = await _comissionNumber.AddNumber(comissionNumberDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateNumber")]
        public async Task<IActionResult> UpdateNumber([FromBody] UpdateComissionNumberDTO updateComissionNumberDTO)
        {
            try
            {

                var response = await _comissionNumber.UpdateNumber(updateComissionNumberDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeleteNumber")]
        public async Task<IActionResult> DeleteNumber([FromBody] DeleteComissionNumberDTO deleteComissionNumberDTO)
        {
            try
            {
                if (deleteComissionNumberDTO.Id > 0)
                {
                    var response = await _comissionNumber.DeleteNumber(deleteComissionNumberDTO);
                    return Ok(response);

                }
                else
                {
                    return BadRequest("Please pass score Id");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
