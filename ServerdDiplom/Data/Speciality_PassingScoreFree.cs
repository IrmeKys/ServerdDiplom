using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Data
{
    [PrimaryKey(nameof(SpecialityNameId), nameof(ScoreFreeId))]
    public class Speciality_PassingScoreFree
    {
        public string SpecialityNameId { get; set; } = null!;
        public required int ScoreFreeId { get; set; }
        //public Speciality Speciality { get; set; } = null!;
        //public PassingScoreDayFreeFM ScoreFree { get; set; } = null!;
} 
}
