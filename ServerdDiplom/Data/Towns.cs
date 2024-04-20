using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Towns
    {
        [Key]
        public string StreetName { get; set; } = null!;
        public string TownName { get; set; } = null!;
        public Regions RegionsName { get; set; } = null!;
        public string Regions_Name { get; set; } = null!;
        public List<University> Universities {  get; set; }=null!;
    }
}
