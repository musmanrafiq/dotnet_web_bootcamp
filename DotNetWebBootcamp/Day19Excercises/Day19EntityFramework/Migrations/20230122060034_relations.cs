using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day19EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PayDetailId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PayDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pay = table.Column<int>(type: "int", nullable: false),
                    Eid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayDetail_Employees_Eid",
                        column: x => x.Eid,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayDetail_Eid",
                table: "PayDetail",
                column: "Eid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayDetail");

            migrationBuilder.DropColumn(
                name: "PayDetailId",
                table: "Employees");
        }
    }
}
