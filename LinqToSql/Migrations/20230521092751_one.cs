using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LinqToSql.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Statu = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gendres",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Statu = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gendres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    Statu = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    GendreId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Gendres_GendreId",
                        column: x => x.GendreId,
                        principalTable: "Gendres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "DeleteDate", "FirstName", "LastName", "Statu", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Ali", "Yılmaz", 1, null },
                    { 2, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Cevat", "Fırtına", 1, null },
                    { 3, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Ayşe", "Kırmızı", 1, null },
                    { 4, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Ömer", "Seyfettin", 1, null },
                    { 5, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Can", "Yücel", 1, null },
                    { 6, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Mehmet", "Kaş", 1, null },
                    { 7, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Hakan", "Yaşar", 1, null },
                    { 8, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Celal", "Kaya", 1, null },
                    { 9, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "İpek", "Bilgin", 1, null },
                    { 10, new DateTime(2023, 5, 21, 12, 27, 50, 762, DateTimeKind.Local).AddTicks(1150), null, "Ece", "Biricik", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Gendres",
                columns: new[] { "Id", "CreatedDate", "DeleteDate", "Name", "Statu", "UpdateDate" },
                values: new object[,]
                {
                    { "kor", new DateTime(2023, 5, 21, 12, 27, 50, 881, DateTimeKind.Local).AddTicks(277), null, "Korku", 1, null },
                    { "psk", new DateTime(2023, 5, 21, 12, 27, 50, 881, DateTimeKind.Local).AddTicks(277), null, "Psikoloji", 1, null },
                    { "mcr", new DateTime(2023, 5, 21, 12, 27, 50, 881, DateTimeKind.Local).AddTicks(277), null, "Macera", 1, null },
                    { "syh", new DateTime(2023, 5, 21, 12, 27, 50, 881, DateTimeKind.Local).AddTicks(277), null, "Seyehat", 1, null },
                    { "blm", new DateTime(2023, 5, 21, 12, 27, 50, 881, DateTimeKind.Local).AddTicks(277), null, "Bilim", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedDate", "DeleteDate", "GendreId", "Price", "Statu", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "kor", 12.44, 1, "Ali bananın çiftliği", null },
                    { 3, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "kor", 34.450000000000003, 1, "Susma Sanatı", null },
                    { 6, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "kor", 56.677999999999997, 1, "Satranç", null },
                    { 2, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "psk", 888.0, 1, "Uçurtma Avcisi", null },
                    { 4, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "psk", 12.119999999999999, 1, "Siyah Lale", null },
                    { 14, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "psk", 200.0, 1, "Kafaya Takma Sanatı", null },
                    { 7, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "mcr", 88.0, 1, "Suç ve Ceza", null },
                    { 8, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "mcr", 367.0, 1, "Yaprak Dökümü", null },
                    { 13, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "mcr", 44.0, 1, "Beyaz Diş", null },
                    { 10, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "syh", 99.989999999999995, 1, "Sırça Köşk", null },
                    { 12, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "syh", 100.0, 1, "Beyaz Kale", null },
                    { 16, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "syh", 289.0, 1, "Mai", null },
                    { 5, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "blm", 244.0, 1, "Körlük", null },
                    { 9, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "blm", 55.780000000000001, 1, "Uzay", null },
                    { 11, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "blm", 56.219999999999999, 1, "Merhaba Dünya", null },
                    { 15, new DateTime(2023, 5, 21, 12, 27, 50, 833, DateTimeKind.Local).AddTicks(763), null, "blm", 800.0, 1, "Bilge", null }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 1, 9 },
                    { 10, 9 },
                    { 2, 5 },
                    { 3, 16 },
                    { 7, 12 },
                    { 10, 10 },
                    { 4, 13 },
                    { 4, 11 },
                    { 3, 8 },
                    { 2, 7 },
                    { 8, 14 },
                    { 6, 4 },
                    { 3, 2 },
                    { 1, 2 },
                    { 7, 6 },
                    { 5, 3 },
                    { 2, 8 },
                    { 6, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GendreId",
                table: "Books",
                column: "GendreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Gendres");
        }
    }
}
