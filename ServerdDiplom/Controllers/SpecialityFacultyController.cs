using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialityFacultyController : ControllerBase
    {
        private readonly ISpecialityFacultyService _specialityFacultyService;


        public SpecialityFacultyController(ISpecialityFacultyService specialityFacultyService)
        {
            _specialityFacultyService = specialityFacultyService;
        }


        [HttpGet("GetAllSpecialityFaculty")]
        public async Task<IActionResult> GetAllSpecialityFaculty()
        {
            try
            {
                var response = await _specialityFacultyService.GetAllSpecialityFaculty();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddSpecialityFaculty")]
        public async Task<IActionResult> AddSpecialityFaculty([FromBody] SpecialityFacultyDTO specialityFacultyDTO)
        {
            try
            {


                var response = await _specialityFacultyService.AddSpecialityFaculty(specialityFacultyDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("DeleteSpecialityFaculty")]
        public async Task<IActionResult> DeleteSpecialityFaculty([FromBody] DeleteSpecialityFacultyDTO deleteSpecialityFacultyDTO)
        {
            try
            {
                if (deleteSpecialityFacultyDTO.SpecialityId > 0 && deleteSpecialityFacultyDTO.FacultysId > 0)
                {
                    var response = await _specialityFacultyService.DeleteSpecialityFaculty(deleteSpecialityFacultyDTO);
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
