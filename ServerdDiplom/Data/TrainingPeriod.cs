using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class TrainingPeriod
    {
        [Key]
        [Range(3.5, 6, ErrorMessage = "Введите число от 3,5 до 6")]
        public required float TrainingPeriodValue { get; set; }
        public List<Speciality> Specialities { get; set; } = null!;
    }
}
