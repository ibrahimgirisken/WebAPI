using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Categories_CategoryId",
                schema: "dbo",
                table: "CategoryTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                schema: "dbo",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "dbo",
                newName: "Category",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "Image1",
                schema: "dbo",
                table: "Category",
                newName: "image1");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                schema: "dbo",
                table: "Category",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Category",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "image1",
                schema: "dbo",
                table: "Category",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                schema: "dbo",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "category_translation_id_fk",
                schema: "dbo",
                table: "CategoryTranslations",
                column: "CategoryId",
                principalSchema: "dbo",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "category_translation_id_fk",
                schema: "dbo",
                table: "CategoryTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                schema: "dbo",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "dbo",
                newName: "Categories",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "image1",
                schema: "dbo",
                table: "Categories",
                newName: "Image1");

            migrationBuilder.AlterColumn<string>(
                name: "Image1",
                schema: "dbo",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                schema: "dbo",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                schema: "dbo",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Categories_CategoryId",
                schema: "dbo",
                table: "CategoryTranslations",
                column: "CategoryId",
                principalSchema: "dbo",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
