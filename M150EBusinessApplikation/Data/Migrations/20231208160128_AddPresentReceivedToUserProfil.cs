using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M150EBusinessApplikation.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPresentReceivedToUserProfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PresentReceived",
                table: "UserProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PresentReceived",
                table: "UserProfiles");
        }
    }
}
