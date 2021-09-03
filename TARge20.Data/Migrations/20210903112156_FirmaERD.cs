using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class FirmaERD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ametinimetused",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nimetus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetused", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haiguslehed",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TöötajaID = table.Column<Guid>(nullable: false),
                    Põhjus = table.Column<string>(nullable: true),
                    Alguskuupäev = table.Column<DateTime>(nullable: false),
                    Lõppkuupäev = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haiguslehed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laenutamised",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TöötajaID = table.Column<Guid>(nullable: false),
                    Asi = table.Column<string>(nullable: true),
                    Leanutuse_alguskuupäev = table.Column<DateTime>(nullable: false),
                    Leanutuse_lõppkuupäev = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutamised", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lapsed",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EesNimi = table.Column<string>(nullable: true),
                    Sünnipäev = table.Column<DateTime>(nullable: false),
                    Vanus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lapsed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Puhkused",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TöötajaID = table.Column<Guid>(nullable: false),
                    Alguskuupäev = table.Column<DateTime>(nullable: false),
                    Lõppkuupäev = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkused", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Töötajad",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EesNimi = table.Column<string>(nullable: true),
                    PerekonnaNimi = table.Column<string>(nullable: true),
                    Ametinimetus_ID = table.Column<Guid>(nullable: false),
                    Puhkus_Id = table.Column<Guid>(nullable: false),
                    Lapsed_ID = table.Column<Guid>(nullable: false),
                    Haigusleht_ID = table.Column<Guid>(nullable: false),
                    Laenutused_ID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötajad", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ametinimetused");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Haiguslehed");

            migrationBuilder.DropTable(
                name: "Laenutamised");

            migrationBuilder.DropTable(
                name: "Lapsed");

            migrationBuilder.DropTable(
                name: "Puhkused");

            migrationBuilder.DropTable(
                name: "Töötajad");
        }
    }
}
