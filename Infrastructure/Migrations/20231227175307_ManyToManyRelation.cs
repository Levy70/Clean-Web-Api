using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Birds");

            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs");

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

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Dogs",
                newName: "AnimalModel");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "AnimalModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "AnimalModel",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "CanFly",
                table: "AnimalModel",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "AnimalModel",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AnimalModel",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Dog_Breed",
                table: "AnimalModel",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Dog_Weight",
                table: "AnimalModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LikesToPlay",
                table: "AnimalModel",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalModel",
                table: "AnimalModel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserAnimal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AnimalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnimal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnimal_AnimalModel_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "AnimalModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnimal_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "UserId", "Dog_Weight" },
                values: new object[] { new Guid("02891b7b-fe65-46c8-b5ec-1521926510bf"), "", "Dog", "", new Guid("00000000-0000-0000-0000-000000000000"), 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "UserId", "Weight" },
                values: new object[] { new Guid("05ca33ed-be2e-4bd1-8267-ca020927a18a"), "", "Cat", false, "Mani", new Guid("00000000-0000-0000-0000-000000000000"), 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e139174-f5ae-4bad-b7ba-3371ecb6abad"), false, "", "Bird", "Feri", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("346d327b-b5bb-4a34-95f1-1fb65db5a409"), false, "", "Bird", "Fench", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "UserId", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("6b5e96f3-5e92-4f45-bc60-463329b79cf1"), "", "Dog", "", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("75df04b6-3029-4331-93a0-a257a12b8736"), "", "Dog", "", new Guid("00000000-0000-0000-0000-000000000000"), 0 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "UserId", "Weight" },
                values: new object[] { new Guid("972fe673-9d89-4f25-b912-ef316e5d95b0"), "", "Cat", false, "Nuno", new Guid("00000000-0000-0000-0000-000000000000"), 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name", "UserId" },
                values: new object[] { new Guid("b8e4262d-80b7-410f-ab31-7a991507fd09"), false, "", "Bird", "Parrot", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("ba99ab42-509e-47ae-846e-2cd90b95c829"), "", "Cat", false, "Shima", new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("c7a2c6cc-fca7-4afa-a13d-1b451de3f0eb"), "", "Cat", false, "Puppy", new Guid("00000000-0000-0000-0000-000000000000"), 0 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name", "UserId" },
                values: new object[] { new Guid("db9a8ba2-ef9c-4c7b-82e2-188a70e2f71f"), false, "", "Bird", "Cortex", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "UserId", "Dog_Weight" },
                values: new object[] { new Guid("e1797cfc-980a-4e59-b387-7269652e94fa"), "", "Dog", "", new Guid("00000000-0000-0000-0000-000000000000"), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimal_AnimalId",
                table: "UserAnimal",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimal_UserId",
                table: "UserAnimal",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAnimal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalModel",
                table: "AnimalModel");

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("02891b7b-fe65-46c8-b5ec-1521926510bf"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("05ca33ed-be2e-4bd1-8267-ca020927a18a"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("0e139174-f5ae-4bad-b7ba-3371ecb6abad"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("346d327b-b5bb-4a34-95f1-1fb65db5a409"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("6b5e96f3-5e92-4f45-bc60-463329b79cf1"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("75df04b6-3029-4331-93a0-a257a12b8736"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("972fe673-9d89-4f25-b912-ef316e5d95b0"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("b8e4262d-80b7-410f-ab31-7a991507fd09"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("ba99ab42-509e-47ae-846e-2cd90b95c829"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("c7a2c6cc-fca7-4afa-a13d-1b451de3f0eb"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("db9a8ba2-ef9c-4c7b-82e2-188a70e2f71f"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("e1797cfc-980a-4e59-b387-7269652e94fa"));

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "AnimalModel");

            migrationBuilder.DropColumn(
                name: "CanFly",
                table: "AnimalModel");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "AnimalModel");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AnimalModel");

            migrationBuilder.DropColumn(
                name: "Dog_Breed",
                table: "AnimalModel");

            migrationBuilder.DropColumn(
                name: "Dog_Weight",
                table: "AnimalModel");

            migrationBuilder.DropColumn(
                name: "LikesToPlay",
                table: "AnimalModel");

            migrationBuilder.RenameTable(
                name: "AnimalModel",
                newName: "Dogs");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "longblob",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "longblob",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Birds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CanFly = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birds", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LikesToPlay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
    }
}
