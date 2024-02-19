using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Family = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Version = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PersonId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TransactionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Family", "Name", "Version" },
                values: new object[,]
                {
                    { new Guid("d745193c-8a95-4828-918c-88390f2e212e"), "Copper", "Mike", new Guid("5e85b02b-7724-4fd5-86ff-7c73af5adeac") },
                    { new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"), "Parker", "Jane", new Guid("d5b2bdd8-5d5b-473f-a81d-cf645512a77c") }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "PersonId", "Price", "TransactionDate", "Version" },
                values: new object[,]
                {
                    { new Guid("41f5bab3-6dcd-425c-bf4d-dbd1485d8a31"), new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"), 100000, new DateTime(2019, 11, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("b680af96-cb47-4df8-9bbe-c3a84395868c") },
                    { new Guid("4e6c1cbd-6b69-47ad-81b5-6ff0e31a8150"), new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"), 300000, new DateTime(2019, 11, 3, 9, 30, 0, 0, DateTimeKind.Unspecified), new Guid("a745adf2-8be5-49a0-8bfe-8a1a2fb0e69b") },
                    { new Guid("65a2d24f-f466-4cc4-b4e7-a5559fcd90a8"), new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"), 50000, new DateTime(2019, 11, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), new Guid("8018ae45-840f-43b2-b626-7a9ce0c72a72") },
                    { new Guid("6f58926d-7332-4446-b644-254d894438ce"), new Guid("e16fe15f-94ab-46c9-aaab-db552327e183"), 200000, new DateTime(2019, 11, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new Guid("3f16fd22-3850-47f8-9d3d-b3cdb9664cc8") },
                    { new Guid("7c2856e1-efe4-4a71-8754-4c1cf0719675"), new Guid("d745193c-8a95-4828-918c-88390f2e212e"), 100000, new DateTime(2019, 11, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("3781ccde-44ae-4e6b-b32b-951561b4ef12") },
                    { new Guid("d4810df7-2d29-466e-a329-6eb045cc05ca"), new Guid("d745193c-8a95-4828-918c-88390f2e212e"), 20000, new DateTime(2019, 11, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("cf266ca7-adb8-44ea-ab5b-aaabd43e1705") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PersonId",
                table: "Transactions",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
