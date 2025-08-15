using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class make_companyId_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainRoles_Companies_CompanyId",
                table: "MainRoles");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "MainRoles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_MainRoles_Companies_CompanyId",
                table: "MainRoles",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainRoles_Companies_CompanyId",
                table: "MainRoles");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "MainRoles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MainRoles_Companies_CompanyId",
                table: "MainRoles",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
