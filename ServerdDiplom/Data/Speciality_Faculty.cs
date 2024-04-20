using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Data
{
        [PrimaryKey(nameof(SpecialityNameId), nameof(FacultyNameId))]
    public class Speciality_Faculty
    {
        public string SpecialityNameId { get; set; }= null!;
        public string FacultyNameId { get; set; } = null!;
        //public Speciality Speciality { get; set; } = null!;
        //public Faculty Faculty { get; set; } = null!;
    }
}
