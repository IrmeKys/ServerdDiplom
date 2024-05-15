using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.ChlenZhopa
{
    public class UniversityInfoDTO
    {
        public string UniversityName { get; set; } = null!;
        public string UniversityDescription { get; set; } = null!;
        public string UniversityLink { get; set; } = null!;
        public string FacultyName { get; set; } = null!;
        public string Town_name { get; set; } = null!;
        public SpecialityInfoDTO SpecialityInfo { get; set; }
        public ComissionNumberInfoDTO ComissionNumberInfo { get; set; }
    }

}
