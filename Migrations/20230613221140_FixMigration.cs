using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestowyKolos2.Migrations
{
    /// <inheritdoc />
    public partial class FixMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pastry_Orders_EmployeeID",
                table: "Order_Pastry");

            migrationBuilder.DropIndex(
                name: "IX_Order_Pastry_EmployeeID",
                table: "Order_Pastry");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Order_Pastry");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "AcceptedAt",
                value: new DateTime(2023, 6, 13, 22, 11, 39, 787, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pastry_Orders_OrderID",
                table: "Order_Pastry",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pastry_Orders_OrderID",
                table: "Order_Pastry");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Order_Pastry",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Order_Pastry",
                keyColumns: new[] { "OrderID", "PastryID" },
                keyValues: new object[] { 1, 1 },
                column: "EmployeeID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "AcceptedAt",
                value: new DateTime(2023, 6, 13, 22, 9, 9, 103, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.CreateIndex(
                name: "IX_Order_Pastry_EmployeeID",
                table: "Order_Pastry",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pastry_Orders_EmployeeID",
                table: "Order_Pastry",
                column: "EmployeeID",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
