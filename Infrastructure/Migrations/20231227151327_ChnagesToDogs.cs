using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChnagesToDogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("207f4c9a-ef02-46c5-a058-6d26bb4d13b5"), false, "Fench", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("29b86f54-42b4-47c6-aeaa-8de784fdfdcb"), false, "Cortex", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7935d9f0-eb29-4557-a608-cc5bc032c2eb"), false, "Feri", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b8165403-9d59-44ae-81ab-249b9f4eb832"), false, "Parrot", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("6c5d68e9-a87c-4539-a125-f1835015b3f5"), false, "Mani", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("77776dc3-bf00-4f35-9310-d098a200b9c7"), false, "Nuno", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("8b7ecdcc-5bcb-4174-9d75-367dde75037d"), false, "Puppy", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("97bf165f-4675-43d1-b6d7-b1033c0d2784"), false, "Shima", new Guid("00000000-0000-0000-0000-000000000000"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("2df3b91c-5392-4c23-a0b6-5c079f8dc26c"), "Tom", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("8426c09a-321d-4098-b695-a495fa22ddee"), "Sedel", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("a74d95b8-22e4-4779-a1ee-962b8f702f0c"), "Misha", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("cafe5b9f-1c49-4e12-af1e-29ccd312b506"), "Tezar", new Guid("00000000-0000-0000-0000-000000000000"), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("207f4c9a-ef02-46c5-a058-6d26bb4d13b5"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("29b86f54-42b4-47c6-aeaa-8de784fdfdcb"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("7935d9f0-eb29-4557-a608-cc5bc032c2eb"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("b8165403-9d59-44ae-81ab-249b9f4eb832"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("6c5d68e9-a87c-4539-a125-f1835015b3f5"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("77776dc3-bf00-4f35-9310-d098a200b9c7"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("8b7ecdcc-5bcb-4174-9d75-367dde75037d"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("97bf165f-4675-43d1-b6d7-b1033c0d2784"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("2df3b91c-5392-4c23-a0b6-5c079f8dc26c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("8426c09a-321d-4098-b695-a495fa22ddee"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("a74d95b8-22e4-4779-a1ee-962b8f702f0c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("cafe5b9f-1c49-4e12-af1e-29ccd312b506"));

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
    }
}
