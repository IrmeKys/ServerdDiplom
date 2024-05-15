using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Services;

namespace ServerdDiplom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingPeriodController : ControllerBase
    {
        private readonly ITrainingPeriodService _trainingPeriodService;


        public TrainingPeriodController(ITrainingPeriodService trainingPeriodService)
        {
            _trainingPeriodService = trainingPeriodService;
        }


        [HttpGet("GetAllTrainingPeriod")]
        public async Task<IActionResult> GetAllTrainingPeriod()
        {
            try
            {
                var response = await _trainingPeriodService.GetAllTrainingPeriod();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost("AddTrainingPeriod")]
        public async Task<IActionResult> AddRegiAddTrainingPeriodon([FromBody] TrainingPeriodDTO trainingPeriodDTO)
        {
            try
            {


                var response = await _trainingPeriodService.AddTrainingPeriod(trainingPeriodDTO);
                return Ok(response);



            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateTrainingPeriod")]
        public async Task<IActionResult> UpdateTrainingPeriod([FromBody] TrainingPeriodDTO trainingPeriodDTO)
        {
            try
            {

                var response = await _trainingPeriodService.UpdateTrainingPeriod(trainingPeriodDTO);
                return Ok(response);


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("DeleteTrainingPeriod")]
        public async Task<IActionResult> DeleteTrainingPeriod([FromBody] DeleteTrainingPeriodDTO deleteTrainingPeriodDTO)
        {
            try
            {
                if (deleteTrainingPeriodDTO.Id > 0)
                {
                    var response = await _trainingPeriodService.DeleteTrainingPeriod(deleteTrainingPeriodDTO);
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
