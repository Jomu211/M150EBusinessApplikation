using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M150EBusinessApplikation.Data.Migrations
{
    /// <inheritdoc />
    public partial class Shop_Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //remove Bought property from Champion Table
            migrationBuilder.DropColumn(
                name: "Bought",
                table: "Champions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
