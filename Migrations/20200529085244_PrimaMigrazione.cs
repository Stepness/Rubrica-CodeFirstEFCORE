using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayGround_Dependency_Injection.Migrations
{
    public partial class PrimaMigrazione : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contatti",
                columns: table => new
                {
                    ContattoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: true),
                    cognome = table.Column<string>(nullable: true),
                    numeroDiTelefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contatti", x => x.ContattoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contatti");
        }
    }
}
