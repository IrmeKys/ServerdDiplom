using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
        [PrimaryKey(nameof(SpecialityId), nameof(FacultyId))]
    public class Speciality_Faculty
    {
        [MaxLength(200)]
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; } = null!;
        [MaxLength(200)]
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; } = null!;

    }
}
