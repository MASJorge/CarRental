using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c6a390f6-6cb1-48ae-ba5f-62693586a7c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "a570d773-f87a-41c8-990d-ca40acf760b7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16b90d05-6864-43de-8c7a-2225e76602be", "AQAAAAEAACcQAAAAEHVgu5jBgj8MvAOux7YEyuPrbxsiee2IBtLCUIvOUmeV11H7vqCrpLoSk1SkKlKjBg==", "84d11edf-a30c-4de1-aeee-ffff3f23d9aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1751455d-7860-4625-a3a0-1e7d494cacad", "AQAAAAEAACcQAAAAELMaXOfHcsN6jlMCfOVBdCWALElV6wXR4jhzTVAC0ciCgiPdk6FDzP/RVen81pegMQ==", "7ac814d7-d80f-4b25-ade2-850897451f5e" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1503), new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1515), new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1771), new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1775), new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1881), new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1884), new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1887), new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1889), new DateTime(2022, 4, 18, 22, 56, 19, 756, DateTimeKind.Local).AddTicks(1890) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "feb08f03-1936-4912-851b-670234b8e5c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "082c14b5-098f-49f5-8ea7-b0a97ed231cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa19ad13-5d71-4968-9a21-0a1386434e64", "AQAAAAEAACcQAAAAEPPJwDBoqARRe2ePc2qW9co+uObAlkOFrv12mvRi1b+rSP705Qs5lBtdrBNJHxCKVg==", "9555f25d-d807-48c5-bb89-dbd6ba3be62b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec4da40a-de49-4ca3-b9f2-0573b1bfa5bb", "AQAAAAEAACcQAAAAEHX/mQjSuVjCiy8kBnWRpkFIAnhw9JVe4Fguwobbzln1SfmAtN1KBoPdoXXXrl9yMw==", "59787bd2-5ca9-48df-9a2a-1a689c078ec6" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(7620), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8268), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8275), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8575), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8589), new DateTime(2022, 4, 18, 22, 47, 38, 318, DateTimeKind.Local).AddTicks(8591) });
        }
    }
}
