using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DFD_StdMgm.Migrations
{
    /// <inheritdoc />
    public partial class SetCourseStartDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DECLARE @year int = YEAR(GETDATE());
            DECLARE @sept1 date = DATEFROMPARTS(@year, 9, 1);
            DECLARE @firstMonday date = DATEADD(DAY, (9 - DATEPART(WEEKDAY, @sept1)) % 7, @sept1);
            IF @firstMonday < CAST(GETDATE() AS date)
                SET @firstMonday = DATEADD(YEAR, 1, @firstMonday);

            UPDATE Course
            SET CourseStart = @firstMonday
            WHERE CourseStart IS NULL;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Course SET CourseStart = NULL;");
        }
    }
}
