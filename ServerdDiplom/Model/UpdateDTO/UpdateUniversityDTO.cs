using ServerdDiplom.Data;

namespace ServerdDiplom.Model
{
    public class UpdateUniversityDTO
    {
        public int Id { get; set; }
        public string UniversityName { get; set; } = null!;
        public string UniversityLink { get; set; } = null!;
    }
}
