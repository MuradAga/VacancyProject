using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacancyProject.Migrations
{
    /// <inheritdoc />
    public partial class adfafd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Vacancies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Vacancies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_SubCategoryId",
                table: "Vacancies",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_SubCategories_SubCategoryId",
                table: "Vacancies",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_SubCategories_SubCategoryId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_SubCategoryId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Vacancies");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Vacancies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
