using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestowyKolos2.Migrations
{
    /// <inheritdoc />
    public partial class ChangePropNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pastry_Pastries_PastryId",
                table: "Order_Pastry");

            migrationBuilder.RenameColumn(
                name: "PastryId",
                table: "Order_Pastry",
                newName: "PastryID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Order_Pastry",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Pastry_PastryId",
                table: "Order_Pastry",
                newName: "IX_Order_Pastry_PastryID");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "AcceptedAt",
                value: new DateTime(2023, 6, 13, 22, 9, 9, 103, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pastry_Pastries_PastryID",
                table: "Order_Pastry",
                column: "PastryID",
                principalTable: "Pastries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pastry_Pastries_PastryID",
                table: "Order_Pastry");

            migrationBuilder.RenameColumn(
                name: "PastryID",
                table: "Order_Pastry",
                newName: "PastryId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Order_Pastry",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Pastry_PastryID",
                table: "Order_Pastry",
                newName: "IX_Order_Pastry_PastryId");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "AcceptedAt",
                value: new DateTime(2023, 6, 13, 22, 5, 1, 674, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pastry_Pastries_PastryId",
                table: "Order_Pastry",
                column: "PastryId",
                principalTable: "Pastries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
