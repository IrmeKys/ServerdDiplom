using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    [PrimaryKey(nameof(SpecialityId), nameof(ScoreFreeId))]
    public class Speciality_PassingScoreFree
    {
        [MaxLength(200)]
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }= null!;
        public  int ScoreFreeId { get; set; }
        public PassingScoreDayFreeFM PassingScoreDayFreeFM { get; set; }=null!;

    } 
}
