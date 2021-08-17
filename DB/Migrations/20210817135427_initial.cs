using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "korisnici",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ime_prezime = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    img = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnici", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "korisnici");
        }
    }
}
