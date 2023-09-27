using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_CRUD_APP.Data.Migrations
{
    /// <inheritdoc />
    public partial class addpallets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pallets",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pallets",
                table: "Trip");
        }
    }
}
