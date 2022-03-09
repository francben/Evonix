using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class addedModuloCuestionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf772206-30ec-4f46-97b8-4c560fbb1031", "2a3a3bcf-4d86-4cd7-9f23-112a12f23702" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8731d41-4b48-4440-bdf6-8f203b2915bd", "94ceae79-735f-4535-bd66-6aa7e3cedfa0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a537b7d8-00a9-4354-a681-e395c563388e", "d29e06b9-156a-4c02-b680-4a07cd6019a2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a537b7d8-00a9-4354-a681-e395c563388e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf772206-30ec-4f46-97b8-4c560fbb1031");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8731d41-4b48-4440-bdf6-8f203b2915bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3a3bcf-4d86-4cd7-9f23-112a12f23702");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94ceae79-735f-4535-bd66-6aa7e3cedfa0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d29e06b9-156a-4c02-b680-4a07cd6019a2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a537b7d8-00a9-4354-a681-e395c563388e", "5769e7b2-b57f-4358-bb60-54ae1d9ca372", "Entrenador", "ENTRENADOR" },
                    { "bf772206-30ec-4f46-97b8-4c560fbb1031", "5ce3e220-2431-44de-b7ef-139324052b95", "Admin", "ADMIN" },
                    { "c8731d41-4b48-4440-bdf6-8f203b2915bd", "27497c29-a252-4555-bdd5-020e0b54c53f", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2a3a3bcf-4d86-4cd7-9f23-112a12f23702", 0, "eee4fbff-e53a-408f-a7a7-b130dc84fa35", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "4fef69f3-43fd-419b-9c53-2eaa8645e31b", false, "SuperUsuario" },
                    { "94ceae79-735f-4535-bd66-6aa7e3cedfa0", 0, "c93abdbc-4a1f-4248-8c08-a0f9f9324f8b", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "4c0d6b3f-8738-4ec1-afa2-79f52a303a29", false, "fran" },
                    { "d29e06b9-156a-4c02-b680-4a07cd6019a2", 0, "6dada721-d1d0-4bf4-9869-36b20466e8eb", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "6949ff67-8b73-4e01-af02-2e0b17f8e9c1", false, "Juan" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf772206-30ec-4f46-97b8-4c560fbb1031", "2a3a3bcf-4d86-4cd7-9f23-112a12f23702" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c8731d41-4b48-4440-bdf6-8f203b2915bd", "94ceae79-735f-4535-bd66-6aa7e3cedfa0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a537b7d8-00a9-4354-a681-e395c563388e", "d29e06b9-156a-4c02-b680-4a07cd6019a2" });
        }
    }
}
