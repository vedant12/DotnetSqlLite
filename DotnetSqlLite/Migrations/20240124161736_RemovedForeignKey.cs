using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetSqlLite.Migrations
{
    public partial class RemovedForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_CategoryID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "UnitScale",
                table: "Product",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Product",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<long>(
                name: "InStock",
                table: "Product",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "DiscontinuedPrice",
                table: "Product",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<long>(
                name: "ProductCategoryCategoryID",
                table: "Product",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryCategoryID",
                table: "Product",
                column: "ProductCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryCategoryID",
                table: "Product",
                column: "ProductCategoryCategoryID",
                principalTable: "ProductCategory",
                principalColumn: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryCategoryID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductCategoryCategoryID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductCategoryCategoryID",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "UnitScale",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Product",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "InStock",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DiscontinuedPrice",
                table: "Product",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CategoryID",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_CategoryID",
                table: "Product",
                column: "CategoryID",
                principalTable: "ProductCategory",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
