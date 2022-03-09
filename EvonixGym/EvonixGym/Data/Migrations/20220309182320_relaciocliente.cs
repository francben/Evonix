using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class relaciocliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuestionarioClientes_Cuestionarios_CuestionarioIdCuestionario",
                table: "CuestionarioClientes");

            migrationBuilder.DropIndex(
                name: "IX_CuestionarioClientes_CuestionarioIdCuestionario",
                table: "CuestionarioClientes");

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
                name: "CuestionarioIdCuestionario",
                table: "CuestionarioClientes");

            migrationBuilder.AlterColumn<int>(
                name: "IdCuestionario",
                table: "CuestionarioClientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCliente",
                table: "CuestionarioClientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33a6dfe6-8a75-470b-861f-08e83d7bd26b", "0a176cf3-b05e-4d21-a849-93c53f8042cf", "Entrenador", "ENTRENADOR" },
                    { "df07624e-8428-4c12-9343-59d99e1e64a3", "5ef6c437-dd5b-40b1-9721-4386a896102a", "Cliente", "CLIENTE" },
                    { "e6771b82-48c8-4357-9945-d67407149e27", "c0e5cdd6-704a-4049-b3cf-50d6497cbd2d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "81495533-639e-4978-9a45-1acd201fb3b4", 0, "fa43972a-bf09-4f99-ae0b-765e61af14be", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "428dbfb0-5834-4786-a55f-f986027526ce", false, "Juan" },
                    { "a85dbaaa-d01e-42cf-9c51-6af3e1e80cbc", 0, "b156697c-2cbd-4351-b7d6-a690be7b5429", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "ae25305e-e4b0-459c-b37d-61328a664361", false, "fran" },
                    { "c6c1f17b-d86b-4a41-9fb5-e44663b8754d", 0, "d3c1be0a-000c-4a3b-a0a0-b8679531570a", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "f027c548-8cf2-4692-8e2a-c8f9ce391b3f", false, "SuperUsuario" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "33a6dfe6-8a75-470b-861f-08e83d7bd26b", "81495533-639e-4978-9a45-1acd201fb3b4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "df07624e-8428-4c12-9343-59d99e1e64a3", "a85dbaaa-d01e-42cf-9c51-6af3e1e80cbc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6771b82-48c8-4357-9945-d67407149e27", "c6c1f17b-d86b-4a41-9fb5-e44663b8754d" });

            migrationBuilder.CreateIndex(
                name: "IX_CuestionarioClientes_IdCliente",
                table: "CuestionarioClientes",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_CuestionarioClientes_IdCuestionario",
                table: "CuestionarioClientes",
                column: "IdCuestionario");

            migrationBuilder.AddForeignKey(
                name: "FK_CuestionarioClientes_Clientes_IdCliente",
                table: "CuestionarioClientes",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CuestionarioClientes_Cuestionarios_IdCuestionario",
                table: "CuestionarioClientes",
                column: "IdCuestionario",
                principalTable: "Cuestionarios",
                principalColumn: "IdCuestionario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuestionarioClientes_Clientes_IdCliente",
                table: "CuestionarioClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_CuestionarioClientes_Cuestionarios_IdCuestionario",
                table: "CuestionarioClientes");

            migrationBuilder.DropIndex(
                name: "IX_CuestionarioClientes_IdCliente",
                table: "CuestionarioClientes");

            migrationBuilder.DropIndex(
                name: "IX_CuestionarioClientes_IdCuestionario",
                table: "CuestionarioClientes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33a6dfe6-8a75-470b-861f-08e83d7bd26b", "81495533-639e-4978-9a45-1acd201fb3b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df07624e-8428-4c12-9343-59d99e1e64a3", "a85dbaaa-d01e-42cf-9c51-6af3e1e80cbc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6771b82-48c8-4357-9945-d67407149e27", "c6c1f17b-d86b-4a41-9fb5-e44663b8754d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33a6dfe6-8a75-470b-861f-08e83d7bd26b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df07624e-8428-4c12-9343-59d99e1e64a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6771b82-48c8-4357-9945-d67407149e27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81495533-639e-4978-9a45-1acd201fb3b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a85dbaaa-d01e-42cf-9c51-6af3e1e80cbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6c1f17b-d86b-4a41-9fb5-e44663b8754d");

            migrationBuilder.AlterColumn<int>(
                name: "IdCuestionario",
                table: "CuestionarioClientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdCliente",
                table: "CuestionarioClientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CuestionarioIdCuestionario",
                table: "CuestionarioClientes",
                type: "int",
                nullable: true);

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
                name: "IX_CuestionarioClientes_CuestionarioIdCuestionario",
                table: "CuestionarioClientes",
                column: "CuestionarioIdCuestionario");

            migrationBuilder.AddForeignKey(
                name: "FK_CuestionarioClientes_Cuestionarios_CuestionarioIdCuestionario",
                table: "CuestionarioClientes",
                column: "CuestionarioIdCuestionario",
                principalTable: "Cuestionarios",
                principalColumn: "IdCuestionario");
        }
    }
}
