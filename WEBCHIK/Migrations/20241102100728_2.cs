using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBCHIK.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_PhotoId",
                table: "Employees",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Photos_PhotoId",
                table: "Employees",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Photos_PhotoId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PhotoId",
                table: "Employees");
        }
    }
}
