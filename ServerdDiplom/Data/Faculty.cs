using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Faculty
    {
        [Key]
        [MaxLength(200)]
        public string FacultyName { get; set; } = null!;
        public List<University_Faculty> University_Faculties { get; } = [];
        public List<Speciality_Faculty> Speciality_Faculties { get;  } = [];
    }
}
