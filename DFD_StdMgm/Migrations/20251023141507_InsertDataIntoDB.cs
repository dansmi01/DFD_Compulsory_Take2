using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DFD_StdMgm.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataIntoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "CourseName", "CourseStart", "Grade" },
                values: new object[,]
                {
                    { 1, "Mathematics", null, null },
                    { 2, "Physics", null, null },
                    { 3, "Chemistry", null, null },
                    { 4, "Biology", null, null },
                    { 5, "Computer Science", null, null }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentID", "StudentAge", "StudentName" },
                values: new object[,]
                {
                    { 1, 20, "Alice Johnson" },
                    { 2, 21, "Bob Smith" },
                    { 3, 22, "Charlie Brown" },
                    { 4, 23, "Diana Prince" },
                    { 5, 24, "Ethan Hunt" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1L, 1, 1 },
                    { 2L, 2, 1 },
                    { 3L, 3, 1 },
                    { 4L, 4, 1 },
                    { 5L, 1, 2 },
                    { 6L, 2, 2 },
                    { 7L, 3, 2 },
                    { 8L, 4, 2 },
                    { 9L, 1, 3 },
                    { 10L, 2, 3 },
                    { 11L, 3, 3 },
                    { 12L, 1, 4 },
                    { 13L, 2, 4 },
                    { 14L, 3, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentID",
                keyValue: 4);
        }
    }
}
