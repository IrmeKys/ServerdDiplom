using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly IFacultyService _facultyService;


        public FacultyController(IFacultyService facultyService)
        {
            _facultyService = facultyService;
        }


        [HttpGet("GetAllFaculty")]
        public async Task<IActionResult> GetAllFaculty()
        {
            try
            {
                var response = await _facultyService.GetAllFaculty();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddFaculty")]
        public async Task<IActionResult> AddFaculty([FromBody] FacultyDTO facultyDTO)
        {
            try
            {


                var response = await _facultyService.AddFaculty(facultyDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateFaculty")]
        public async Task<IActionResult> UpdateFaculty([FromBody] UpdateFacultyDTO updatefacultyDTO)
        {
            try
            {

                var response = await _facultyService.UpdateFaculty(updatefacultyDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeleteFaculty")]
        public async Task<IActionResult> DeleteFaculty([FromBody] DeleteFacultyDTO deleteFacultyDTO)
        {
            try
            {
                if (deleteFacultyDTO.Id > 0)
                {
                    var response = await _facultyService.DeleteFaculty(deleteFacultyDTO);
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
