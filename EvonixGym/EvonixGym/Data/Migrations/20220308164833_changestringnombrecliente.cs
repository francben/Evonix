using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class changestringnombrecliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c301e305-39f9-4f7a-8dab-94c0a0f0d42b", "30f52464-83aa-400a-8d99-28b43ae04100" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13315589-af88-44db-801e-d1c3baa575d2", "a1c1cf1c-3613-4603-9bd6-1cd223e4b22b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eaa4745a-0579-4c52-8052-180fbd35685a", "ebaa33b6-aa0b-45e4-b7ee-75f8f67fcc3f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13315589-af88-44db-801e-d1c3baa575d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c301e305-39f9-4f7a-8dab-94c0a0f0d42b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaa4745a-0579-4c52-8052-180fbd35685a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30f52464-83aa-400a-8d99-28b43ae04100");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1c1cf1c-3613-4603-9bd6-1cd223e4b22b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebaa33b6-aa0b-45e4-b7ee-75f8f67fcc3f");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a6b6fc7-b833-4622-b63b-bee412604a5d", "3ac06ac8-1065-419b-b72b-cfe7e2da2c5f", "Cliente", "CLIENTE" },
                    { "4de63080-92f2-4166-9809-1ea2193545b2", "9b2864fd-9a7b-46dc-9030-972df6a30ede", "Entrenador", "ENTRENADOR" },
                    { "7c6aca4a-ffd7-4a35-acc5-9aa177e10f3c", "913b9498-7092-4bf2-96d8-4d42fa28fcbd", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30408596-f3ac-4bd0-9088-079551582b16", 0, "4d6d2311-0566-4a54-8971-3171febaa31a", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "3ce68d52-65d9-462a-a255-a6087f627d59", false, "SuperUsuario" },
                    { "9ba1a001-d1ed-4646-8463-72d9a51e2bb0", 0, "201dc20a-21f9-43a6-8196-8534f5390cca", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "f621028c-9ee0-49e9-8184-5c3f3d50f936", false, "fran" },
                    { "e5064d70-9595-4629-941a-0bd424f9dd67", 0, "f37ae1eb-87e2-4465-8064-61f5b3abacf4", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "633f9d10-06ae-45fa-b7a6-2c48af0b82c1", false, "Juan" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7c6aca4a-ffd7-4a35-acc5-9aa177e10f3c", "30408596-f3ac-4bd0-9088-079551582b16" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a6b6fc7-b833-4622-b63b-bee412604a5d", "9ba1a001-d1ed-4646-8463-72d9a51e2bb0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4de63080-92f2-4166-9809-1ea2193545b2", "e5064d70-9595-4629-941a-0bd424f9dd67" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c6aca4a-ffd7-4a35-acc5-9aa177e10f3c", "30408596-f3ac-4bd0-9088-079551582b16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a6b6fc7-b833-4622-b63b-bee412604a5d", "9ba1a001-d1ed-4646-8463-72d9a51e2bb0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4de63080-92f2-4166-9809-1ea2193545b2", "e5064d70-9595-4629-941a-0bd424f9dd67" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6b6fc7-b833-4622-b63b-bee412604a5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4de63080-92f2-4166-9809-1ea2193545b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c6aca4a-ffd7-4a35-acc5-9aa177e10f3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30408596-f3ac-4bd0-9088-079551582b16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ba1a001-d1ed-4646-8463-72d9a51e2bb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5064d70-9595-4629-941a-0bd424f9dd67");

            migrationBuilder.AlterColumn<int>(
                name: "Nombre",
                table: "Clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13315589-af88-44db-801e-d1c3baa575d2", "24f2477d-3d47-4d6c-bedb-4f878282ca39", "Entrenador", "ENTRENADOR" },
                    { "c301e305-39f9-4f7a-8dab-94c0a0f0d42b", "36d7e2e1-4a8d-4cd2-8731-9843ae2da4fe", "Cliente", "CLIENTE" },
                    { "eaa4745a-0579-4c52-8052-180fbd35685a", "a60a3545-9750-413d-8e09-cae85def5d7c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30f52464-83aa-400a-8d99-28b43ae04100", 0, "6c13165f-9e2d-4b0c-822a-4febff8092e3", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "eba3cb8c-85ec-47ce-9566-e93d4488138d", false, "fran" },
                    { "a1c1cf1c-3613-4603-9bd6-1cd223e4b22b", 0, "07ce8e53-e138-44ea-8fa4-2bcf28135ca4", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "a053320d-0632-44bc-a2bf-91c0b1f4dac4", false, "Juan" },
                    { "ebaa33b6-aa0b-45e4-b7ee-75f8f67fcc3f", 0, "66abce4a-97da-4546-93de-b152481e96da", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "81914c49-7c11-4e2a-87d6-4986e627e282", false, "SuperUsuario" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c301e305-39f9-4f7a-8dab-94c0a0f0d42b", "30f52464-83aa-400a-8d99-28b43ae04100" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "13315589-af88-44db-801e-d1c3baa575d2", "a1c1cf1c-3613-4603-9bd6-1cd223e4b22b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eaa4745a-0579-4c52-8052-180fbd35685a", "ebaa33b6-aa0b-45e4-b7ee-75f8f67fcc3f" });
        }
    }
}
