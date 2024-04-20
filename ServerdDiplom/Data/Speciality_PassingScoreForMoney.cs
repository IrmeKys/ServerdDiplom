using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Data
{
    [PrimaryKey(nameof(SpecialityId), nameof(ScoreForMoneyId))]
    public class Speciality_PassingScoreForMoney
    {
        public string SpecialityId { get; set; }=null!;
        public required int ScoreForMoneyId { get; set; }
        //public Speciality Speciality_Name { get; set; } = null!;
        //public PassingScoreExtramuralFreeFM Score_ForMoney { get; set; } = null!;
    }
}
