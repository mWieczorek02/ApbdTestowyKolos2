using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestowyKolos2.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "FirtName", "LastName" },
                values: new object[] { 1, "Zbychu", "Zbyszkowski" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "FirtName", "LastName" },
                values: new object[] { 1, "Zbychu2", "Zbyszkowski2" });

            migrationBuilder.InsertData(
                table: "Pastries",
                columns: new[] { "ID", "Name", "Price", "Type" },
                values: new object[] { 1, "Ciastko", 12.4m, "Ciasto" });

            migrationBuilder.InsertData(
                table: "Order_Pastry",
                columns: new[] { "OrderId", "PastryId", "Amount", "Comments", "EmployeeID" },
                values: new object[] { 1, 1, 5, "dsdadsds", null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AcceptedAt", "ClientID", "Comments", "EmployeeID", "FulfilledAt" },
                values: new object[] { 1, new DateTime(2023, 6, 13, 22, 5, 1, 674, DateTimeKind.Utc).AddTicks(5965), 1, null, 1, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order_Pastry",
                keyColumns: new[] { "OrderId", "PastryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pastries",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
