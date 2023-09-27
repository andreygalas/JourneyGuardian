using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_CRUD_APP.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingsuperstop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SuperStop",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuperStop",
                table: "Trip");
        }
    }
}
