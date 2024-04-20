using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Regions
    {
        [Key]
        public string Region { get; set; } = null!;
        public List<Towns> Towns { get; set; } = null!;
    }
}
