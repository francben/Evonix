using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class changerelationshipentreclient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "195d2aa0-d998-4e8d-bb9e-a23d7baab3f6", "40cdef9b-92f9-401e-a05c-128430c1e0f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ae20379c-fe59-44c7-9c5f-23c502a5e225", "4c52f832-f912-4f9b-a4e9-92975a0d96d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95b53714-8125-44e3-8d69-392bd910f0dd", "555a7de8-140a-46f8-99dc-8adf7a0305d3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "195d2aa0-d998-4e8d-bb9e-a23d7baab3f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95b53714-8125-44e3-8d69-392bd910f0dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae20379c-fe59-44c7-9c5f-23c502a5e225");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40cdef9b-92f9-401e-a05c-128430c1e0f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c52f832-f912-4f9b-a4e9-92975a0d96d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555a7de8-140a-46f8-99dc-8adf7a0305d3");

            migrationBuilder.AddColumn<int>(
                name: "EntrenadorIdEntrenador",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEntrenador",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "062407e6-265d-4129-8323-9c1ca3a2f724", "ef94ddce-1eb7-45e0-af7d-37e8383b4ab4", "Cliente", "CLIENTE" },
                    { "ee5ef447-0270-42b0-b542-59d03d4c090d", "1fcefcb2-e65e-4ee7-9fe7-b45ddfc4c4b8", "Admin", "ADMIN" },
                    { "fe1e366a-6387-477e-9ed2-802d67c0f3e1", "96bb3f06-4e66-4749-93a2-429013469dc1", "Entrenador", "ENTRENADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2a96142e-1d52-4fb6-a9ce-0d165cac45af", 0, "d0428ca0-9aa8-4c69-9d03-2890c41b9c84", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "d69c7dcf-40aa-4add-a1d2-f7b6b4e82d2f", false, "fran" },
                    { "3c61e460-218c-43bc-b02e-253805f39bbe", 0, "4e8b56f1-1a77-43c0-ba97-f35f34714d30", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "5274f24c-c3b1-4868-b541-df07415f6aff", false, "Juan" },
                    { "4a22646d-258f-4020-9aad-d03f90c73c0c", 0, "069198ac-7c0e-4e21-9167-dc666a6c3ba5", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "5ffe6a0d-c80a-40fc-b4c8-2157f1eaceae", false, "SuperUsuario" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "062407e6-265d-4129-8323-9c1ca3a2f724", "2a96142e-1d52-4fb6-a9ce-0d165cac45af" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fe1e366a-6387-477e-9ed2-802d67c0f3e1", "3c61e460-218c-43bc-b02e-253805f39bbe" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ee5ef447-0270-42b0-b542-59d03d4c090d", "4a22646d-258f-4020-9aad-d03f90c73c0c" });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EntrenadorIdEntrenador",
                table: "Clientes",
                column: "EntrenadorIdEntrenador");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Entrenadores_EntrenadorIdEntrenador",
                table: "Clientes",
                column: "EntrenadorIdEntrenador",
                principalTable: "Entrenadores",
                principalColumn: "IdEntrenador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Entrenadores_EntrenadorIdEntrenador",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_EntrenadorIdEntrenador",
                table: "Clientes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "062407e6-265d-4129-8323-9c1ca3a2f724", "2a96142e-1d52-4fb6-a9ce-0d165cac45af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe1e366a-6387-477e-9ed2-802d67c0f3e1", "3c61e460-218c-43bc-b02e-253805f39bbe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee5ef447-0270-42b0-b542-59d03d4c090d", "4a22646d-258f-4020-9aad-d03f90c73c0c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "062407e6-265d-4129-8323-9c1ca3a2f724");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee5ef447-0270-42b0-b542-59d03d4c090d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe1e366a-6387-477e-9ed2-802d67c0f3e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a96142e-1d52-4fb6-a9ce-0d165cac45af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c61e460-218c-43bc-b02e-253805f39bbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a22646d-258f-4020-9aad-d03f90c73c0c");

            migrationBuilder.DropColumn(
                name: "EntrenadorIdEntrenador",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IdEntrenador",
                table: "Clientes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "195d2aa0-d998-4e8d-bb9e-a23d7baab3f6", "4b8d91d6-7b31-45bc-8ea3-865f1ef05662", "Entrenador", "ENTRENADOR" },
                    { "95b53714-8125-44e3-8d69-392bd910f0dd", "5eea21ac-c056-459d-99e1-abea5ebacd2a", "Cliente", "CLIENTE" },
                    { "ae20379c-fe59-44c7-9c5f-23c502a5e225", "5efe59cc-1b42-4315-8346-3ac9537f16c5", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "40cdef9b-92f9-401e-a05c-128430c1e0f9", 0, "91b387c1-a514-4d07-92f8-0b179523a135", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "fcfa62e8-d093-4650-ab75-c3a507429080", false, "Juan" },
                    { "4c52f832-f912-4f9b-a4e9-92975a0d96d2", 0, "9e7cd035-ff8c-4e36-a46a-f988de31e856", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "91033d89-2c7d-42be-ae71-991d6a20ee90", false, "SuperUsuario" },
                    { "555a7de8-140a-46f8-99dc-8adf7a0305d3", 0, "971cd602-8e3f-4bf7-bc67-7cdfa5aa4453", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "a8c22b00-9cc7-4f62-bf8d-1b8ece8e6a49", false, "fran" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "195d2aa0-d998-4e8d-bb9e-a23d7baab3f6", "40cdef9b-92f9-401e-a05c-128430c1e0f9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ae20379c-fe59-44c7-9c5f-23c502a5e225", "4c52f832-f912-4f9b-a4e9-92975a0d96d2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "95b53714-8125-44e3-8d69-392bd910f0dd", "555a7de8-140a-46f8-99dc-8adf7a0305d3" });
        }
    }
}
