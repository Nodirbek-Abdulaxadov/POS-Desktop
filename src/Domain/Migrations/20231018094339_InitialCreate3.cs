using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.Domain.Migrations;

/// <inheritdoc />
public partial class InitialCreate3 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Products_Categories_CategoryId",
            table: "Products");

        migrationBuilder.CreateTable(
            name: "ProductItem",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                BuyingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                ProductId = table.Column<int>(type: "int", nullable: false),
                IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ProductItem", x => x.Id);
                table.ForeignKey(
                    name: "FK_ProductItem_Products_ProductId",
                    column: x => x.ProductId,
                    principalTable: "Products",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateIndex(
            name: "IX_ProductItem_ProductId",
            table: "ProductItem",
            column: "ProductId");

        migrationBuilder.AddForeignKey(
            name: "FK_Products_Categories_CategoryId",
            table: "Products",
            column: "CategoryId",
            principalTable: "Categories",
            principalColumn: "Id");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Products_Categories_CategoryId",
            table: "Products");

        migrationBuilder.DropTable(
            name: "ProductItem");

        migrationBuilder.AddForeignKey(
            name: "FK_Products_Categories_CategoryId",
            table: "Products",
            column: "CategoryId",
            principalTable: "Categories",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }
}
