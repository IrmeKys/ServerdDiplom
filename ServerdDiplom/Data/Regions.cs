using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Regions
    {
        [Key]
        public int Id {  get; set; }
        [MaxLength(100)]
        public string Region { get; set; } = null!;
        public List<Towns> Towns { get; set; } = null!;
    }
}
