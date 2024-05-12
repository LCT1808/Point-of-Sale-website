using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Point_Of_Sales.Migrations
{
    /// <inheritdoc />
    public partial class Update_ProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Sale_Price",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sale_Price",
                table: "Products");
        }
    }
}
