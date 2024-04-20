using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class PassingScoreExtramuralFreeFM
    {
        [Key]
        public required int ScoreForMoneyId { get; set; }
        [Range(130,350,ErrorMessage ="Введите число от 130 до 350")]
        public int PassingScoreValueExtramuralFree { get; set; }
        [Range(130, 350, ErrorMessage = "Введите число от 130 до 310")]
        public int PassingScoreValueExtramuralForMoney { get; set; }
        public List<Speciality_PassingScoreForMoney>? Speciality_PassingScoreForMoney { get; } = [];
        public List<Speciality> Specialitys { get; } = [];

    }
}
