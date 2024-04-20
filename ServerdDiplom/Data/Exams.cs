using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Exams
    {
        [Key]
        public string Exams_Name { get; set; } = null!;
        public List<Speciality_Exams> Speciality_Exams { get;  } = [];
        public List<Speciality> Specialitys {  get; } = [];
    }
}
