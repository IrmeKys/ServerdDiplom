using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    [PrimaryKey(nameof(SpecialityId), nameof(ExamsId))]
    public class Speciality_Exams
    {

        public string SpecialityId { get; set; } = null!;
        public string ExamsId {  get; set; } = null!;
        //public Exams ExamsName { get; set; } = null!;
        //public Speciality SpecialityName { get; set; } = null!;
 
    }
}
