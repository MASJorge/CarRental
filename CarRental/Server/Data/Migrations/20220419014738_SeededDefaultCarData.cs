using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "feb08f03-1936-4912-851b-670234b8e5c0", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "082c14b5-098f-49f5-8ea7-b0a97ed231cc", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "fa19ad13-5d71-4968-9a21-0a1386434e64", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPPJwDBoqARRe2ePc2qW9co+uObAlkOFrv12mvRi1b+rSP705Qs5lBtdrBNJHxCKVg==", null, false, "9555f25d-d807-48c5-bb89-dbd6ba3be62b", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "ec4da40a-de49-4ca3-b9f2-0573b1bfa5bb", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHX/mQjSuVjCiy8kBnWRpkFIAnhw9JVe4Fguwobbzln1SfmAtN1KBoPdoXXXrl9yMw==", null, false, "59787bd2-5ca9-48df-9a2a-1a689c078ec6", false, "User@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(7620), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(7634), "Black", "System" },
                    { 2, "System", new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(7641), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8268), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8270), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8275), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8276), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8575), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8577), "Prius", "System" },
                    { 2, "System", new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8582), "Corolla", "System" },
                    { 3, "System", new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8586), "3 Series", "System" },
                    { 4, "System", new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8589), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8591), "X2", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");
        }
    }
}
