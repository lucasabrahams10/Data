using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandLord.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTenantIdFromOrderRow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Tenants_TenantId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_TenantId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "OrderRows");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "OrderRows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_TenantId",
                table: "OrderRows",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Tenants_TenantId",
                table: "OrderRows",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}