using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerdDiplom.Data
{
    public class ComissionNumber
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string ComissionNumberValue { get; set; } = null!;
        public University? University { get; set; }
        [MaxLength(200)]
        public string UniversityName {  get; set; } = null!;
    }
}
