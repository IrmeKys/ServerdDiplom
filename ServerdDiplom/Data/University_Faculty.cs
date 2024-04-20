using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Data

{
    [PrimaryKey(nameof(UniversityId), nameof(FacultyId))]
    public class University_Faculty
    {
        public string UniversityId { get; set; } = null!;

        public string FacultyId {  get; set; } = null!;
        //public University UniversityNameMTM { get; set; } = null!;
        //public Faculty FacultyNameMTM { get; set; } = null!;
    }
}
