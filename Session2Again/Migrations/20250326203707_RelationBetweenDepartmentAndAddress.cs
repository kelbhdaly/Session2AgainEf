using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session2Again.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenDepartmentAndAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_City",
                schema: "Sales",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Country",
                schema: "Sales",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Street",
                schema: "Sales",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpAddress_City",
                schema: "Sales",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Country",
                schema: "Sales",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Street",
                schema: "Sales",
                table: "Department");
        }
    }
}
