using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAspnetCore.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categorys_categoriesid",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "categoriesid",
                table: "Products",
                newName: "categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoriesid",
                table: "Products",
                newName: "IX_Products_categoryid");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Products",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Products",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "Products",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "Products",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Categorys",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categorys_categoryid",
                table: "Products",
                column: "categoryid",
                principalTable: "Categorys",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categorys_categoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Categorys");

            migrationBuilder.RenameColumn(
                name: "categoryid",
                table: "Products",
                newName: "categoriesid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryid",
                table: "Products",
                newName: "IX_Products_categoriesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categorys_categoriesid",
                table: "Products",
                column: "categoriesid",
                principalTable: "Categorys",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
