using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialityScoreFreeController : ControllerBase
    {
        private readonly ISpecialityPassingScoreFreeService _specialityPassingScoreFree;


        public SpecialityScoreFreeController(ISpecialityPassingScoreFreeService specialityPassingScoreFree)
        {
            _specialityPassingScoreFree = specialityPassingScoreFree;
        }


        [HttpGet("GetAllSpecialityScoreFree")]
        public async Task<IActionResult> GetAllSpecialityScoreFree()
        {
            try
            {
                var response = await _specialityPassingScoreFree.GetAllSpecialityScoreFree();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddSpecialityPassingScoreForFree")]
        public async Task<IActionResult> AddSpecialityPassingScoreForFree([FromBody] SpecialityPassingScoreFreeDTO specialityPassingScoreFreeDTO)
        {
            try
            {


                var response = await _specialityPassingScoreFree.AddSpecialityPassingScoreForFree(specialityPassingScoreFreeDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("DeleteSpecialityPassingScoreForFree")]
        public async Task<IActionResult> DeleteSpecialityPassingScoreForFree([FromBody] DeleteSpecialityPassingScoreFreeDTO deleteSpecialityPassingScoreFreeDTO)
        {
            try
            {
                if (deleteSpecialityPassingScoreFreeDTO.SpecialitId > 0 && deleteSpecialityPassingScoreFreeDTO.ScoreFreeId > 0)
                {
                    var response = await _specialityPassingScoreFree.DeleteSpecialityPassingScoreForFree(deleteSpecialityPassingScoreFreeDTO);
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
