using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session2Again.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenEmployeeAndAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employees_DeptManagerId",
                schema: "Sales",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_DeptManagerId",
                schema: "Sales",
                table: "Department");

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                schema: "Sales",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Department_ManagerId",
                schema: "Sales",
                table: "Department",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "Sales",
                table: "Department",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "Sales",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_ManagerId",
                schema: "Sales",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "EmpAddress_City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Country",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Street",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                schema: "Sales",
                table: "Department");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DeptManagerId",
                schema: "Sales",
                table: "Department",
                column: "DeptManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employees_DeptManagerId",
                schema: "Sales",
                table: "Department",
                column: "DeptManagerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
