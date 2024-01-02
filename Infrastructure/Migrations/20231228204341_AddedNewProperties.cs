using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "UserId",
                table: "AnimalModel");

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("047353a2-1fee-4ca4-847b-88e6a6674b2e"), "", "Dog", "Sedel", 0 },
                    { new Guid("2217ecca-300d-493a-8706-6aafa2598680"), "", "Dog", "Misha", 0 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("315bb005-5d7c-48db-8178-7d1ad3a41d05"), false, "", "Bird", "Parrot" });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("413eca91-1b84-4399-9408-660af4482da0"), "", "Cat", false, "Nuno", 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("41e81086-0476-4d59-944c-5a513532e523"), "", "Dog", "Tom", 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[,]
                {
                    { new Guid("5aae6ac2-1814-4797-9792-e63a59e5b7d3"), false, "", "Bird", "Fench" },
                    { new Guid("8cfc02d3-6cc7-45fb-8616-0e5c5f9151ad"), false, "", "Bird", "Cortex" },
                    { new Guid("8ef28e95-338c-4d34-9e30-87e6216983df"), false, "", "Bird", "Feri" }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("af2d258d-5fda-4155-9fd7-5a391bd605aa"), "", "Cat", false, "Puppy", 0 },
                    { new Guid("c9314b2c-7951-4df7-96b1-28132a7c7e6c"), "", "Cat", false, "Shima", 0 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("f480fb3d-a8e4-4917-85a6-2cfc912dc946"), "", "Dog", "Tezar", 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("fb01054a-90b1-4dc8-897f-3bdf50b05170"), "", "Cat", false, "Mani", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("047353a2-1fee-4ca4-847b-88e6a6674b2e"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("2217ecca-300d-493a-8706-6aafa2598680"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("315bb005-5d7c-48db-8178-7d1ad3a41d05"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("413eca91-1b84-4399-9408-660af4482da0"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("41e81086-0476-4d59-944c-5a513532e523"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("5aae6ac2-1814-4797-9792-e63a59e5b7d3"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("8cfc02d3-6cc7-45fb-8616-0e5c5f9151ad"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("8ef28e95-338c-4d34-9e30-87e6216983df"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("af2d258d-5fda-4155-9fd7-5a391bd605aa"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("c9314b2c-7951-4df7-96b1-28132a7c7e6c"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("f480fb3d-a8e4-4917-85a6-2cfc912dc946"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("fb01054a-90b1-4dc8-897f-3bdf50b05170"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "AnimalModel",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

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
        }
    }
}
