using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class RemoveDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 591, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 592, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 593, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 593, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 593, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 593, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 593, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 593, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 593, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 18, 51, 35, 593, DateTimeKind.Local).AddTicks(6800));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Orders",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 12, 27, 32, 694, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 12, 27, 32, 695, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Description" },
                values: new object[] { new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(7259), "Test" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Description" },
                values: new object[] { new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(7265), "My Order" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 12, 27, 32, 696, DateTimeKind.Local).AddTicks(5974));
        }
    }
}
