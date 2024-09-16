using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FociWeb0916.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_584 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meccs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fordulo = table.Column<int>(type: "INTEGER", nullable: false),
                    Hazaiveg = table.Column<int>(type: "INTEGER", nullable: false),
                    Vendegveg = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiFel = table.Column<int>(type: "INTEGER", nullable: false),
                    VendegFel = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiCsapat = table.Column<string>(type: "TEXT", nullable: true),
                    VendegCsapat = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meccs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meccs");
        }
    }
}
