using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerdDiplom.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Exams_Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Exams_Name);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyName);
                });

            migrationBuilder.CreateTable(
                name: "PassingScoreDayFreeFMs",
                columns: table => new
                {
                    ScoreFreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassingScoreValueDayFree = table.Column<int>(type: "int", nullable: false),
                    PassingScoreValueDayForMoney = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassingScoreDayFreeFMs", x => x.ScoreFreeId);
                });

            migrationBuilder.CreateTable(
                name: "PassingScoreExtramuralFreeFMs",
                columns: table => new
                {
                    ScoreForMoneyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassingScoreValueExtramuralFree = table.Column<int>(type: "int", nullable: false),
                    PassingScoreValueExtramuralForMoney = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassingScoreExtramuralFreeFMs", x => x.ScoreForMoneyId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Region = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Region);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPeriods",
                columns: table => new
                {
                    TrainingPeriodValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPeriods", x => x.TrainingPeriodValue);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    StreetName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionsNameRegion = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Regions_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.StreetName);
                    table.ForeignKey(
                        name: "FK_Towns_Regions_RegionsNameRegion",
                        column: x => x.RegionsNameRegion,
                        principalTable: "Regions",
                        principalColumn: "Region");
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    SpecialityName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainingPeriodValue = table.Column<float>(type: "real", nullable: false),
                    Trainin_Period = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.SpecialityName);
                    table.ForeignKey(
                        name: "FK_Speciality_TrainingPeriods_TrainingPeriodValue",
                        column: x => x.TrainingPeriodValue,
                        principalTable: "TrainingPeriods",
                        principalColumn: "TrainingPeriodValue",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    UniversityName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UniversityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversityLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TownNameStreetName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Town_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.UniversityName);
                    table.ForeignKey(
                        name: "FK_Universities_Towns_TownNameStreetName",
                        column: x => x.TownNameStreetName,
                        principalTable: "Towns",
                        principalColumn: "StreetName");
                });

            migrationBuilder.CreateTable(
                name: "ExamsSpeciality",
                columns: table => new
                {
                    Exams_Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecialitysSpecialityName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamsSpeciality", x => new { x.Exams_Name, x.SpecialitysSpecialityName });
                    table.ForeignKey(
                        name: "FK_ExamsSpeciality_Exams_Exams_Name",
                        column: x => x.Exams_Name,
                        principalTable: "Exams",
                        principalColumn: "Exams_Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamsSpeciality_Speciality_SpecialitysSpecialityName",
                        column: x => x.SpecialitysSpecialityName,
                        principalTable: "Speciality",
                        principalColumn: "SpecialityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacultySpeciality",
                columns: table => new
                {
                    FacultiesFacultyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecialitysSpecialityName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultySpeciality", x => new { x.FacultiesFacultyName, x.SpecialitysSpecialityName });
                    table.ForeignKey(
                        name: "FK_FacultySpeciality_Faculties_FacultiesFacultyName",
                        column: x => x.FacultiesFacultyName,
                        principalTable: "Faculties",
                        principalColumn: "FacultyName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacultySpeciality_Speciality_SpecialitysSpecialityName",
                        column: x => x.SpecialitysSpecialityName,
                        principalTable: "Speciality",
                        principalColumn: "SpecialityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassingScoreDayFreeFMSpeciality",
                columns: table => new
                {
                    PassingScoreDayFreeFMsScoreFreeId = table.Column<int>(type: "int", nullable: false),
                    SpecialitysSpecialityName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassingScoreDayFreeFMSpeciality", x => new { x.PassingScoreDayFreeFMsScoreFreeId, x.SpecialitysSpecialityName });
                    table.ForeignKey(
                        name: "FK_PassingScoreDayFreeFMSpeciality_PassingScoreDayFreeFMs_PassingScoreDayFreeFMsScoreFreeId",
                        column: x => x.PassingScoreDayFreeFMsScoreFreeId,
                        principalTable: "PassingScoreDayFreeFMs",
                        principalColumn: "ScoreFreeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassingScoreDayFreeFMSpeciality_Speciality_SpecialitysSpecialityName",
                        column: x => x.SpecialitysSpecialityName,
                        principalTable: "Speciality",
                        principalColumn: "SpecialityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassingScoreExtramuralFreeFMSpeciality",
                columns: table => new
                {
                    PassingScoreExtramuralFreeFMsScoreForMoneyId = table.Column<int>(type: "int", nullable: false),
                    SpecialitysSpecialityName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassingScoreExtramuralFreeFMSpeciality", x => new { x.PassingScoreExtramuralFreeFMsScoreForMoneyId, x.SpecialitysSpecialityName });
                    table.ForeignKey(
                        name: "FK_PassingScoreExtramuralFreeFMSpeciality_PassingScoreExtramuralFreeFMs_PassingScoreExtramuralFreeFMsScoreForMoneyId",
                        column: x => x.PassingScoreExtramuralFreeFMsScoreForMoneyId,
                        principalTable: "PassingScoreExtramuralFreeFMs",
                        principalColumn: "ScoreForMoneyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassingScoreExtramuralFreeFMSpeciality_Speciality_SpecialitysSpecialityName",
                        column: x => x.SpecialitysSpecialityName,
                        principalTable: "Speciality",
                        principalColumn: "SpecialityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speciality_Exams",
                columns: table => new
                {
                    SpecialityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality_Exams", x => new { x.SpecialityId, x.ExamsId });
                    table.ForeignKey(
                        name: "FK_Speciality_Exams_Exams_ExamsId",
                        column: x => x.ExamsId,
                        principalTable: "Exams",
                        principalColumn: "Exams_Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speciality_Exams_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "SpecialityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speciality_Faculties",
                columns: table => new
                {
                    SpecialityNameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacultyNameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacultyName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SpecialityName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality_Faculties", x => new { x.SpecialityNameId, x.FacultyNameId });
                    table.ForeignKey(
                        name: "FK_Speciality_Faculties_Faculties_FacultyName",
                        column: x => x.FacultyName,
                        principalTable: "Faculties",
                        principalColumn: "FacultyName");
                    table.ForeignKey(
                        name: "FK_Speciality_Faculties_Speciality_SpecialityName",
                        column: x => x.SpecialityName,
                        principalTable: "Speciality",
                        principalColumn: "SpecialityName");
                });

            migrationBuilder.CreateTable(
                name: "Speciality_PassingScoreForMoney",
                columns: table => new
                {
                    SpecialityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScoreForMoneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality_PassingScoreForMoney", x => new { x.SpecialityId, x.ScoreForMoneyId });
                    table.ForeignKey(
                        name: "FK_Speciality_PassingScoreForMoney_PassingScoreExtramuralFreeFMs_ScoreForMoneyId",
                        column: x => x.ScoreForMoneyId,
                        principalTable: "PassingScoreExtramuralFreeFMs",
                        principalColumn: "ScoreForMoneyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speciality_PassingScoreForMoney_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "SpecialityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speciality_PassingScoreFrees",
                columns: table => new
                {
                    SpecialityNameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScoreFreeId = table.Column<int>(type: "int", nullable: false),
                    SpecialityName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality_PassingScoreFrees", x => new { x.SpecialityNameId, x.ScoreFreeId });
                    table.ForeignKey(
                        name: "FK_Speciality_PassingScoreFrees_PassingScoreDayFreeFMs_ScoreFreeId",
                        column: x => x.ScoreFreeId,
                        principalTable: "PassingScoreDayFreeFMs",
                        principalColumn: "ScoreFreeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speciality_PassingScoreFrees_Speciality_SpecialityName",
                        column: x => x.SpecialityName,
                        principalTable: "Speciality",
                        principalColumn: "SpecialityName");
                });

            migrationBuilder.CreateTable(
                name: "ComissionsNumber",
                columns: table => new
                {
                    ComissionNumberValue = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UniversityName1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UniversityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComissionsNumber", x => x.ComissionNumberValue);
                    table.ForeignKey(
                        name: "FK_ComissionsNumber_Universities_UniversityName1",
                        column: x => x.UniversityName1,
                        principalTable: "Universities",
                        principalColumn: "UniversityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacultyUniversity",
                columns: table => new
                {
                    FacultiesFacultyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UniversitiesUniversityName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyUniversity", x => new { x.FacultiesFacultyName, x.UniversitiesUniversityName });
                    table.ForeignKey(
                        name: "FK_FacultyUniversity_Faculties_FacultiesFacultyName",
                        column: x => x.FacultiesFacultyName,
                        principalTable: "Faculties",
                        principalColumn: "FacultyName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacultyUniversity_Universities_UniversitiesUniversityName",
                        column: x => x.UniversitiesUniversityName,
                        principalTable: "Universities",
                        principalColumn: "UniversityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "University_Faculties",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacultyId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University_Faculties", x => new { x.UniversityId, x.FacultyId });
                    table.ForeignKey(
                        name: "FK_University_Faculties_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_University_Faculties_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "UniversityName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComissionsNumber_UniversityName1",
                table: "ComissionsNumber",
                column: "UniversityName1");

            migrationBuilder.CreateIndex(
                name: "IX_ExamsSpeciality_SpecialitysSpecialityName",
                table: "ExamsSpeciality",
                column: "SpecialitysSpecialityName");

            migrationBuilder.CreateIndex(
                name: "IX_FacultySpeciality_SpecialitysSpecialityName",
                table: "FacultySpeciality",
                column: "SpecialitysSpecialityName");

            migrationBuilder.CreateIndex(
                name: "IX_FacultyUniversity_UniversitiesUniversityName",
                table: "FacultyUniversity",
                column: "UniversitiesUniversityName");

            migrationBuilder.CreateIndex(
                name: "IX_PassingScoreDayFreeFMSpeciality_SpecialitysSpecialityName",
                table: "PassingScoreDayFreeFMSpeciality",
                column: "SpecialitysSpecialityName");

            migrationBuilder.CreateIndex(
                name: "IX_PassingScoreExtramuralFreeFMSpeciality_SpecialitysSpecialityName",
                table: "PassingScoreExtramuralFreeFMSpeciality",
                column: "SpecialitysSpecialityName");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_TrainingPeriodValue",
                table: "Speciality",
                column: "TrainingPeriodValue");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_Exams_ExamsId",
                table: "Speciality_Exams",
                column: "ExamsId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_Faculties_FacultyName",
                table: "Speciality_Faculties",
                column: "FacultyName");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_Faculties_SpecialityName",
                table: "Speciality_Faculties",
                column: "SpecialityName");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_PassingScoreForMoney_ScoreForMoneyId",
                table: "Speciality_PassingScoreForMoney",
                column: "ScoreForMoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_PassingScoreFrees_ScoreFreeId",
                table: "Speciality_PassingScoreFrees",
                column: "ScoreFreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_PassingScoreFrees_SpecialityName",
                table: "Speciality_PassingScoreFrees",
                column: "SpecialityName");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_RegionsNameRegion",
                table: "Towns",
                column: "RegionsNameRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Universities_TownNameStreetName",
                table: "Universities",
                column: "TownNameStreetName");

            migrationBuilder.CreateIndex(
                name: "IX_University_Faculties_FacultyId",
                table: "University_Faculties",
                column: "FacultyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComissionsNumber");

            migrationBuilder.DropTable(
                name: "ExamsSpeciality");

            migrationBuilder.DropTable(
                name: "FacultySpeciality");

            migrationBuilder.DropTable(
                name: "FacultyUniversity");

            migrationBuilder.DropTable(
                name: "PassingScoreDayFreeFMSpeciality");

            migrationBuilder.DropTable(
                name: "PassingScoreExtramuralFreeFMSpeciality");

            migrationBuilder.DropTable(
                name: "Speciality_Exams");

            migrationBuilder.DropTable(
                name: "Speciality_Faculties");

            migrationBuilder.DropTable(
                name: "Speciality_PassingScoreForMoney");

            migrationBuilder.DropTable(
                name: "Speciality_PassingScoreFrees");

            migrationBuilder.DropTable(
                name: "University_Faculties");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "PassingScoreExtramuralFreeFMs");

            migrationBuilder.DropTable(
                name: "PassingScoreDayFreeFMs");

            migrationBuilder.DropTable(
                name: "Speciality");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "TrainingPeriods");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
