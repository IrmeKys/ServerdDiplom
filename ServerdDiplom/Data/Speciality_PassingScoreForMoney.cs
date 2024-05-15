using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    [PrimaryKey(nameof(SpecialityId), nameof(ScoreForMoneyId))]
    public class Speciality_PassingScoreForMoney
    {
        [MaxLength(200)]
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; } = null!;
        public  int ScoreForMoneyId { get; set; }
        public PassingScoreExtramuralFreeFM ScoreExtramuralFreeFM { get; set; } = null!;
    }
}
