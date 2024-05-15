using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityFacultyController : ControllerBase
    {
        private readonly IUniversityFacultyService _universityFacultyService;


        public UniversityFacultyController(IUniversityFacultyService universityFacultyService)
        {
            _universityFacultyService = universityFacultyService;
        }


        [HttpGet("GetAllUniversityFaculty")]
        public async Task<IActionResult> GetAllUniversityFaculty()
        {
            try
            {
                var response = await _universityFacultyService.GetAllUniversityFaculty();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

   
        [HttpPost("AddUniversityFaculty")]
        public async Task<IActionResult> AddUniversityFaculty([FromBody] UniversityFacultyDTO universityFacultyDTO)
        {
            try
            {


                var response = await _universityFacultyService.AddUniversityFaculty(universityFacultyDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("DeleteUniversityFaculty")]
        public async Task<IActionResult> DeleteUniversityFaculty([FromBody] DeleteUniversityFacultyDTO deleteUniversityFacultyDTO)
        {
            try
            {
                if (deleteUniversityFacultyDTO.FacultyId > 0 && deleteUniversityFacultyDTO.UniversityId>0)
                {
                    var response = await _universityFacultyService.DeleteUniversityFaculty(deleteUniversityFacultyDTO);
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
