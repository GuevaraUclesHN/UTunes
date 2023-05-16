using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTunes.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class FixedMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Artist", "Name", "PriceAlbum", "Rating", "Review", "TotalVotes" },
                values: new object[] { 2, "Anuel AA", "LLNM2", 0, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean sed leo elit. Nullam tellus ipsum, fringilla quis ex vitae, mattis rutrum felis. Duis venenatis faucibus turpis, at tincidunt arcu bibendum ac. Vestibulum eget placerat libero, nec tempus ipsum. Sed elit libero, luctus non dapibus et, sagittis a tellus. Ut suscipit porta vestibulum. Mauris justo velit, pretium at efficitur nec, posuere non massa. Proin quis aliquet quam. Maecenas malesuada mauris ex, eu sollicitudin quam laoreet ut. Sed mollis enim dolor, eu malesuada dui aliquet ut. Quisque rhoncus augue urna, at volutpat justo ultrices et. Vivamus maximus quam non nisl placerat varius. Nam mollis erat ullamcorper diam efficitur, molestie feugiat urna finibus. Phasellus dignissim interdum neque sed dictum.", 0 });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "AlbumId", "Artist", "Name", "PriceSong" },
                values: new object[,]
                {
                    { 5, 2, "Anuel AA", "40", 0 },
                    { 6, 2, "Anuel AA", "La 2blea", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
