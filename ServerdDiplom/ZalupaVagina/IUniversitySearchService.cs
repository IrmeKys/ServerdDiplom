using ServerdDiplom.HyuPizda;

namespace ServerdDiplom.ZalupaVagina
{
	public interface IUniversitySearchService
	{
		public Task<List<UniversityAdmissionResponseDTO>> SearchUniversitiesAsync(string searchTerm);


	}
}
