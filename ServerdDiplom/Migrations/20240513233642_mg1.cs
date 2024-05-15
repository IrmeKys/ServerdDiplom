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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exams_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingPeriodValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegionsNameId = table.Column<int>(type: "int", nullable: true),
                    Regions_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Towns_Regions_RegionsNameId",
                        column: x => x.RegionsNameId,
                        principalTable: "Regions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TrainingPeriodId = table.Column<int>(type: "int", nullable: true),
                    Trainin_Period = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speciality_TrainingPeriods_TrainingPeriodId",
                        column: x => x.TrainingPeriodId,
                        principalTable: "TrainingPeriods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UniversityDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    UniversityLink = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TownNameId = table.Column<int>(type: "int", nullable: true),
                    Town_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Universities_Towns_TownNameId",
                        column: x => x.TownNameId,
                        principalTable: "Towns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Speciality_Exams",
                columns: table => new
                {
                    SpecialityId = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    ExamsId = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality_Exams", x => new { x.SpecialityId, x.ExamsId });
                    table.ForeignKey(
                        name: "FK_Speciality_Exams_Exams_ExamsId",
                        column: x => x.ExamsId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speciality_Exams_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speciality_Faculties",
                columns: table => new
                {
                    SpecialityId = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    FacultyId = table.Column<int>(type: "int", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality_Faculties", x => new { x.SpecialityId, x.FacultyId });
                    table.ForeignKey(
                        name: "FK_Speciality_Faculties_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speciality_Faculties_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speciality_PassingScoreForMoney",
                columns: table => new
                {
                    SpecialityId = table.Column<int>(type: "int", maxLength: 200, nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speciality_PassingScoreFrees",
                columns: table => new
                {
                    SpecialityId = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    ScoreFreeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality_PassingScoreFrees", x => new { x.SpecialityId, x.ScoreFreeId });
                    table.ForeignKey(
                        name: "FK_Speciality_PassingScoreFrees_PassingScoreDayFreeFMs_ScoreFreeId",
                        column: x => x.ScoreFreeId,
                        principalTable: "PassingScoreDayFreeFMs",
                        principalColumn: "ScoreFreeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speciality_PassingScoreFrees_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComissionsNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComissionNumberValue = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    UniversityId = table.Column<int>(type: "int", nullable: true),
                    UniversityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComissionsNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComissionsNumber_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "University_Faculties",
                columns: table => new
                {
                    UniversityId = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    FacultyName = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University_Faculties", x => new { x.UniversityId, x.FacultyName });
                    table.ForeignKey(
                        name: "FK_University_Faculties_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_University_Faculties_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComissionsNumber_UniversityId",
                table: "ComissionsNumber",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_TrainingPeriodId",
                table: "Speciality",
                column: "TrainingPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_Exams_ExamsId",
                table: "Speciality_Exams",
                column: "ExamsId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_Faculties_FacultyId",
                table: "Speciality_Faculties",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_PassingScoreForMoney_ScoreForMoneyId",
                table: "Speciality_PassingScoreForMoney",
                column: "ScoreForMoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_PassingScoreFrees_ScoreFreeId",
                table: "Speciality_PassingScoreFrees",
                column: "ScoreFreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_RegionsNameId",
                table: "Towns",
                column: "RegionsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Universities_TownNameId",
                table: "Universities",
                column: "TownNameId");

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
