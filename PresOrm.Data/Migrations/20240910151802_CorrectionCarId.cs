using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresOrm.Data.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionCarId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AssetId",
                table: "Car",
                newName: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Car",
                newName: "AssetId");
        }
    }
}
