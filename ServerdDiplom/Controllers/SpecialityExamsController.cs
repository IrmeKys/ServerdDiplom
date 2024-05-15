using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialityExamsController : ControllerBase
    {
        private readonly ISpecialityExamsService _specialityExamsService;


        public SpecialityExamsController(ISpecialityExamsService specialityExamsService)
        {
            _specialityExamsService = specialityExamsService;
        }


        [HttpGet("GetAllSpecialityExams")]
        public async Task<IActionResult> GetAllSpecialityExams()
        {
            try
            {
                var response = await _specialityExamsService.GetAllSpecialityExams();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddSpecialityExams")]
        public async Task<IActionResult> AddSpecialityExams([FromBody] SpecialityExamsDTO specialityExamsDTO)
        {
            try
            {


                var response = await _specialityExamsService.AddSpecialityExams(specialityExamsDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("DeleteSpecialityExams")]
        public async Task<IActionResult> DeleteSpecialityExams([FromBody] DeleteSpecialityExamsDTO deleteSpecialityExamsDTO)
        {
            try
            {
                if (deleteSpecialityExamsDTO.SpecialityId > 0 && deleteSpecialityExamsDTO.ExamsId > 0)
                {
                    var response = await _specialityExamsService.DeleteSpecialityExams(deleteSpecialityExamsDTO);
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
