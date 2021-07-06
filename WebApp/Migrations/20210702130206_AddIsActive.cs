using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class AddIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsActive",
                table: "Products",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IsActive",
                table: "Departments",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreatedTime", "IsActive" },
                values: new object[] { new DateTime(2021, 7, 2, 19, 2, 6, 533, DateTimeKind.Local).AddTicks(2444), "Y" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreatedTime", "IsActive" },
                values: new object[] { new DateTime(2021, 7, 2, 19, 2, 6, 533, DateTimeKind.Local).AddTicks(9651), "Y" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 19, 2, 6, 535, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2021, 7, 2, 19, 2, 6, 535, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedTime", "IsActive" },
                values: new object[] { new DateTime(2021, 7, 2, 19, 2, 6, 535, DateTimeKind.Local).AddTicks(291), "Y" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedTime", "IsActive" },
                values: new object[] { new DateTime(2021, 7, 2, 19, 2, 6, 535, DateTimeKind.Local).AddTicks(299), "Y" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedTime", "IsActive" },
                values: new object[] { new DateTime(2021, 7, 2, 19, 2, 6, 535, DateTimeKind.Local).AddTicks(301), "Y" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedTime", "IsActive" },
                values: new object[] { new DateTime(2021, 7, 2, 19, 2, 6, 535, DateTimeKind.Local).AddTicks(303), "Y" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedTime", "IsActive" },
                values: new object[] { new DateTime(2021, 7, 2, 19, 2, 6, 535, DateTimeKind.Local).AddTicks(304), "Y" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedTime", "IsActive" },
                values: new object[] { new DateTime(2021, 7, 2, 19, 2, 6, 535, DateTimeKind.Local).AddTicks(306), "Y" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Departments");

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
    }
}
