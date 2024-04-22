using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CachedRepository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Student",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
