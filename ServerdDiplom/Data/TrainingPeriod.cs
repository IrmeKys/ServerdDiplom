﻿using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Data
{
    public class TrainingPeriod
    {
        [Key]
        public int Id { get; set; }
        [Range(3.5, 6, ErrorMessage = "Введите число от 3,5 до 6")]
        public  float TrainingPeriodValue { get; set; }
        public List<Speciality> Specialities { get; set; } = null!;
    }
}
