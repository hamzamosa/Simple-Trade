using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySimpleProject.EntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateJoined = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbAcounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountHolderId = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbAcounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbAcounts_TbUsers_accountHolderId",
                        column: x => x.accountHolderId,
                        principalTable: "TbUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbAssestTransAction",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountId = table.Column<int>(type: "int", nullable: false),
                    isPurchase = table.Column<bool>(type: "bit", nullable: false),
                    Stock_symbole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock_priePerShare = table.Column<double>(type: "float", nullable: false),
                    shares = table.Column<int>(type: "int", nullable: false),
                    dateProcess = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbAssestTransAction", x => x.id);
                    table.ForeignKey(
                        name: "FK_TbAssestTransAction_TbAcounts_accountId",
                        column: x => x.accountId,
                        principalTable: "TbAcounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbAcounts_accountHolderId",
                table: "TbAcounts",
                column: "accountHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_TbAssestTransAction_accountId",
                table: "TbAssestTransAction",
                column: "accountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbAssestTransAction");

            migrationBuilder.DropTable(
                name: "TbAcounts");

            migrationBuilder.DropTable(
                name: "TbUsers");
        }
    }
}
