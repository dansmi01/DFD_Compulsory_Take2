using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DFD_StdMgm.Migrations
{
    /// <inheritdoc />
    public partial class CreateModelsAndRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorID",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    ProfessorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.ProfessorID);
                    table.ForeignKey(
                        name: "FK_Professor_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1,
                columns: new[] { "DepartmentID", "ProfessorID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2,
                columns: new[] { "DepartmentID", "ProfessorID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3,
                columns: new[] { "DepartmentID", "ProfessorID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4,
                columns: new[] { "DepartmentID", "ProfessorID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5,
                columns: new[] { "DepartmentID", "ProfessorID" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Course_DepartmentID",
                table: "Course",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ProfessorID",
                table: "Course",
                column: "ProfessorID");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_DepartmentID",
                table: "Professor",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Professor_ProfessorID",
                table: "Course",
                column: "ProfessorID",
                principalTable: "Professor",
                principalColumn: "ProfessorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Professor_ProfessorID",
                table: "Course");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Course_DepartmentID",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_ProfessorID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "ProfessorID",
                table: "Course");
        }
    }
}
