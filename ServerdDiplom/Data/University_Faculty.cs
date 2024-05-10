using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data

{
    [PrimaryKey(nameof(UniversityId), nameof(FacultyId))]
    public class University_Faculty
    {
        [MaxLength(200)]
        public string UniversityId { get; set; } = null!;
        [MaxLength(200)]
        public string FacultyId {  get; set; } = null!;
        //public University UniversityNameMTM { get; set; } = null!;
        //public Faculty FacultyNameMTM { get; set; } = null!;
    }
}
