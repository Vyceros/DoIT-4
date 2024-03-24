using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoIT.Migrations
{
    /// <inheritdoc />
    public partial class upt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Lectors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Lectors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
