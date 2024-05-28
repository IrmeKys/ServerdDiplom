using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerdDiplom.Migrations
{
    /// <inheritdoc />
    public partial class mg8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speciality_PassingScoreForMoney");

            migrationBuilder.DropTable(
                name: "PassingScoreExtramuralFreeFMs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PassingScoreExtramuralFreeFMs",
                columns: table => new
                {
                    ScoreForMoneyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassingScoreValueExtramuralForMoney = table.Column<int>(type: "int", nullable: false),
                    PassingScoreValueExtramuralFree = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassingScoreExtramuralFreeFMs", x => x.ScoreForMoneyId);
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

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_PassingScoreForMoney_ScoreForMoneyId",
                table: "Speciality_PassingScoreForMoney",
                column: "ScoreForMoneyId");
        }
    }
}
