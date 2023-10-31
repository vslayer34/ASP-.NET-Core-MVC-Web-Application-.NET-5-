using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicTreeMVCWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumArtPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AlbumArtPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAlbum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAlbum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAlbum_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAlbum_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlbumTrack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    MediaTypId = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumTrack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlbumTrack_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumTrack_MediaType_MediaTypId",
                        column: x => x.MediaTypId,
                        principalTable: "MediaType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HTMLContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpotifyLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumTrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Content_AlbumTrack_AlbumTrackId",
                        column: x => x.AlbumTrackId,
                        principalTable: "AlbumTrack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumTrack_AlbumId",
                table: "AlbumTrack",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumTrack_MediaTypId",
                table: "AlbumTrack",
                column: "MediaTypId");

            migrationBuilder.CreateIndex(
                name: "IX_Content_AlbumTrackId",
                table: "Content",
                column: "AlbumTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAlbum_AlbumId",
                table: "UserAlbum",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAlbum_UserId",
                table: "UserAlbum",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropTable(
                name: "UserAlbum");

            migrationBuilder.DropTable(
                name: "AlbumTrack");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "MediaType");
        }
    }
}
