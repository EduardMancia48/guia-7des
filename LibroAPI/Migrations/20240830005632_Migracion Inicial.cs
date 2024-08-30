using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibroAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibroSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnioPublicacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroSet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LibroSet",
                columns: new[] { "Id", "AnioPublicacion", "Autor", "Titulo" },
                values: new object[,]
                {
                    { 1, 2008, "Robert C. Martin", "Clean Code" },
                    { 2, 1999, "Andrew Hunt, David Thomas", "The Pragmatic Programmer" },
                    { 3, 1994, "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", "Design Patterns: Elements of Reusable Object-Oriented Software" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibroSet");
        }
    }
}
