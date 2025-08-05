using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeiraDaRoca.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoFeiranteProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeiranteId",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FeiranteId",
                table: "Produtos",
                column: "FeiranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Feirantes_FeiranteId",
                table: "Produtos",
                column: "FeiranteId",
                principalTable: "Feirantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Feirantes_FeiranteId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FeiranteId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FeiranteId",
                table: "Produtos");
        }
    }
}
