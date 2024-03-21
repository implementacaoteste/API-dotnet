using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Permissoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrupoUsuarioUsuario",
                columns: table => new
                {
                    GrupoUsuarioListId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsuarioListId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoUsuarioUsuario", x => new { x.GrupoUsuarioListId, x.UsuarioListId });
                    table.ForeignKey(
                        name: "FK_GrupoUsuarioUsuario_GrupoUsuario_GrupoUsuarioListId",
                        column: x => x.GrupoUsuarioListId,
                        principalTable: "GrupoUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoUsuarioUsuario_Usuario_UsuarioListId",
                        column: x => x.UsuarioListId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoUsuarioPermissao",
                columns: table => new
                {
                    GrupoUsuarioListId = table.Column<int>(type: "INTEGER", nullable: false),
                    PermissaoListId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoUsuarioPermissao", x => new { x.GrupoUsuarioListId, x.PermissaoListId });
                    table.ForeignKey(
                        name: "FK_GrupoUsuarioPermissao_GrupoUsuario_GrupoUsuarioListId",
                        column: x => x.GrupoUsuarioListId,
                        principalTable: "GrupoUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoUsuarioPermissao_Permissao_PermissaoListId",
                        column: x => x.PermissaoListId,
                        principalTable: "Permissao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupoUsuarioPermissao_PermissaoListId",
                table: "GrupoUsuarioPermissao",
                column: "PermissaoListId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoUsuarioUsuario_UsuarioListId",
                table: "GrupoUsuarioUsuario",
                column: "UsuarioListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupoUsuarioPermissao");

            migrationBuilder.DropTable(
                name: "GrupoUsuarioUsuario");

            migrationBuilder.DropTable(
                name: "Permissao");
        }
    }
}
