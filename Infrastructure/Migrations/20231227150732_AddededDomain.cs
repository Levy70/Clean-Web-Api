using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddededDomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Dogs",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Cats",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Cats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Birds",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<byte[]>(type: "longblob", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ecf60ce-c9d3-4505-8df4-1416a874daab"), false, "Feri", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2e37c193-0be7-46cc-913e-dd80d004c469"), false, "Cortex", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cdb1d7e6-d869-4dcf-835b-5042886d860b"), false, "Parrot", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fe5303f8-d3ff-44c9-935b-eecdae483a88"), false, "Fench", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("116ef989-e16a-460e-bb63-0528bfabbe8b"), false, "Puppy", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("479277f3-429f-40a5-a77b-ae01aa322e9c"), false, "Tom", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("5eb58d12-144e-4d1c-a20d-b3dca8e5524f"), false, "Sedel", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("69f28847-84bf-427c-8199-1e63f07a250f"), false, "Nuno", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("8ac9cd5c-2454-4834-a0e0-081184a1935e"), false, "Mani", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("9e1b657e-72c7-4d55-bbe0-d5974ffef53f"), false, "Misha", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("9f832ab5-1c88-4804-8183-c332a5331ae1"), false, "Tezar", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("eceeee5f-7054-4d2b-b077-8f6666b691f2"), false, "Shima", new Guid("00000000-0000-0000-0000-000000000000"), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("1ecf60ce-c9d3-4505-8df4-1416a874daab"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("2e37c193-0be7-46cc-913e-dd80d004c469"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("cdb1d7e6-d869-4dcf-835b-5042886d860b"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("fe5303f8-d3ff-44c9-935b-eecdae483a88"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("116ef989-e16a-460e-bb63-0528bfabbe8b"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("479277f3-429f-40a5-a77b-ae01aa322e9c"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("5eb58d12-144e-4d1c-a20d-b3dca8e5524f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("69f28847-84bf-427c-8199-1e63f07a250f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("8ac9cd5c-2454-4834-a0e0-081184a1935e"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("9e1b657e-72c7-4d55-bbe0-d5974ffef53f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("9f832ab5-1c88-4804-8183-c332a5331ae1"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("eceeee5f-7054-4d2b-b077-8f6666b691f2"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Birds");
        }
    }
}
