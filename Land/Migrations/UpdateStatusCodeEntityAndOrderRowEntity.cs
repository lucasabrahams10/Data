using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandLord.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStatusCodeEntityAndOrderRowEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Employees_OrdersId1",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusCodes_OrderRows_OrderRowId",
                table: "StatusCodes");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusCodes_Persons_PersonId",
                table: "StatusCodes");

            migrationBuilder.DropIndex(
                name: "IX_StatusCodes_OrderRowId",
                table: "StatusCodes");

            migrationBuilder.DropIndex(
                name: "IX_StatusCodes_PersonId",
                table: "StatusCodes");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_OrdersId1",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "OrderRowId",
                table: "StatusCodes");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "StatusCodes");

            migrationBuilder.RenameColumn(
                name: "OrdersId1",
                table: "OrderRows",
                newName: "StatusId");

            migrationBuilder.AddColumn<int>(
                name: "StatusCodeId",
                table: "OrderRows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_EmployeId",
                table: "OrderRows",
                column: "EmployeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_StatusCodeId",
                table: "OrderRows",
                column: "StatusCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Employees_EmployeId",
                table: "OrderRows",
                column: "EmployeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_StatusCodes_StatusCodeId",
                table: "OrderRows",
                column: "StatusCodeId",
                principalTable: "StatusCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Employees_EmployeId",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_StatusCodes_StatusCodeId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_EmployeId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_StatusCodeId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "StatusCodeId",
                table: "OrderRows");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "OrderRows",
                newName: "OrdersId1");

            migrationBuilder.AddColumn<int>(
                name: "OrderRowId",
                table: "StatusCodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "StatusCodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StatusCodes_OrderRowId",
                table: "StatusCodes",
                column: "OrderRowId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusCodes_PersonId",
                table: "StatusCodes",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrdersId1",
                table: "OrderRows",
                column: "OrdersId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Employees_OrdersId1",
                table: "OrderRows",
                column: "OrdersId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusCodes_OrderRows_OrderRowId",
                table: "StatusCodes",
                column: "OrderRowId",
                principalTable: "OrderRows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusCodes_Persons_PersonId",
                table: "StatusCodes",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}