using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshoes.Migrations
{
    /// <inheritdoc />
    public partial class migResolveFullnameInProducers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FulleName",
                table: "Producers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FulleName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
