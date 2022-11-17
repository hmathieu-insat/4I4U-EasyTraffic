using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4I4ULiteTrak.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InfoTraffic = table.Column<int>(type: "INTEGER", nullable: false),
                    TempsAjout = table.Column<int>(type: "INTEGER", nullable: false),
                    DoitClignoter = table.Column<bool>(type: "INTEGER", nullable: false),
                    FeuId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feus_Feus_FeuId",
                        column: x => x.FeuId,
                        principalTable: "Feus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feus_FeuId",
                table: "Feus",
                column: "FeuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feus");
        }
    }
}
