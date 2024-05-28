using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Services;

namespace ServerdDiplom.ZalupaVagina
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversitySearchController : ControllerBase
    {
        private readonly IUniversitySearchService _universityService;

        public UniversitySearchController(IUniversitySearchService universityService)
        {
            _universityService = universityService;
        }

        [HttpGet("SearchUniversitiesAsync")]
        public async Task<IActionResult> SearchUniversitiesAsync([FromQuery] string searchTerm)
        {
            var result = await _universityService.SearchUniversitiesAsync(searchTerm);
            return Ok(result);
        }
    }
}
