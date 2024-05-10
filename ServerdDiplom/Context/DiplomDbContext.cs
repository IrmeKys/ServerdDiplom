using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Data;

namespace ServerdDiplom.Context;

public partial class DiplomDbContext : DbContext
{
    public DiplomDbContext()
    {
    }

    public DiplomDbContext(DbContextOptions<DiplomDbContext> options)
        : base(options)
    {
    }

    public DbSet<Regions> Regions { get; set; }
    public DbSet<Towns> Towns { get; set; }
    public DbSet<ComissionNumber> ComissionsNumber { get; set; }
    public DbSet<Exams> Exams { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<PassingScoreDayFreeFM> PassingScoreDayFreeFMs { get; set; }
    public DbSet<PassingScoreExtramuralFreeFM> PassingScoreExtramuralFreeFMs { get; set; }
    public DbSet<Speciality> Speciality { get; set; }
    public DbSet<TrainingPeriod> TrainingPeriods { get; set; }
    public DbSet<University> Universities { get; set; }
    public DbSet<Speciality_Exams> Speciality_Exams { get; set; }
    public DbSet<Speciality_Faculty> Speciality_Faculties { get; set; }
    public DbSet<Speciality_PassingScoreFree> Speciality_PassingScoreFrees { get; set; }
    public DbSet<Speciality_PassingScoreForMoney> Speciality_PassingScoreForMoney { get; set; }
    public DbSet<University_Faculty> University_Faculties { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
