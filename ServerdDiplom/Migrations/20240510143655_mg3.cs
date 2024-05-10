using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerdDiplom.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "FacultyId",
                table: "University_Faculties",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UniversityId",
                table: "University_Faculties",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UniversityLink",
                table: "Universities",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UniversityDescription",
                table: "Universities",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Town_name",
                table: "Universities",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TownNameStreetName",
                table: "Universities",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniversityName",
                table: "Universities",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "TownName",
                table: "Towns",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Regions_Name",
                table: "Towns",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RegionsNameRegion",
                table: "Towns",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetName",
                table: "Towns",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityName",
                table: "Speciality_PassingScoreFrees",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityNameId",
                table: "Speciality_PassingScoreFrees",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityId",
                table: "Speciality_PassingScoreForMoney",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityName",
                table: "Speciality_Faculties",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyName",
                table: "Speciality_Faculties",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyNameId",
                table: "Speciality_Faculties",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityNameId",
                table: "Speciality_Faculties",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ExamsId",
                table: "Speciality_Exams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityId",
                table: "Speciality_Exams",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityName",
                table: "Speciality",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Regions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "FacultyName",
                table: "Faculties",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Exams_Name",
                table: "Exams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UniversityName1",
                table: "ComissionsNumber",
                type: "nvarchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UniversityName",
                table: "ComissionsNumber",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ComissionNumberValue",
                table: "ComissionsNumber",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FacultyId",
                table: "University_Faculties",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "UniversityId",
                table: "University_Faculties",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "UniversityLink",
                table: "Universities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "UniversityDescription",
                table: "Universities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "Town_name",
                table: "Universities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TownNameStreetName",
                table: "Universities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniversityName",
                table: "Universities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "TownName",
                table: "Towns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Regions_Name",
                table: "Towns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "RegionsNameRegion",
                table: "Towns",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetName",
                table: "Towns",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityName",
                table: "Speciality_PassingScoreFrees",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityNameId",
                table: "Speciality_PassingScoreFrees",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityId",
                table: "Speciality_PassingScoreForMoney",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityName",
                table: "Speciality_Faculties",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyName",
                table: "Speciality_Faculties",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyNameId",
                table: "Speciality_Faculties",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityNameId",
                table: "Speciality_Faculties",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ExamsId",
                table: "Speciality_Exams",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityId",
                table: "Speciality_Exams",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialityName",
                table: "Speciality",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Regions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyName",
                table: "Faculties",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Exams_Name",
                table: "Exams",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "UniversityName1",
                table: "ComissionsNumber",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "UniversityName",
                table: "ComissionsNumber",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ComissionNumberValue",
                table: "ComissionsNumber",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

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
        }
    }
}
