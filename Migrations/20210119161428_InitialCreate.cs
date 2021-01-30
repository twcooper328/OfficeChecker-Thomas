using Microsoft.EntityFrameworkCore.Migrations;

namespace OfficeChecker.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OfficeName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    MarketUnit = table.Column<int>(type: "INTEGER", nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Zip = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    OfficeStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    OfficeServices = table.Column<int>(type: "INTEGER", nullable: false),
                    Visitors = table.Column<bool>(type: "INTEGER", nullable: false),
                    LocationType = table.Column<int>(type: "INTEGER", nullable: false),
                    TechSupport = table.Column<int>(type: "INTEGER", nullable: false),
                    ReservableSpace = table.Column<bool>(type: "INTEGER", nullable: false),
                    DressCode = table.Column<string>(type: "TEXT", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "TEXT", nullable: true),
                    FaceCoverings = table.Column<int>(type: "INTEGER", nullable: false),
                    TemperatureChecking = table.Column<int>(type: "INTEGER", nullable: false),
                    PhysicalDistancing = table.Column<bool>(type: "INTEGER", nullable: false),
                    TemperatureChecks = table.Column<bool>(type: "INTEGER", nullable: false),
                    OtherProtocols = table.Column<bool>(type: "INTEGER", nullable: false),
                    SpecialDetails = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Office");
        }
    }
}
