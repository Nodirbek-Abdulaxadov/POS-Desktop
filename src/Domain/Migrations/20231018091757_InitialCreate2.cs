using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.Domain.Migrations;

/// <inheritdoc />
public partial class InitialCreate2 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "MeasurmentType",
            table: "Products",
            type: "int",
            nullable: false,
            defaultValue: 0);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "MeasurmentType",
            table: "Products");
    }
}
