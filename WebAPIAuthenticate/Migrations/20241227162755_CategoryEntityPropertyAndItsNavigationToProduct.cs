using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIAuthenticate.Migrations
{
    public partial class CategoryEntityPropertyAndItsNavigationToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Essential" },
                    { 2, "Apparel" },
                    { 3, "Gadgets" },
                    { 4, "Musical Instruments" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "This description is for product 1-20241228002754", "Product 1-20241228002754", 1.99m },
                    { 73, 1, "This description is for product 73-20241228002754", "Product 73-20241228002754", 1.99m },
                    { 72, 1, "This description is for product 72-20241228002754", "Product 72-20241228002754", 1.99m },
                    { 71, 1, "This description is for product 71-20241228002754", "Product 71-20241228002754", 1.99m },
                    { 70, 1, "This description is for product 70-20241228002754", "Product 70-20241228002754", 1.99m },
                    { 69, 1, "This description is for product 69-20241228002754", "Product 69-20241228002754", 1.99m },
                    { 68, 1, "This description is for product 68-20241228002754", "Product 68-20241228002754", 1.99m },
                    { 67, 1, "This description is for product 67-20241228002754", "Product 67-20241228002754", 1.99m },
                    { 66, 1, "This description is for product 66-20241228002754", "Product 66-20241228002754", 1.99m },
                    { 65, 1, "This description is for product 65-20241228002754", "Product 65-20241228002754", 1.99m },
                    { 64, 1, "This description is for product 64-20241228002754", "Product 64-20241228002754", 1.99m },
                    { 63, 1, "This description is for product 63-20241228002754", "Product 63-20241228002754", 1.99m },
                    { 62, 1, "This description is for product 62-20241228002754", "Product 62-20241228002754", 1.99m },
                    { 61, 1, "This description is for product 61-20241228002754", "Product 61-20241228002754", 1.99m },
                    { 60, 1, "This description is for product 60-20241228002754", "Product 60-20241228002754", 1.99m },
                    { 59, 1, "This description is for product 59-20241228002754", "Product 59-20241228002754", 1.99m },
                    { 58, 1, "This description is for product 58-20241228002754", "Product 58-20241228002754", 1.99m },
                    { 57, 1, "This description is for product 57-20241228002754", "Product 57-20241228002754", 1.99m },
                    { 56, 1, "This description is for product 56-20241228002754", "Product 56-20241228002754", 1.99m },
                    { 55, 1, "This description is for product 55-20241228002754", "Product 55-20241228002754", 1.99m },
                    { 54, 1, "This description is for product 54-20241228002754", "Product 54-20241228002754", 1.99m },
                    { 53, 1, "This description is for product 53-20241228002754", "Product 53-20241228002754", 1.99m },
                    { 74, 1, "This description is for product 74-20241228002754", "Product 74-20241228002754", 1.99m },
                    { 52, 1, "This description is for product 52-20241228002754", "Product 52-20241228002754", 1.99m },
                    { 75, 1, "This description is for product 75-20241228002754", "Product 75-20241228002754", 1.99m },
                    { 77, 1, "This description is for product 77-20241228002754", "Product 77-20241228002754", 1.99m },
                    { 98, 1, "This description is for product 98-20241228002754", "Product 98-20241228002754", 1.99m },
                    { 97, 1, "This description is for product 97-20241228002754", "Product 97-20241228002754", 1.99m },
                    { 96, 1, "This description is for product 96-20241228002754", "Product 96-20241228002754", 1.99m },
                    { 95, 1, "This description is for product 95-20241228002754", "Product 95-20241228002754", 1.99m },
                    { 94, 1, "This description is for product 94-20241228002754", "Product 94-20241228002754", 1.99m },
                    { 93, 1, "This description is for product 93-20241228002754", "Product 93-20241228002754", 1.99m },
                    { 92, 1, "This description is for product 92-20241228002754", "Product 92-20241228002754", 1.99m },
                    { 91, 1, "This description is for product 91-20241228002754", "Product 91-20241228002754", 1.99m },
                    { 90, 1, "This description is for product 90-20241228002754", "Product 90-20241228002754", 1.99m },
                    { 89, 1, "This description is for product 89-20241228002754", "Product 89-20241228002754", 1.99m },
                    { 88, 1, "This description is for product 88-20241228002754", "Product 88-20241228002754", 1.99m },
                    { 87, 1, "This description is for product 87-20241228002754", "Product 87-20241228002754", 1.99m },
                    { 86, 1, "This description is for product 86-20241228002754", "Product 86-20241228002754", 1.99m },
                    { 85, 1, "This description is for product 85-20241228002754", "Product 85-20241228002754", 1.99m },
                    { 84, 1, "This description is for product 84-20241228002754", "Product 84-20241228002754", 1.99m },
                    { 83, 1, "This description is for product 83-20241228002754", "Product 83-20241228002754", 1.99m },
                    { 82, 1, "This description is for product 82-20241228002754", "Product 82-20241228002754", 1.99m },
                    { 81, 1, "This description is for product 81-20241228002754", "Product 81-20241228002754", 1.99m },
                    { 80, 1, "This description is for product 80-20241228002754", "Product 80-20241228002754", 1.99m },
                    { 79, 1, "This description is for product 79-20241228002754", "Product 79-20241228002754", 1.99m },
                    { 78, 1, "This description is for product 78-20241228002754", "Product 78-20241228002754", 1.99m },
                    { 76, 1, "This description is for product 76-20241228002754", "Product 76-20241228002754", 1.99m },
                    { 51, 1, "This description is for product 51-20241228002754", "Product 51-20241228002754", 1.99m },
                    { 50, 1, "This description is for product 50-20241228002754", "Product 50-20241228002754", 1.99m },
                    { 49, 1, "This description is for product 49-20241228002754", "Product 49-20241228002754", 1.99m },
                    { 22, 1, "This description is for product 22-20241228002754", "Product 22-20241228002754", 1.99m },
                    { 21, 1, "This description is for product 21-20241228002754", "Product 21-20241228002754", 1.99m },
                    { 20, 1, "This description is for product 20-20241228002754", "Product 20-20241228002754", 1.99m },
                    { 19, 1, "This description is for product 19-20241228002754", "Product 19-20241228002754", 1.99m },
                    { 18, 1, "This description is for product 18-20241228002754", "Product 18-20241228002754", 1.99m },
                    { 17, 1, "This description is for product 17-20241228002754", "Product 17-20241228002754", 1.99m },
                    { 16, 1, "This description is for product 16-20241228002754", "Product 16-20241228002754", 1.99m },
                    { 15, 1, "This description is for product 15-20241228002754", "Product 15-20241228002754", 1.99m },
                    { 14, 1, "This description is for product 14-20241228002754", "Product 14-20241228002754", 1.99m },
                    { 13, 1, "This description is for product 13-20241228002754", "Product 13-20241228002754", 1.99m },
                    { 12, 1, "This description is for product 12-20241228002754", "Product 12-20241228002754", 1.99m },
                    { 11, 1, "This description is for product 11-20241228002754", "Product 11-20241228002754", 1.99m },
                    { 10, 1, "This description is for product 10-20241228002754", "Product 10-20241228002754", 1.99m },
                    { 9, 1, "This description is for product 9-20241228002754", "Product 9-20241228002754", 1.99m },
                    { 8, 1, "This description is for product 8-20241228002754", "Product 8-20241228002754", 1.99m },
                    { 7, 1, "This description is for product 7-20241228002754", "Product 7-20241228002754", 1.99m },
                    { 6, 1, "This description is for product 6-20241228002754", "Product 6-20241228002754", 1.99m },
                    { 5, 1, "This description is for product 5-20241228002754", "Product 5-20241228002754", 1.99m },
                    { 4, 1, "This description is for product 4-20241228002754", "Product 4-20241228002754", 1.99m },
                    { 3, 1, "This description is for product 3-20241228002754", "Product 3-20241228002754", 1.99m },
                    { 2, 1, "This description is for product 2-20241228002754", "Product 2-20241228002754", 1.99m },
                    { 23, 1, "This description is for product 23-20241228002754", "Product 23-20241228002754", 1.99m },
                    { 24, 1, "This description is for product 24-20241228002754", "Product 24-20241228002754", 1.99m },
                    { 25, 1, "This description is for product 25-20241228002754", "Product 25-20241228002754", 1.99m },
                    { 26, 1, "This description is for product 26-20241228002754", "Product 26-20241228002754", 1.99m },
                    { 48, 1, "This description is for product 48-20241228002754", "Product 48-20241228002754", 1.99m },
                    { 47, 1, "This description is for product 47-20241228002754", "Product 47-20241228002754", 1.99m },
                    { 46, 1, "This description is for product 46-20241228002754", "Product 46-20241228002754", 1.99m },
                    { 45, 1, "This description is for product 45-20241228002754", "Product 45-20241228002754", 1.99m },
                    { 44, 1, "This description is for product 44-20241228002754", "Product 44-20241228002754", 1.99m },
                    { 43, 1, "This description is for product 43-20241228002754", "Product 43-20241228002754", 1.99m },
                    { 42, 1, "This description is for product 42-20241228002754", "Product 42-20241228002754", 1.99m },
                    { 41, 1, "This description is for product 41-20241228002754", "Product 41-20241228002754", 1.99m },
                    { 40, 1, "This description is for product 40-20241228002754", "Product 40-20241228002754", 1.99m },
                    { 39, 1, "This description is for product 39-20241228002754", "Product 39-20241228002754", 1.99m },
                    { 99, 1, "This description is for product 99-20241228002754", "Product 99-20241228002754", 1.99m },
                    { 38, 1, "This description is for product 38-20241228002754", "Product 38-20241228002754", 1.99m },
                    { 36, 1, "This description is for product 36-20241228002754", "Product 36-20241228002754", 1.99m },
                    { 35, 1, "This description is for product 35-20241228002754", "Product 35-20241228002754", 1.99m },
                    { 34, 1, "This description is for product 34-20241228002754", "Product 34-20241228002754", 1.99m },
                    { 33, 1, "This description is for product 33-20241228002754", "Product 33-20241228002754", 1.99m },
                    { 32, 1, "This description is for product 32-20241228002754", "Product 32-20241228002754", 1.99m },
                    { 31, 1, "This description is for product 31-20241228002754", "Product 31-20241228002754", 1.99m },
                    { 30, 1, "This description is for product 30-20241228002754", "Product 30-20241228002754", 1.99m },
                    { 29, 1, "This description is for product 29-20241228002754", "Product 29-20241228002754", 1.99m },
                    { 28, 1, "This description is for product 28-20241228002754", "Product 28-20241228002754", 1.99m },
                    { 27, 1, "This description is for product 27-20241228002754", "Product 27-20241228002754", 1.99m },
                    { 37, 1, "This description is for product 37-20241228002754", "Product 37-20241228002754", 1.99m },
                    { 100, 1, "This description is for product 100-20241228002754", "Product 100-20241228002754", 1.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Product");
        }
    }
}
