using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp7.Migrations
{
    /// <inheritdoc />
    public partial class AddBlablabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Blablabla",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Blablabla",
                table: "Clients");
        }
    }
}
