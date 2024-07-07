using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_CRUD_APP.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BackHaul",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ChainUp",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CrossDock",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DelayPay",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Doubles",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HourlyPay",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PerDiem",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PostTrip",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PreTrip",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ShuttleStop",
                table: "Trip",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackHaul",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "ChainUp",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "CrossDock",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "DelayPay",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "Doubles",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "HourlyPay",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "PerDiem",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "PostTrip",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "PreTrip",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "ShuttleStop",
                table: "Trip");
        }
    }
}
