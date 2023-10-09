using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_CRUD_APP.Data.Migrations
{
    /// <inheritdoc />
    public partial class dotaudit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DotAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tractor = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DriversLicense = table.Column<bool>(type: "bit", nullable: false),
                    DotCard = table.Column<bool>(type: "bit", nullable: false),
                    ExtraLogBook = table.Column<bool>(type: "bit", nullable: false),
                    PitCard = table.Column<bool>(type: "bit", nullable: false),
                    Tablet = table.Column<bool>(type: "bit", nullable: false),
                    DvirBook = table.Column<bool>(type: "bit", nullable: false),
                    Registration = table.Column<bool>(type: "bit", nullable: false),
                    InsuranceCard = table.Column<bool>(type: "bit", nullable: false),
                    Ifta = table.Column<bool>(type: "bit", nullable: false),
                    LogBook = table.Column<bool>(type: "bit", nullable: false),
                    EldGuide = table.Column<bool>(type: "bit", nullable: false),
                    PermitBook = table.Column<bool>(type: "bit", nullable: false),
                    PostAccidentKit = table.Column<bool>(type: "bit", nullable: false),
                    BlankAccidentReport = table.Column<bool>(type: "bit", nullable: false),
                    OregonFuelPermit = table.Column<bool>(type: "bit", nullable: false),
                    DriverSignature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotAudit", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DotAudit");
        }
    }
}
