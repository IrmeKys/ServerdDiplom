//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using ServerdDiplom.HyuPizda;
//using ServerdDiplom.Model;

//namespace ServerdDiplom.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class HyuPizdaController : ControllerBase
//    {



//        private readonly IUniversitySpecialityFacultyService _universitySpecialityService;
//        private readonly IGetSpOnExAndScService _getSpOnExAndScService;

//        public HyuPizdaController(IUniversitySpecialityFacultyService universitySpecialityFacultyService, IGetSpOnExAndScService getSpOnExAndScService)
//        {
//            _universitySpecialityService = universitySpecialityFacultyService;
//            _getSpOnExAndScService = getSpOnExAndScService;
//        }


//        [HttpGet("GetAll")]
//        public async Task<IActionResult> GetAll()
//        {
//            try
//            {
//                return Ok("HyuPizda");


//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [HttpGet("GetUniversitiesBySelectedSubjectsResponse")]
//        public async Task<IActionResult> GetUniversitiesBySelectedSubjectsResponse([FromQuery] List<string> selectedSubjects)
//        {

//            try
//            {
//                var response = await _universitySpecialityService.GetUniversitiesBySelectedSubjectsResponse(selectedSubjects.ToArray());
//                return Ok(response);

//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [HttpGet("GetSpOnExAndScResponse")]
//        public async Task<IActionResult> GetSpOnExAndScResponse([FromQuery] List<string> selectedSubjects, int? score = null)
//        {

//            try
//            {
//                var response = await _getSpOnExAndScService.GetSpOnExAndScResponse(selectedSubjects.ToArray(), score);
//                return Ok(response);

//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//    }
//}
