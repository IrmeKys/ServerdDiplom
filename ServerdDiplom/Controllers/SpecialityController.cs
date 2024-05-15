using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialityController : ControllerBase
    {


        private readonly ISpecialityService _speciality;


        public SpecialityController(ISpecialityService speciality)
        {
            _speciality = speciality;
        }


        [HttpGet("GetAllSpeciality")]
        public async Task<IActionResult> GetAllSpeciality()
        {
            try
            {
                var response = await _speciality.GetAllSpeciality();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddSpeciality")]
        public async Task<IActionResult> AddSpeciality([FromBody] SpecialityDTO specialityDTO)
        {
            try
            {


                var response = await _speciality.AddSpeciality(specialityDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateSpeciality")]
        public async Task<IActionResult> UpdateSpeciality([FromBody] UpdateSpecialityDTO updateSpecialityDTO)
        {
            try
            {

                var response = await _speciality.UpdateSpeciality(updateSpecialityDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeleteSpeciality")]
        public async Task<IActionResult> DeleteSpeciality([FromBody] DeleteSpecialityDTO deleteSpecialityDTO)
        {
            try
            {
                if (deleteSpecialityDTO.Id > 0)
                {
                    var response = await _speciality.DeleteSpeciality(deleteSpecialityDTO);
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
       
