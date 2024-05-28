﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerdDiplom.Context;

#nullable disable

namespace ServerdDiplom.Migrations
{
    [DbContext(typeof(DiplomDbContext))]
    partial class DiplomDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServerdDiplom.Data.ComissionNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ComissionNumberValue")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("ComissionsNumber");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Exams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Exams_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("ServerdDiplom.Data.PassingScoreDayFreeFM", b =>
                {
                    b.Property<int>("ScoreFreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreFreeId"));

                    b.Property<int>("PassingScoreValueDayForMoney")
                        .HasColumnType("int");

                    b.Property<int>("PassingScoreValueDayFree")
                        .HasColumnType("int");

                    b.HasKey("ScoreFreeId");

                    b.ToTable("PassingScoreDayFreeFMs");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Regions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SpecialityName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("Trainin_Period")
                        .HasColumnType("real");

                    b.Property<int?>("TrainingPeriodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainingPeriodId");

                    b.ToTable("Speciality");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality_Exams", b =>
                {
                    b.Property<int>("SpecialityId")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<int>("ExamsId")
                        .HasColumnType("int");

                    b.HasKey("SpecialityId", "ExamsId");

                    b.HasIndex("ExamsId");

                    b.ToTable("Speciality_Exams");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality_Faculty", b =>
                {
                    b.Property<int>("SpecialityId")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.HasKey("SpecialityId", "FacultyId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Speciality_Faculties");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality_PassingScoreFree", b =>
                {
                    b.Property<int>("SpecialityId")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<int>("ScoreFreeId")
                        .HasColumnType("int");

                    b.HasKey("SpecialityId", "ScoreFreeId");

                    b.HasIndex("ScoreFreeId");

                    b.ToTable("Speciality_PassingScoreFrees");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Towns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("RegionsNameId")
                        .HasColumnType("int");

                    b.Property<string>("Regions_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TownName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("RegionsNameId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("ServerdDiplom.Data.TrainingPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("TrainingPeriodValue")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("TrainingPeriods");
                });

            modelBuilder.Entity("ServerdDiplom.Data.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("TownNameId")
                        .HasColumnType("int");

                    b.Property<string>("Town_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UniversityDescription")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("UniversityLink")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("TownNameId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("ServerdDiplom.Data.University_Faculty", b =>
                {
                    b.Property<int>("UniversityId")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.HasKey("UniversityId", "FacultyId");

                    b.HasIndex("FacultyId");

                    b.ToTable("University_Faculties");
                });

            modelBuilder.Entity("ServerdDiplom.Data.ComissionNumber", b =>
                {
                    b.HasOne("ServerdDiplom.Data.University", "University")
                        .WithMany("ComissionNumber")
                        .HasForeignKey("UniversityId");

                    b.Navigation("University");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality", b =>
                {
                    b.HasOne("ServerdDiplom.Data.TrainingPeriod", "TrainingPeriod")
                        .WithMany("Specialities")
                        .HasForeignKey("TrainingPeriodId");

                    b.Navigation("TrainingPeriod");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality_Exams", b =>
                {
                    b.HasOne("ServerdDiplom.Data.Exams", "Exams")
                        .WithMany("Speciality_Exams")
                        .HasForeignKey("ExamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerdDiplom.Data.Speciality", "Speciality")
                        .WithMany("Speciality_Exams")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exams");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality_Faculty", b =>
                {
                    b.HasOne("ServerdDiplom.Data.Faculty", "Faculty")
                        .WithMany("Speciality_Faculties")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerdDiplom.Data.Speciality", "Speciality")
                        .WithMany("Speciality_Faculties")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality_PassingScoreFree", b =>
                {
                    b.HasOne("ServerdDiplom.Data.PassingScoreDayFreeFM", "PassingScoreDayFreeFM")
                        .WithMany("Speciality_PassingScoreFrees")
                        .HasForeignKey("ScoreFreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerdDiplom.Data.Speciality", "Speciality")
                        .WithMany("Speciality_PassingScoreFrees")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PassingScoreDayFreeFM");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Towns", b =>
                {
                    b.HasOne("ServerdDiplom.Data.Regions", "RegionsName")
                        .WithMany("Towns")
                        .HasForeignKey("RegionsNameId");

                    b.Navigation("RegionsName");
                });

            modelBuilder.Entity("ServerdDiplom.Data.University", b =>
                {
                    b.HasOne("ServerdDiplom.Data.Towns", "TownName")
                        .WithMany("Universities")
                        .HasForeignKey("TownNameId");

                    b.Navigation("TownName");
                });

            modelBuilder.Entity("ServerdDiplom.Data.University_Faculty", b =>
                {
                    b.HasOne("ServerdDiplom.Data.Faculty", "Faculty")
                        .WithMany("University_Faculties")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerdDiplom.Data.University", "University")
                        .WithMany("University_Faculties")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("University");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Exams", b =>
                {
                    b.Navigation("Speciality_Exams");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Faculty", b =>
                {
                    b.Navigation("Speciality_Faculties");

                    b.Navigation("University_Faculties");
                });

            modelBuilder.Entity("ServerdDiplom.Data.PassingScoreDayFreeFM", b =>
                {
                    b.Navigation("Speciality_PassingScoreFrees");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Regions", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Speciality", b =>
                {
                    b.Navigation("Speciality_Exams");

                    b.Navigation("Speciality_Faculties");

                    b.Navigation("Speciality_PassingScoreFrees");
                });

            modelBuilder.Entity("ServerdDiplom.Data.Towns", b =>
                {
                    b.Navigation("Universities");
                });

            modelBuilder.Entity("ServerdDiplom.Data.TrainingPeriod", b =>
                {
                    b.Navigation("Specialities");
                });

            modelBuilder.Entity("ServerdDiplom.Data.University", b =>
                {
                    b.Navigation("ComissionNumber");

                    b.Navigation("University_Faculties");
                });
#pragma warning restore 612, 618
        }
    }
}
