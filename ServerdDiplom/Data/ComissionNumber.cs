using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerdDiplom.Data
{
    public class ComissionNumber
    {
        [Key]
        public string ComissionNumberValue { get; set; } = null!;
        public University University { get; set; }=null!;
        
        public string UniversityName {  get; set; } = null!;
    }
}
