using ServerdDiplom.Model;

namespace ServerdDiplom.ZalupaVagina
{
    public class SearchFacultyDTO
    {
        public string FacultyName { get; set; } = null!;
        public List<SearchSpecialityDTO> Specialities { get; set; } = new();
    }
}
