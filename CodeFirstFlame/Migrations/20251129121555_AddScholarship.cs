using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstFlame.Migrations
{
    /// <inheritdoc />
    public partial class AddScholarship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Scholarship",
                table: "Students",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scholarship",
                table: "Students");
        }
    }
}
