using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class DatosRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9884a252-4775-4be4-928a-8c680d327180", "909376b4-21a8-4236-91cd-5f5c833c5a72", "Cliente", "CLIENTE" },
                    { "d26004e7-af8b-4330-ab5c-8fa0aca4c489", "1d0a9e42-207f-47f5-a9dc-3d105aabaebe", "Admin", "ADMIN" },
                    { "da346ac2-766f-4fed-bc68-7cf691b9ea51", "fb70c53b-9074-4cb1-8b2a-bd24e43db087", "Entrenador", "ENTRENADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c703e84-7bda-4b98-8615-3ffc2e626f92", 0, "659d904b-ea59-471d-8332-41c47b85707f", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "a7f0716f-5451-4871-97cb-eb8452620b73", false, "SuperUsuario" },
                    { "5e77c4f4-2892-4b98-9063-6a320f9c796a", 0, "03028c08-a3ba-4409-8659-b9be80c6dca0", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "9d499c7e-5e08-4e00-a135-3107de95044e", false, "fran" },
                    { "93c32a8d-434f-424e-b763-09a7330d85ee", 0, "96db6934-fea5-4191-9e9b-2ae4934703fb", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "ee1c3be2-1d60-4098-8a4a-a0db9ef8400f", false, "Juan" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d26004e7-af8b-4330-ab5c-8fa0aca4c489", "2c703e84-7bda-4b98-8615-3ffc2e626f92" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9884a252-4775-4be4-928a-8c680d327180", "5e77c4f4-2892-4b98-9063-6a320f9c796a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "da346ac2-766f-4fed-bc68-7cf691b9ea51", "93c32a8d-434f-424e-b763-09a7330d85ee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d26004e7-af8b-4330-ab5c-8fa0aca4c489", "2c703e84-7bda-4b98-8615-3ffc2e626f92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9884a252-4775-4be4-928a-8c680d327180", "5e77c4f4-2892-4b98-9063-6a320f9c796a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da346ac2-766f-4fed-bc68-7cf691b9ea51", "93c32a8d-434f-424e-b763-09a7330d85ee" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9884a252-4775-4be4-928a-8c680d327180");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d26004e7-af8b-4330-ab5c-8fa0aca4c489");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da346ac2-766f-4fed-bc68-7cf691b9ea51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c703e84-7bda-4b98-8615-3ffc2e626f92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e77c4f4-2892-4b98-9063-6a320f9c796a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93c32a8d-434f-424e-b763-09a7330d85ee");
        }
    }
}
