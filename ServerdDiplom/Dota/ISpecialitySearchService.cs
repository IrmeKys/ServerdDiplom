using ServerdDiplom.Model;
using ServerdDiplom.ZalupaVagina;

namespace ServerdDiplom.Dota
{
    public interface ISpecialitySearchService
    {

            Task<IEnumerable<SearchUniversityDTO>> SearchUniversitiesBySpecialityAsync(string searchTerm);
    }
}
