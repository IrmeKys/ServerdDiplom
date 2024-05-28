using ServerdDiplom.Model;

namespace ServerdDiplom.ZalupaVagina
{
    public interface IUniversitySearchService
    {
        Task<IEnumerable<SearchUniversityDTO>> SearchUniversitiesAsync(string searchTerm);
    }
}
