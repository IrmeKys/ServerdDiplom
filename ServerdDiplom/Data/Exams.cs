using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Exams
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Exams_Name { get; set; } = null!;
        public List<Speciality_Exams>? Speciality_Exams { get;  } = [];
    }
}
