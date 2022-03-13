using Microsoft.EntityFrameworkCore.Migrations;

namespace МоитеГуми.Migrations
{
    public partial class UpdateTires : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dealer_AspNetUsers_UserId",
                table: "Dealer");

            migrationBuilder.DropForeignKey(
                name: "FK_Обяви_Dealer_DealerId",
                table: "Обяви");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dealer",
                table: "Dealer");

            migrationBuilder.RenameTable(
                name: "Dealer",
                newName: "Dealers");

            migrationBuilder.RenameIndex(
                name: "IX_Dealer_UserId",
                table: "Dealers",
                newName: "IX_Dealers_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dealers",
                table: "Dealers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Confidentialitis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    confidentiality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confidentialitis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    connectionString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Dealers_AspNetUsers_UserId",
                table: "Dealers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Обяви_Dealers_DealerId",
                table: "Обяви",
                column: "DealerId",
                principalTable: "Dealers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dealers_AspNetUsers_UserId",
                table: "Dealers");

            migrationBuilder.DropForeignKey(
                name: "FK_Обяви_Dealers_DealerId",
                table: "Обяви");

            migrationBuilder.DropTable(
                name: "Confidentialitis");

            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dealers",
                table: "Dealers");

            migrationBuilder.RenameTable(
                name: "Dealers",
                newName: "Dealer");

            migrationBuilder.RenameIndex(
                name: "IX_Dealers_UserId",
                table: "Dealer",
                newName: "IX_Dealer_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dealer",
                table: "Dealer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dealer_AspNetUsers_UserId",
                table: "Dealer",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Обяви_Dealer_DealerId",
                table: "Обяви",
                column: "DealerId",
                principalTable: "Dealer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
