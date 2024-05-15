using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownController : ControllerBase
    {
        private readonly ITownsService _townService;


        public TownController(ITownsService townsService)
        {
            _townService = townsService;
        }


        [HttpGet("GetAllTowns")]
        public async Task<IActionResult> GetAllTowns()
        {
            try
            {
                var response = await _townService.GetAllTowns();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddTown")]
        public async Task<IActionResult> AddTown([FromBody] TownsDTO townsDTO)
        {
            try
            {


                var response = await _townService.AddTown(townsDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateTown")]
        public async Task<IActionResult> UpdateTown([FromBody] UpdateTownsDTO updateTownsDTO)
        {
            try
            {

                var response = await _townService.UpdateTown(updateTownsDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeleteTown")]
        public async Task<IActionResult> DeleteTown([FromBody] DeleteTownsDTO deleteTownsDTO)
        {
            try
            {
                if (deleteTownsDTO.Id > 0)
                {
                    var response = await _townService.DeleteTown(deleteTownsDTO);
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
