using ServerdDiplom.HyuPizda;
using ServerdDiplom.Model;
using ServerdDiplom.ZalupaVagina;

namespace ServerdDiplom.Dota
{
    public interface ISpecialitySearchService
    {

		public Task<List<UniversityAdmissionResponseDTO>> SearchUniversitiesBySpecialityAsync(string searchTerm);


	}
}
