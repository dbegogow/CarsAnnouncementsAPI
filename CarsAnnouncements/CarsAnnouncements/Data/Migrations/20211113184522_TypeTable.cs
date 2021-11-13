using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsAnnouncements.Data.Migrations
{
    public partial class TypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TypeId",
                table: "Cars",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Type_TypeId",
                table: "Cars",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Type_TypeId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Cars_TypeId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Cars");
        }
    }
}
