using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data

{
    [PrimaryKey(nameof(UniversityId), nameof(FacultyId))]
    public class University_Faculty
    {
        [MaxLength(200)]
        public int UniversityId { get; set; }
        [MaxLength(200)]
        public University University { get; set; } = null!;
        public int FacultyId {  get; set; }
        public Faculty Faculty { get; set; } = null!;
    }
}
