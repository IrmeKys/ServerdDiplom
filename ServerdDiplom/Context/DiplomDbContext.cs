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
        //modelBuilder.Entity<Speciality_Faculty>(entity =>
        //{
        //    entity.HasKey(x => new { x.Speciality_NameMTM, x.Faculty_NameMTM });

        //    entity.HasOne(x => x.FacultyNameMTM)
        //    .WithMany(sf => sf.Speciality_Faculties)
        //    .HasForeignKey(x => x.Faculty_NameMTM)
        //    .OnDelete(DeleteBehavior.Cascade);

        //    entity.HasOne(x => x.SpecialityNameMTM)
        //    .WithMany(sf => sf.Speciality_Faculties)
        //    .HasForeignKey(x => x.Speciality_NameMTM)
        //    .OnDelete(DeleteBehavior.Cascade);

        //});

        //modelBuilder.Entity<Speciality_Exams>(entity =>
        //{
        //    entity.HasKey(x => new { x.SpecialityMTM, x.ExamsMTM });

        //    entity.HasOne(x=>x.SpecialityName)
        //    .WithMany(se=>se.Speciality_Exams)
        //    .HasForeignKey(x=>x.SpecialityMTM)
        //    .OnDelete(DeleteBehavior.Cascade);

        //    entity.HasOne(x => x.ExamsName)
        //    .WithMany(se => se.Speciality_Exams)
        //    .HasForeignKey(x => x.ExamsMTM)
        //    .OnDelete(DeleteBehavior.Cascade);

        //});

        //modelBuilder.Entity<Speciality_PassingScoreFree>(entity =>
        //{

        //    entity.HasKey(x => new { x.SpecialityName, x.ScoreFree });

        //    entity.HasOne(x=>x.Speciality_Name)
        //    .WithMany(spf=>spf.Speciality_PassingScoreFrees)
        //    .HasForeignKey(x=>x.SpecialityName)
        //    .OnDelete(DeleteBehavior.Cascade);

        //    entity.HasOne(x => x.Score_Free)
        //    .WithMany(spf => spf.Speciality_PassingScoreFrees)
        //    .HasForeignKey(x => x.ScoreFree)
        //    .OnDelete(DeleteBehavior.Cascade);

        //});


        //modelBuilder.Entity<Speciality_PassingScoreForMoney>(entity =>
        //   {
        //       entity.HasKey(x => new { x.SpecialityName, x.ScoreForMoney });

        //       entity.HasOne(x=>x.Speciality_Name)
        //       .WithMany(sfm=>sfm.Speciality_PassingScoreForMoney)
        //       .HasForeignKey(x=>x.SpecialityName)
        //       .OnDelete(DeleteBehavior.Cascade);

        //       entity.HasOne(x => x.Score_ForMoney)
        //       .WithMany(sfm => sfm.Speciality_PassingScoreForMoney)
        //       .HasForeignKey(x => x.ScoreForMoney)
        //       .OnDelete(DeleteBehavior.Cascade);
        //   });

        //modelBuilder.Entity<University_Faculty>(entity=>
        //    { entity.HasKey(x => new { x.UniversityMTM, x.FacultyMTM });

        //        entity.HasOne(x=>x.UniversityNameMTM)
        //        .WithMany(uf=>uf.University_Faculties)
        //        .HasForeignKey(x=>x.UniversityMTM)
        //        .OnDelete(DeleteBehavior.Cascade);

        //        entity.HasOne(x => x.FacultyNameMTM)
        //        .WithMany(uf => uf.University_Faculties)
        //        .HasForeignKey(x => x.FacultyMTM)
        //        .OnDelete(DeleteBehavior.Cascade);
        //    });
        //OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
