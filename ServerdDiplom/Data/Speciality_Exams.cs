using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    [PrimaryKey(nameof(SpecialityId), nameof(ExamsId))]
    public class Speciality_Exams
    {
        [MaxLength(200)]
        public int SpecialityId { get; set; }
        [MaxLength(100)]
        public Speciality Speciality { get; set; } = null!;
        public int ExamsId {  get; set; }
        public Exams Exams { get; set; }=null!;

    }
}
