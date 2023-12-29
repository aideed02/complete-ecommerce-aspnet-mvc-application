using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshoes.Migrations
{
    /// <inheritdoc />
    public partial class migResolveFullname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FulleName",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Producers");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "FulleName");
        }
    }
}
