using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Speciality
    {
        [Key]
        public string SpecialityName { get; set; } = null!;
        public TrainingPeriod TrainingPeriod { get; set; } = null!;
        public required float Trainin_Period { get; set; }
        public List<Speciality_Faculty> Speciality_Faculties { get;  } = [];
        public List<Speciality_Exams>? Speciality_Exams { get; } = [];
        public List<Speciality_PassingScoreFree>? Speciality_PassingScoreFrees { get; } = [];
        public List<Speciality_PassingScoreForMoney>? Speciality_PassingScoreForMoney { get; } = [];
        public List<Faculty> Faculties { get; } = [];
        public List<Exams> Exams { get; } = [];
        public List<PassingScoreDayFreeFM> PassingScoreDayFreeFMs { get; } = [];
        public List<PassingScoreExtramuralFreeFM> PassingScoreExtramuralFreeFMs { get; } = [];
    }
}
