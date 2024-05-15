using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassingScoreFreeController : ControllerBase
    {

        private readonly IPassingScoreDayFreeFMService _passingScoreDayFree;


        public PassingScoreFreeController(IPassingScoreDayFreeFMService passingScoreDayFree)
        {
            _passingScoreDayFree = passingScoreDayFree;
        }


        [HttpGet("GetAllPassingScoreFreeFM")]
        public async Task<IActionResult> GetAllPassingScoreFreeFM()
        {
            try
            {
                var response = await _passingScoreDayFree.GetAllPassingScoreFreeFM();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddPassingScoreFreeFM")]
        public async Task<IActionResult> AddPassingScoreFreeFM([FromBody] PassingScoreDayFreeFMDTO PassingScoreDayFreeFMDTO)
        {
            try
            {
                
                
                    var response = await _passingScoreDayFree.AddPassingScoreFreeFM(PassingScoreDayFreeFMDTO);
                    return Ok(response);

               
               
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdatePassingScoreFreeFM")]
        public async Task<IActionResult> UpdatePassingScoreFreeFM([FromBody] UpdatePassingScoreDayFreeFMDTO updatePassingScoreDayFreeFMDTO)
        {
            try
            {
                
                    var response = await _passingScoreDayFree.UpdatePassingScoreFreeFM(updatePassingScoreDayFreeFMDTO);
                    return Ok(response);

               
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeletePassingScoreFreeFM")]
        public async Task<IActionResult> DeletePassingScoreFreeFM([FromBody]DeletePassingScoreDayFreeFMDTO deletePassingScoreDayFreeFMDTO)
        {
            try
            {
                if (deletePassingScoreDayFreeFMDTO.ScoreFreeId>0)
                {
                var response = await _passingScoreDayFree.DeletePassingScoreFreeFM(deletePassingScoreDayFreeFMDTO);
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
