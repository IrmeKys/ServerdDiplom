using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerdDiplom.Services;

namespace ServerdDiplom.Dota
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchSpecialityController : ControllerBase
    {
        private readonly ISpecialitySearchService _universityService;

        public SearchSpecialityController(ISpecialitySearchService universityService)
        {
            _universityService = universityService;
        }

        [HttpGet("SearchUniversitiesBySpecialityAsync")]
        public async Task<IActionResult> SearchUniversitiesBySpecialityAsync([FromQuery] string searchTerm)
        {
            var result = await _universityService.SearchUniversitiesBySpecialityAsync(searchTerm);
            return Ok(result);
        }
    }
}
