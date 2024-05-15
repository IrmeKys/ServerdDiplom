using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.Model
{
    public class SingleUniversityResponse
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public UniversityDTO? University { get; set; }
    }
}
