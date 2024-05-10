using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    [PrimaryKey(nameof(SpecialityNameId), nameof(ScoreFreeId))]
    public class Speciality_PassingScoreFree
    {
        [MaxLength(200)]
        public string SpecialityNameId { get; set; } = null!;
        public required int ScoreFreeId { get; set; }
        //public Speciality Speciality { get; set; } = null!;
        //public PassingScoreDayFreeFM ScoreFree { get; set; } = null!;
} 
}
