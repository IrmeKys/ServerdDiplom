using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerdDiplom.Migrations
{
    /// <inheritdoc />
    public partial class mg4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_University_Faculties_Faculties_FacultyId",
                table: "University_Faculties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_University_Faculties",
                table: "University_Faculties");

            migrationBuilder.DropColumn(
                name: "FacultyName",
                table: "University_Faculties");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "University_Faculties",
                type: "int",
                maxLength: 200,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_University_Faculties",
                table: "University_Faculties",
                columns: new[] { "UniversityId", "FacultyId" });

            migrationBuilder.AddForeignKey(
                name: "FK_University_Faculties_Faculties_FacultyId",
                table: "University_Faculties",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_University_Faculties_Faculties_FacultyId",
                table: "University_Faculties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_University_Faculties",
                table: "University_Faculties");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "University_Faculties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<int>(
                name: "FacultyName",
                table: "University_Faculties",
                type: "int",
                maxLength: 200,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_University_Faculties",
                table: "University_Faculties",
                columns: new[] { "UniversityId", "FacultyName" });

            migrationBuilder.AddForeignKey(
                name: "FK_University_Faculties_Faculties_FacultyId",
                table: "University_Faculties",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id");
        }
    }
}
