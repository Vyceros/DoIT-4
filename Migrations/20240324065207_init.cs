using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoIT.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LectorName",
                table: "Lectors",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Lectors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Lectors");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Lectors",
                newName: "LectorName");
        }
    }
}
