using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddProductColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductCode");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Image5");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductCode",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Image5",
                table: "Products",
                newName: "Description");
        }
    }
}
