using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductoAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migracioninicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductoSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoSet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductoSet",
                columns: new[] { "Id", "Categoria", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Electronica", "Una laptop de alto rendimiento", "Laptop" },
                    { 2, "Electronica", "Un smartphone de nueva generacion", "Smartphone" },
                    { 3, "Muebles", "Una silla de escritorio comoda", "Silla de Escritorio" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoSet");
        }
    }
}
