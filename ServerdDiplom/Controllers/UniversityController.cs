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
    public class UniversityController : ControllerBase
    {
        private readonly IUniversityService _universityService;


        public UniversityController(IUniversityService universityService)
        {
            _universityService = universityService;
        }


        [HttpGet("GetAllUniversity")]
        public async Task<IActionResult> GetAllUniversity()
        {
            try
            {
                var response = await _universityService.GetAllUniversity();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("GetUniversityByName")]
        public async Task<IActionResult> GetUniversityByName(string University_Name)
        {
            try
            {
                var response = await _universityService.GetUniversityByName(University_Name);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddUniversity")]
        public async Task<IActionResult> AddUniversity([FromBody] UniversityDTO universityDTO)
        {
            try
            {


                var response = await _universityService.AddUniversity(universityDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateUniversity")]
        public async Task<IActionResult> UpdateUniversity([FromBody] UpdateUniversityDTO updateUniversityDTO)
        {
            try
            {

                var response = await _universityService.UpdateUniversity(updateUniversityDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeleteUniversity")]
        public async Task<IActionResult> DeleteUniversity([FromBody] DeleteUniversityDTO deleteUniversityDTO)
        {
            try
            {
                if (deleteUniversityDTO.Id > 0)
                {
                    var response = await _universityService.DeleteUniversity(deleteUniversityDTO);
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
