using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_CRUD_APP.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingbool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTeamRoute",
                table: "Trip",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTeamRoute",
                table: "Trip");
        }
    }
}
