using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerdDiplom.ChlenZhopa
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityInfoController : ControllerBase
    {
        private readonly IUniversityInfoService _universityInfoService;

        public UniversityInfoController(IUniversityInfoService universityInfoService)
        {
            _universityInfoService = universityInfoService;
        }

        [HttpGet]
        public async Task<ActionResult<UniversityInfoDTO>> GetUniversityInfo(string universityName, string facultyName, string specialityName)
        {
            var universityInfo = await _universityInfoService.GetUniversityInfoAsync(universityName, facultyName, specialityName);

            if (universityInfo == null)
            {
                return NotFound();
            }

            return Ok(universityInfo);
        }
    }
}
