using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunRunRegistration.Migrations
{
    /// <inheritdoc />
    public partial class Deletedextrafield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userTelephone",
                table: "Registrants",
                newName: "UserTelephone");

            migrationBuilder.RenameColumn(
                name: "userLastName",
                table: "Registrants",
                newName: "UserLastName");

            migrationBuilder.RenameColumn(
                name: "userGender",
                table: "Registrants",
                newName: "UserGender");

            migrationBuilder.RenameColumn(
                name: "userFirstName",
                table: "Registrants",
                newName: "UserFirstName");

            migrationBuilder.RenameColumn(
                name: "userBirthday",
                table: "Registrants",
                newName: "UserBirthday");

            migrationBuilder.RenameColumn(
                name: "userAddressId",
                table: "Registrants",
                newName: "UserAddressId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Registrants",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "addressStreet",
                table: "Addresses",
                newName: "AddressStreet");

            migrationBuilder.RenameColumn(
                name: "addressPostal",
                table: "Addresses",
                newName: "AddressPostal");

            migrationBuilder.RenameColumn(
                name: "addressCity",
                table: "Addresses",
                newName: "AddressCity");

            migrationBuilder.RenameColumn(
                name: "addressId",
                table: "Addresses",
                newName: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserTelephone",
                table: "Registrants",
                newName: "userTelephone");

            migrationBuilder.RenameColumn(
                name: "UserLastName",
                table: "Registrants",
                newName: "userLastName");

            migrationBuilder.RenameColumn(
                name: "UserGender",
                table: "Registrants",
                newName: "userGender");

            migrationBuilder.RenameColumn(
                name: "UserFirstName",
                table: "Registrants",
                newName: "userFirstName");

            migrationBuilder.RenameColumn(
                name: "UserBirthday",
                table: "Registrants",
                newName: "userBirthday");

            migrationBuilder.RenameColumn(
                name: "UserAddressId",
                table: "Registrants",
                newName: "userAddressId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Registrants",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "AddressStreet",
                table: "Addresses",
                newName: "addressStreet");

            migrationBuilder.RenameColumn(
                name: "AddressPostal",
                table: "Addresses",
                newName: "addressPostal");

            migrationBuilder.RenameColumn(
                name: "AddressCity",
                table: "Addresses",
                newName: "addressCity");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Addresses",
                newName: "addressId");

            migrationBuilder.AddColumn<string>(
                name: "userBirthDate",
                table: "Registrants",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
