using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandLord.Migrations
{
    /// <inheritdoc />
    public partial class Addning_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Orders_OrderId",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_OrdersId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tenants_OrderId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_Email",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrdersId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_OrderId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Tenants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeId",
                table: "OrderRows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdersId1",
                table: "OrderRows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdersIdId",
                table: "OrderRows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "OrderRows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "OrderRows",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Apartments",
                type: "char(6)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PersonEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "char(13)", nullable: false),
                    Email = table.Column<string>(type: "varchar(70)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEntity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_PersonId",
                table: "Tenants",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeId",
                table: "Orders",
                column: "EmployeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TenantId",
                table: "Orders",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrdersId1",
                table: "OrderRows",
                column: "OrdersId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrdersIdId",
                table: "OrderRows",
                column: "OrdersIdId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_TenantId",
                table: "OrderRows",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonId",
                table: "Employees",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PersonId",
                table: "Comments",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonEntity_Email",
                table: "PersonEntity",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_PersonEntity_PersonId",
                table: "Comments",
                column: "PersonId",
                principalTable: "PersonEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PersonEntity_PersonId",
                table: "Employees",
                column: "PersonId",
                principalTable: "PersonEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Employees_OrdersId1",
                table: "OrderRows",
                column: "OrdersId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Orders_OrdersIdId",
                table: "OrderRows",
                column: "OrdersIdId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Tenants_TenantId",
                table: "OrderRows",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_EmployeId",
                table: "Orders",
                column: "EmployeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tenants_TenantId",
                table: "Orders",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_PersonEntity_PersonId",
                table: "Tenants",
                column: "PersonId",
                principalTable: "PersonEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_PersonEntity_PersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PersonEntity_PersonId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Employees_OrdersId1",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Orders_OrdersIdId",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Tenants_TenantId",
                table: "OrderRows");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_EmployeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tenants_TenantId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_PersonEntity_PersonId",
                table: "Tenants");

            migrationBuilder.DropTable(
                name: "PersonEntity");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_PersonId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Orders_EmployeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TenantId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_OrdersId1",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_OrdersIdId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_TenantId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PersonId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PersonId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "EmployeId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "OrdersId1",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "OrdersIdId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "OrderRows");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Apartments");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Tenants",
                type: "varchar(70)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Tenants",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Tenants",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Tenants",
                type: "char(13)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "char(13)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_Email",
                table: "Tenants",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderId",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrdersId",
                table: "Orders",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrderId",
                table: "OrderRows",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Orders_OrderId",
                table: "OrderRows",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_OrdersId",
                table: "Orders",
                column: "OrdersId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tenants_OrderId",
                table: "Orders",
                column: "OrderId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}