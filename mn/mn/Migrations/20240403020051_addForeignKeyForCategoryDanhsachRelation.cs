using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mn.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyForCategoryDanhsachRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DanhsachId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DanhsachId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DanhsachId",
                table: "Categories",
                column: "DanhsachId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Danhsaches_DanhsachId",
                table: "Categories",
                column: "DanhsachId",
                principalTable: "Danhsaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Danhsaches_DanhsachId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DanhsachId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DanhsachId",
                table: "Categories");
        }
    }
}
