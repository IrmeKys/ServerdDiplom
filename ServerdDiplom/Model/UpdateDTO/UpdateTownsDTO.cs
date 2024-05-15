using ServerdDiplom.Data;

namespace ServerdDiplom.Model
{
    public class UpdateTownsDTO
    {
        public int Id { get; set; }
        public string StreetName { get; set; } = null!;
        public string TownName { get; set; } = null!;

    }
}
