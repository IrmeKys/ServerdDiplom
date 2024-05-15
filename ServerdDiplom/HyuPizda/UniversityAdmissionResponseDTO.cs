using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.HyuPizda
{
    public class UniversityAdmissionResponseDTO
    {
        public string UniversityName { get; set; } = null!;
        public List<NewFacultyDTO> Faculties { get; set; } = null!;
    }
}
