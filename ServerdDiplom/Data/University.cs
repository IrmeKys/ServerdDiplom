using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class University
    {
        [Key]
        [MaxLength(200)]
        public string UniversityName { get; set; } = null!;
        [MaxLength(1024)]
        public string UniversityDescription { get; set; }=null!;
        [MaxLength(256)]
        public string UniversityLink { get; set; } = null!;
        public Towns TownName { get; set; } = null!;
        [MaxLength(100)]
        public string Town_name { get; set; } = null!;

        public List<ComissionNumber> ComissionNumber { get; set; } = null!;
        public List<University_Faculty> University_Faculties { get; } = [];
    }
}
