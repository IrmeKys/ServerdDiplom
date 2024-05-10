using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
        [PrimaryKey(nameof(SpecialityNameId), nameof(FacultyNameId))]
    public class Speciality_Faculty
    {
        [MaxLength(200)]
        public string SpecialityNameId { get; set; }= null!;
        [MaxLength(200)]
        public string FacultyNameId { get; set; } = null!;
        //public Speciality Speciality { get; set; } = null!;
        //public Faculty Faculty { get; set; } = null!;
    }
}
