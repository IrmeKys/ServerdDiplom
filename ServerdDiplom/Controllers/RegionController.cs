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
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;


        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }


        [HttpGet("GetAllRegion")]
        public async Task<IActionResult> GetAllRegion()
        {
            try
            {
                var response = await _regionService.GetAllRegion();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddRegion")]
        public async Task<IActionResult> AddRegion([FromBody] RegionDTO regionDTO)
        {
            try
            {


                var response = await _regionService.AddRegion(regionDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateRegion")]
        public async Task<IActionResult> UpdateRegion([FromBody] RegionDTO regionDTO)
        {
            try
            {

                var response = await _regionService.UpdateRegion(regionDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeleteRegion")]
        public async Task<IActionResult> DeleteRegion([FromBody] DeleteRegionDTO deleteRegionDTO)
        {
            try
            {
                if (deleteRegionDTO.Id > 0)
                {
                    var response = await _regionService.DeleteRegion(deleteRegionDTO);
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
