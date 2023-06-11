using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandLord.Migrations
{
    /// <inheritdoc />
    public partial class AddningTablesAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_PersonEntity_PersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PersonEntity_PersonId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_PersonEntity_PersonId",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonEntity",
                table: "PersonEntity");

            migrationBuilder.RenameTable(
                name: "PersonEntity",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_PersonEntity_Email",
                table: "Persons",
                newName: "IX_Persons_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "StatusCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OrderRowId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusCodes_OrderRows_OrderRowId",
                        column: x => x.OrderRowId,
                        principalTable: "OrderRows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatusCodes_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatusCodes_OrderRowId",
                table: "StatusCodes",
                column: "OrderRowId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusCodes_PersonId",
                table: "StatusCodes",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Persons_PersonId",
                table: "Comments",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Persons_PersonId",
                table: "Employees",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Persons_PersonId",
                table: "Tenants",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Persons_PersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Persons_PersonId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Persons_PersonId",
                table: "Tenants");

            migrationBuilder.DropTable(
                name: "StatusCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "PersonEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_Email",
                table: "PersonEntity",
                newName: "IX_PersonEntity_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonEntity",
                table: "PersonEntity",
                column: "Id");

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
                name: "FK_Tenants_PersonEntity_PersonId",
                table: "Tenants",
                column: "PersonId",
                principalTable: "PersonEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}