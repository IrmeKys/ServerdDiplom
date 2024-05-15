using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassingScoreExtramuralController : ControllerBase
    {
        private readonly IPassingScoreExtramuralFreeFMService _passingScoreExtramuralFreeFM;


        public PassingScoreExtramuralController(IPassingScoreExtramuralFreeFMService passingScoreExtramuralFreeFM)
        {
            _passingScoreExtramuralFreeFM = passingScoreExtramuralFreeFM;
        }


        [HttpGet("GetAllPassingScoreExtramuralFreeFM")]
        public async Task<IActionResult> GetAllPassingScoreExtramuralFreeFM()
        {
            try
            {
                var response = await _passingScoreExtramuralFreeFM.GetAllPassingScoreExtramuralFreeFM();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddPassingScoreExtramuralFreeFM")]
        public async Task<IActionResult> AddPassingScoreExtramuralFreeFM([FromBody] PassingScoreExtramuralFreeFMDTO addPassingScoreDayFreeFMDTO)
        {
            try
            {


                var response = await _passingScoreExtramuralFreeFM.AddPassingScoreExtramuralFreeFM(addPassingScoreDayFreeFMDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdatePassingScoreExtramuralFreeFM")]
        public async Task<IActionResult> UpdatePassingScoreExtramuralFreeFM([FromBody] UpdatePassingScoreExtramuralFreeFMDTO updatePassingScoreExtramuralFreeFMDTO)
        {
            try
            {

                var response = await _passingScoreExtramuralFreeFM.UpdatePassingScoreExtramuralFreeFM(updatePassingScoreExtramuralFreeFMDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeletePassingScoreExtramuralFreeFM")]
        public async Task<IActionResult> DeletePassingScoreExtramuralFreeFM([FromBody] DeletePassingScoreExtramuralFreeFMDTO deletePassingScoreExtramuralFreeFMDTO)
        {
            try
            {
                if (deletePassingScoreExtramuralFreeFMDTO.ScoreForMoneyId > 0)
                {
                    var response = await _passingScoreExtramuralFreeFM.DeletePassingScoreExtramuralFreeFM(deletePassingScoreExtramuralFreeFMDTO);
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

