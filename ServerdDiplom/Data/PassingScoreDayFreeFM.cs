using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class PassingScoreDayFreeFM
    {
        [Key]
        public required int ScoreFreeId { get; set; }
        [Range(130, 395, ErrorMessage = "Введите число от 130 до 395")]
        public int PassingScoreValueDayFree { get; set;}
        [Range(130, 380, ErrorMessage = "Введите число от 130 до 380")]
        public int PassingScoreValueDayForMoney {  get; set;}
        public List<Speciality_PassingScoreFree>? Speciality_PassingScoreFrees { get; } = [];
        public List<Speciality> Specialitys { get; } = [];
    }
}
