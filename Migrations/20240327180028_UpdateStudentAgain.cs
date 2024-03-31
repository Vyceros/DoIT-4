using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoIT.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudentAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Students",
                newName: "LastName");
        }
    }
}
