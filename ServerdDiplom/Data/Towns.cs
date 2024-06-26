﻿using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class Towns
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string StreetName { get; set; } = null!;
        [MaxLength(100)]
        public string TownName { get; set; } = null!;
        public Regions? RegionsName { get; set; }
        [MaxLength(100)]
        public string Regions_Name { get; set; } = null!;
        public List<University> Universities {  get; set; }=null!;
    }
}
