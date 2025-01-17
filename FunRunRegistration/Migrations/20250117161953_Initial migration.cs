using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunRunRegistration.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    addressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    addressStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressPostal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.addressId);
                });

            migrationBuilder.CreateTable(
                name: "Registrants",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userAddressId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userBirthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userBirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userGender = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrants", x => x.userId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Registrants");
        }
    }
}
