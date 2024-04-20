using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class University
    {
        [Key]
        public string UniversityName { get; set; } = null!;
        public string UniversityDescription { get; set; }=null!;
        public string UniversityLink { get; set; } = null!;
        public Towns TownName { get; set; } = null!;
        public string Town_name { get; set; } = null!;

        public List<ComissionNumber> ComissionNumber { get; set; } = null!;
        public List<University_Faculty> University_Faculties { get; } = [];
        public List<Faculty> Faculties { get; } = [];
    }
}
