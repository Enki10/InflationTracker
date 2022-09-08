using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InflationTracker.Data.Migrations
{
    public partial class MakeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "IssueDate",
                table: "Grocery",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "groceryName",
                table: "Grocery",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Grocery",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IssueDate",
                table: "Grocery");

            migrationBuilder.DropColumn(
                name: "groceryName",
                table: "Grocery");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Grocery");
        }
    }
}
