using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Services;

namespace ServerdDiplom.HyuPizda
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetSpecialutyByExam : ControllerBase
    {
        private readonly IUniversityAdmissionService _universityAdmissionService;
        private readonly MainResponse mainResponse;


        public GetSpecialutyByExam(IUniversityAdmissionService universityAdmissionService)
        {
            _universityAdmissionService = universityAdmissionService;
        }

        [HttpGet("GetUniversitiesBySubjectsAsync")]
        public async Task<IActionResult> GetUniversitiesBySubjectsAsync([FromQuery] List<string> subjectNames, int? passingScore = null)
        {
            try
            {
                var universities = await _universityAdmissionService.GetUniversitiesBySubjectsAsync(subjectNames, passingScore);
                if (universities == null || subjectNames.Count>3)
                {
                    return NotFound("Invalid exam names. Exam names must be not null and less then 3");
                }
                if (passingScore < 0 || passingScore > 400)
                {
                    return BadRequest("Invalid passing score. The passing score must be between 0 and 400");
                    
                }
                return Ok(universities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
