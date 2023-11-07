using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstrellasCalificacíon = table.Column<int>(type: "int", nullable: true),
                    ComentarioCalificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpresaProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacion", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificacion");
        }
    }
}
