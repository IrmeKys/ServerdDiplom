using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IExamsService _examsService;


        public ExamsController(IExamsService examsService)
        {
            _examsService = examsService;
        }


        [HttpGet("GetAllExams")]
        public async Task<IActionResult> GetAllExams()
        {
            try
            {
                var response = await _examsService.GetAllExams();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddExams")]
        public async Task<IActionResult> AddExams([FromBody] ExamsDTO examsDTO)
        {
            try
            {


                var response = await _examsService.AddExams(examsDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateExams")]
        public async Task<IActionResult> UpdateExams([FromBody] ExamsDTO examsDTO)
        {
            try
            {

                var response = await _examsService.UpdateExams(examsDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeleteExams")]
        public async Task<IActionResult> DeleteExams([FromBody] ExamsDTO examsDTO)
        {
            try
            {
                if (examsDTO.Exams_Name.Length > 0)
                {
                    var response = await _examsService.DeleteExams(examsDTO);
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
