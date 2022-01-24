using Microsoft.EntityFrameworkCore.Migrations;

namespace NETLagring.Blazor.Migrations
{
    public partial class AddCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersServices_Customers_CustomerId",
                table: "CustomersServices");

            migrationBuilder.DropIndex(
                name: "IX_CustomersServices_CustomerId",
                table: "CustomersServices");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomersServices");

            migrationBuilder.AddColumn<int>(
                name: "CustomersServiceId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomersServiceId",
                table: "Customers",
                column: "CustomersServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomersServices_CustomersServiceId",
                table: "Customers",
                column: "CustomersServiceId",
                principalTable: "CustomersServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomersServices_CustomersServiceId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomersServiceId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomersServiceId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomersServices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersServices_CustomerId",
                table: "CustomersServices",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersServices_Customers_CustomerId",
                table: "CustomersServices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
