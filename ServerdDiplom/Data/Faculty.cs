using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Faculty
    {
        [Key]
        public string FacultyName { get; set; } = null!;
        public List<University_Faculty> University_Faculties { get; } = [];
        public List<Speciality_Faculty> Speciality_Faculties { get;  } = [];
        public List<Speciality> Specialitys { get; } = [];
        public List<University> Universities { get; } = [];
    }
}
