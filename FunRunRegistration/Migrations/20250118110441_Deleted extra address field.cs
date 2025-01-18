using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunRunRegistration.Migrations
{
    /// <inheritdoc />
    public partial class Deletedextraaddressfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrants_Addresses_AddressId",
                table: "Registrants");

            migrationBuilder.DropIndex(
                name: "IX_Registrants_AddressId",
                table: "Registrants");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Registrants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Registrants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registrants_AddressId",
                table: "Registrants",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrants_Addresses_AddressId",
                table: "Registrants",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId");
        }
    }
}
