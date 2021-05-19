using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSeed.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Cpf", "Email", "Nome" },
                values: new object[,]
                {
                    { 1, "962.587.170-55", "MaiteMelo_Xavier@bol.com.br", "Maitê Melo" },
                    { 2, "070.664.115-95", "JoaoCarvalho.Souza99@gmail.com", "João Carvalho" },
                    { 3, "883.395.307-63", "YasminXavier14@hotmail.com", "Yasmin Xavier" },
                    { 4, "708.212.258-63", "CarlaFranco98@hotmail.com", "Carla Franco" },
                    { 5, "345.448.357-39", "NorbertoPereira14@gmail.com", "Norberto Pereira" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
