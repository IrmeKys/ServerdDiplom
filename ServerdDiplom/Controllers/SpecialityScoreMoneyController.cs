using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialityScoreMoneyController : ControllerBase
    {
        private readonly ISpecialityPassingScoreForMoneyService _scoreForMoneyService;


        public SpecialityScoreMoneyController(ISpecialityPassingScoreForMoneyService scoreForMoneyService)
        {
            _scoreForMoneyService = scoreForMoneyService;
        }


        [HttpGet("GetAllSpecialityScore")]
        public async Task<IActionResult> GetAllSpecialityScore()
        {
            try
            {
                var response = await _scoreForMoneyService.GetAllSpecialityScore();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddSpecialityPassingScoreForMoney")]
        public async Task<IActionResult> AddSpecialityPassingScoreForMoney([FromBody] SpecialityPassingScoreForMoneyDTO scoreForMoneyDTO)
        {
            try
            {


                var response = await _scoreForMoneyService.AddSpecialityPassingScoreForMoney(scoreForMoneyDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("DeleteSpecialityPassingScoreForMoney")]
        public async Task<IActionResult> DeleteSpecialityPassingScoreForMoney([FromBody] DeleteSpecialityPassingScoreForMoneyDTO deleteSpecialityPassingScoreForMoneyDTO)
        {
            try
            {
                if (deleteSpecialityPassingScoreForMoneyDTO.SpecialityId > 0 && deleteSpecialityPassingScoreForMoneyDTO.ScoreForMoneyId > 0)
                {
                    var response = await _scoreForMoneyService.DeleteSpecialityPassingScoreForMoney(deleteSpecialityPassingScoreForMoneyDTO);
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
