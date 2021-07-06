using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class InitMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "CreatedBy", "CreatedTime", "Description", "Name" },
                values: new object[] { 1, 1, new DateTime(2021, 7, 2, 12, 27, 32, 694, DateTimeKind.Local).AddTicks(5145), "Produce", "Produce" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "CreatedBy", "CreatedTime", "Description", "Name" },
                values: new object[] { 2, 1, new DateTime(2021, 7, 2, 12, 27, 32, 695, DateTimeKind.Local).AddTicks(4114), "Groceries", "Groceries" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CreatedBy", "CreatedTime", "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5959), 1, "Tomatoes", "Tomatoes" },
                    { 4, 1, new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5971), 1, "Lettuce", "Lettuce" },
                    { 6, 1, new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5974), 1, "Chocolate", "Chocolate" },
                    { 2, 1, new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5968), 2, "Ginger", "Ginger" },
                    { 3, 1, new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5970), 2, "Brocolli", "Brocolli" },
                    { 5, 1, new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5973), 2, "Baking Powder", "Baking Powder" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CreatedBy", "CreatedTime", "Description", "ProductId" },
                values: new object[] { 1, 1, new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(7259), "Test", 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CreatedBy", "CreatedTime", "Description", "ProductId" },
                values: new object[] { 2, 1, new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(7265), "My Order", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DepartmentId",
                table: "Products",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
