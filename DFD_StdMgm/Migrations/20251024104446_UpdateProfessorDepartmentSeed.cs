using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DFD_StdMgm.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProfessorDepartmentSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Professor",
                newName: "ProfessorTitle");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Computer Science Department" },
                    { 2, "Biology Department" },
                    { 3, "Physics Department" },
                    { 4, "Chemistry Department" }
                });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "ProfessorID", "DepartmentID", "ProfessorName", "ProfessorTitle" },
                values: new object[,]
                {
                    { 1, 3, "Anders Sand", "Teacher" },
                    { 2, 4, "Benny Larsen", "Teacher" },
                    { 3, 1, "Christine Smith", "Teacher" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Professor",
                keyColumn: "ProfessorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Professor",
                keyColumn: "ProfessorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Professor",
                keyColumn: "ProfessorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "ProfessorTitle",
                table: "Professor",
                newName: "Title");
        }
    }
}
