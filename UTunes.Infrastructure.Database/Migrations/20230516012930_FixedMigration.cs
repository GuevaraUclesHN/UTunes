using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTunes.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class FixedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceSong",
                table: "Song",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceAlbum",
                table: "Album",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Album",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalVotes",
                table: "Album",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PriceAlbum", "Rating", "TotalVotes" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                column: "PriceSong",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                column: "PriceSong",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                column: "PriceSong",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                column: "PriceSong",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceSong",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "PriceAlbum",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "TotalVotes",
                table: "Album");
        }
    }
}
