using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIAuthenticate.Migrations
{
    public partial class AddedRefreshAndAccessTokenToTheIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccessToken",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 1-20250223202155", "Product 1-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 2-20250223202155", "Product 2-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 3-20250223202155", "Product 3-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 4-20250223202155", "Product 4-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 5-20250223202155", "Product 5-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 6-20250223202155", "Product 6-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 7-20250223202155", "Product 7-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 8-20250223202155", "Product 8-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 9-20250223202155", "Product 9-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 10-20250223202155", "Product 10-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 11-20250223202155", "Product 11-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 12-20250223202155", "Product 12-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 13-20250223202155", "Product 13-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 14-20250223202155", "Product 14-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 15-20250223202155", "Product 15-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 16-20250223202155", "Product 16-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 17-20250223202155", "Product 17-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 18-20250223202155", "Product 18-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 19-20250223202155", "Product 19-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 20-20250223202155", "Product 20-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 21-20250223202155", "Product 21-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 22-20250223202155", "Product 22-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 23-20250223202155", "Product 23-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 24-20250223202155", "Product 24-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 25-20250223202155", "Product 25-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 26-20250223202155", "Product 26-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 27-20250223202155", "Product 27-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 28-20250223202155", "Product 28-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 29-20250223202155", "Product 29-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 30-20250223202155", "Product 30-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 31-20250223202155", "Product 31-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 32-20250223202155", "Product 32-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 33-20250223202155", "Product 33-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 34-20250223202155", "Product 34-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 35-20250223202155", "Product 35-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 36-20250223202155", "Product 36-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 37-20250223202155", "Product 37-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 38-20250223202155", "Product 38-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 39-20250223202155", "Product 39-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 40-20250223202155", "Product 40-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 41-20250223202155", "Product 41-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 42-20250223202155", "Product 42-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 43-20250223202155", "Product 43-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 44-20250223202155", "Product 44-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 45-20250223202155", "Product 45-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 46-20250223202155", "Product 46-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 47-20250223202155", "Product 47-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 48-20250223202155", "Product 48-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 49-20250223202155", "Product 49-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 50-20250223202155", "Product 50-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 51-20250223202155", "Product 51-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 52-20250223202155", "Product 52-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 53-20250223202155", "Product 53-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 54-20250223202155", "Product 54-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 55-20250223202155", "Product 55-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 56-20250223202155", "Product 56-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 57-20250223202155", "Product 57-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 58-20250223202155", "Product 58-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 59-20250223202155", "Product 59-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 60-20250223202155", "Product 60-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 61-20250223202155", "Product 61-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 62-20250223202155", "Product 62-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 63-20250223202155", "Product 63-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 64-20250223202155", "Product 64-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 65-20250223202155", "Product 65-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 66-20250223202155", "Product 66-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 67-20250223202155", "Product 67-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 68-20250223202155", "Product 68-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 69-20250223202155", "Product 69-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 70-20250223202155", "Product 70-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 71-20250223202155", "Product 71-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 72-20250223202155", "Product 72-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 73-20250223202155", "Product 73-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 74-20250223202155", "Product 74-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 75-20250223202155", "Product 75-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 76-20250223202155", "Product 76-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 77-20250223202155", "Product 77-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 78-20250223202155", "Product 78-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 79-20250223202155", "Product 79-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 80-20250223202155", "Product 80-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 81-20250223202155", "Product 81-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 82-20250223202155", "Product 82-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 83-20250223202155", "Product 83-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 84-20250223202155", "Product 84-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 85-20250223202155", "Product 85-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 86-20250223202155", "Product 86-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 87-20250223202155", "Product 87-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 88-20250223202155", "Product 88-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 89-20250223202155", "Product 89-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 90-20250223202155", "Product 90-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 91-20250223202155", "Product 91-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 92-20250223202155", "Product 92-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 93-20250223202155", "Product 93-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 94-20250223202155", "Product 94-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 95-20250223202155", "Product 95-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 96-20250223202155", "Product 96-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 97-20250223202155", "Product 97-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 98-20250223202155", "Product 98-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 99-20250223202155", "Product 99-20250223202155" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 100-20250223202155", "Product 100-20250223202155" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 1-20241228002754", "Product 1-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 2-20241228002754", "Product 2-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 3-20241228002754", "Product 3-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 4-20241228002754", "Product 4-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 5-20241228002754", "Product 5-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 6-20241228002754", "Product 6-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 7-20241228002754", "Product 7-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 8-20241228002754", "Product 8-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 9-20241228002754", "Product 9-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 10-20241228002754", "Product 10-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 11-20241228002754", "Product 11-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 12-20241228002754", "Product 12-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 13-20241228002754", "Product 13-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 14-20241228002754", "Product 14-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 15-20241228002754", "Product 15-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 16-20241228002754", "Product 16-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 17-20241228002754", "Product 17-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 18-20241228002754", "Product 18-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 19-20241228002754", "Product 19-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 20-20241228002754", "Product 20-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 21-20241228002754", "Product 21-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 22-20241228002754", "Product 22-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 23-20241228002754", "Product 23-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 24-20241228002754", "Product 24-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 25-20241228002754", "Product 25-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 26-20241228002754", "Product 26-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 27-20241228002754", "Product 27-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 28-20241228002754", "Product 28-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 29-20241228002754", "Product 29-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 30-20241228002754", "Product 30-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 31-20241228002754", "Product 31-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 32-20241228002754", "Product 32-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 33-20241228002754", "Product 33-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 34-20241228002754", "Product 34-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 35-20241228002754", "Product 35-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 36-20241228002754", "Product 36-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 37-20241228002754", "Product 37-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 38-20241228002754", "Product 38-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 39-20241228002754", "Product 39-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 40-20241228002754", "Product 40-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 41-20241228002754", "Product 41-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 42-20241228002754", "Product 42-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 43-20241228002754", "Product 43-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 44-20241228002754", "Product 44-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 45-20241228002754", "Product 45-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 46-20241228002754", "Product 46-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 47-20241228002754", "Product 47-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 48-20241228002754", "Product 48-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 49-20241228002754", "Product 49-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 50-20241228002754", "Product 50-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 51-20241228002754", "Product 51-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 52-20241228002754", "Product 52-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 53-20241228002754", "Product 53-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 54-20241228002754", "Product 54-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 55-20241228002754", "Product 55-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 56-20241228002754", "Product 56-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 57-20241228002754", "Product 57-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 58-20241228002754", "Product 58-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 59-20241228002754", "Product 59-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 60-20241228002754", "Product 60-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 61-20241228002754", "Product 61-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 62-20241228002754", "Product 62-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 63-20241228002754", "Product 63-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 64-20241228002754", "Product 64-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 65-20241228002754", "Product 65-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 66-20241228002754", "Product 66-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 67-20241228002754", "Product 67-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 68-20241228002754", "Product 68-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 69-20241228002754", "Product 69-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 70-20241228002754", "Product 70-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 71-20241228002754", "Product 71-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 72-20241228002754", "Product 72-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 73-20241228002754", "Product 73-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 74-20241228002754", "Product 74-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 75-20241228002754", "Product 75-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 76-20241228002754", "Product 76-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 77-20241228002754", "Product 77-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 78-20241228002754", "Product 78-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 79-20241228002754", "Product 79-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 80-20241228002754", "Product 80-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 81-20241228002754", "Product 81-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 82-20241228002754", "Product 82-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 83-20241228002754", "Product 83-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 84-20241228002754", "Product 84-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 85-20241228002754", "Product 85-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 86-20241228002754", "Product 86-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 87-20241228002754", "Product 87-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 88-20241228002754", "Product 88-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 89-20241228002754", "Product 89-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 90-20241228002754", "Product 90-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 91-20241228002754", "Product 91-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 92-20241228002754", "Product 92-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 93-20241228002754", "Product 93-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 94-20241228002754", "Product 94-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 95-20241228002754", "Product 95-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 96-20241228002754", "Product 96-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 97-20241228002754", "Product 97-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 98-20241228002754", "Product 98-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 99-20241228002754", "Product 99-20241228002754" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This description is for product 100-20241228002754", "Product 100-20241228002754" });
        }
    }
}
