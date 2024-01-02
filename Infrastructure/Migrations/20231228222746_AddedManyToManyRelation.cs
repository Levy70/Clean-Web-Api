using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedManyToManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnimal",
                table: "UserAnimal");

            migrationBuilder.DropIndex(
                name: "IX_UserAnimal_UserId",
                table: "UserAnimal");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnimal",
                table: "UserAnimal",
                columns: new[] { "UserId", "AnimalId" });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("026edd7f-51ae-471b-b128-6a966664e8e3"), "", "Cat", false, "Mani", 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("049473db-e101-40b6-8a67-7c2e7c37647e"), "", "Dog", "Tom", 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("1a38ac62-882d-4839-99c5-970fffe528a0"), false, "", "Bird", "Parrot" });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("2da074b9-d882-4360-8d45-a7e7ce6d4f46"), "", "Dog", "Tezar", 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("50ff375b-c52d-4663-94cd-0dfece57b26e"), false, "", "Bird", "Cortex" });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("5aba6e01-db1c-4238-85e4-0869b9395b41"), "", "Cat", false, "Shima", 0 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("5b0e61e7-3ba4-4443-80f6-81953df95392"), "", "Dog", "Misha", 0 },
                    { new Guid("5c9a41e6-ac45-49c1-8123-d5b7e816e57a"), "", "Dog", "Sedel", 0 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[,]
                {
                    { new Guid("928cb498-3337-48bb-a5d5-555dabb5c9d5"), false, "", "Bird", "Fench" },
                    { new Guid("94fad6dd-373f-4058-b929-fab011f9e1af"), false, "", "Bird", "Feri" }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("c122fef4-f941-4a18-8207-8f3ca57ed110"), "", "Cat", false, "Puppy", 0 },
                    { new Guid("dd76df70-85c4-450b-9d50-6eb7d0fb3e8f"), "", "Cat", false, "Nuno", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnimal",
                table: "UserAnimal");

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("026edd7f-51ae-471b-b128-6a966664e8e3"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("049473db-e101-40b6-8a67-7c2e7c37647e"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("1a38ac62-882d-4839-99c5-970fffe528a0"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("2da074b9-d882-4360-8d45-a7e7ce6d4f46"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("50ff375b-c52d-4663-94cd-0dfece57b26e"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("5aba6e01-db1c-4238-85e4-0869b9395b41"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("5b0e61e7-3ba4-4443-80f6-81953df95392"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("5c9a41e6-ac45-49c1-8123-d5b7e816e57a"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("928cb498-3337-48bb-a5d5-555dabb5c9d5"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("94fad6dd-373f-4058-b929-fab011f9e1af"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("c122fef4-f941-4a18-8207-8f3ca57ed110"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("dd76df70-85c4-450b-9d50-6eb7d0fb3e8f"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnimal",
                table: "UserAnimal",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimal_UserId",
                table: "UserAnimal",
                column: "UserId");
        }
    }
}
