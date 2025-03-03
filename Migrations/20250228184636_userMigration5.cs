using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace premozi.Migrations
{
    /// <inheritdoc />
    public partial class userMigration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "priviledges",
                table: "Felhasznalok",
                type: "int(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "priviledges",
                table: "Felhasznalok");
        }
    }
}
