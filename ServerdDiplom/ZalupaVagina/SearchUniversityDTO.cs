using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.ZalupaVagina
{
    public class SearchUniversityDTO
    {

        public string UniversityName { get; set; } = null!;
        public string UniversityDescription { get; set; } = null!;
        public string UniversityLink { get; set; } = null!;
        public List<SearchFacultyDTO> Faculties { get; set; } = new();
    }
}
