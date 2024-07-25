using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppPracticWork_1_var1.Migrations
{
    /// <inheritdoc />
    public partial class Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_workerJournals_WorkerJournalId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_WorkerJournalId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "WorkerJournalId",
                table: "employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "workerJournals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_workerJournals_EmployeeId",
                table: "workerJournals",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_workerJournals_employees_EmployeeId",
                table: "workerJournals",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_workerJournals_employees_EmployeeId",
                table: "workerJournals");

            migrationBuilder.DropIndex(
                name: "IX_workerJournals_EmployeeId",
                table: "workerJournals");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "workerJournals");

            migrationBuilder.AddColumn<int>(
                name: "WorkerJournalId",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_WorkerJournalId",
                table: "employees",
                column: "WorkerJournalId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_workerJournals_WorkerJournalId",
                table: "employees",
                column: "WorkerJournalId",
                principalTable: "workerJournals",
                principalColumn: "Id");
        }
    }
}
