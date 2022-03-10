using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class correccionEjercicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoIdMusculo",
                table: "Ejercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Niveles_NivelId",
                table: "Ejercicios");

            migrationBuilder.DropIndex(
                name: "IX_Ejercicios_MusculoIdMusculo",
                table: "Ejercicios");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a7cac3c-f90b-425a-b077-8114b277f6d8", "7b27b300-97e9-4649-add1-64331e453313" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffa5d7dd-3f2c-4799-af15-e7a4cd2a5ed2", "949c664f-0618-4232-aca1-eb527a55d341" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba64404f-beb2-4ab5-ba61-33ff840b0655", "f350e04a-cb5c-4637-a845-3424af7f1cea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a7cac3c-f90b-425a-b077-8114b277f6d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba64404f-beb2-4ab5-ba61-33ff840b0655");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffa5d7dd-3f2c-4799-af15-e7a4cd2a5ed2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b27b300-97e9-4649-add1-64331e453313");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "949c664f-0618-4232-aca1-eb527a55d341");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f350e04a-cb5c-4637-a845-3424af7f1cea");

            migrationBuilder.DropColumn(
                name: "MusculoIdMusculo",
                table: "Ejercicios");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Ejercicios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NivelId",
                table: "Ejercicios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkVideo",
                table: "Ejercicios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Ejercicios",
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
                    { "6fbde398-8b73-40c0-b770-e50c76695d70", "cec8438f-6d2e-4602-9b9d-8615a7ae5f39", "Entrenador", "ENTRENADOR" },
                    { "95cfd66b-e737-4c9b-bf6e-bb0beea88d8f", "5078c260-be32-4f44-8bde-bd8ef064eae7", "Admin", "ADMIN" },
                    { "abe19e28-1505-40bd-8feb-7dffbad1d4b1", "dcd73dd4-7999-471b-a30c-1ff2b8aa7166", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16099f06-e9e3-40fb-a85d-08badb58f1fe", 0, "c3759f92-7a99-4944-8a9e-a4f7debc6d7e", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "af8d3b06-91b9-4404-be20-7f34d9d4a915", false, "SuperUsuario" },
                    { "570e59e3-42df-4851-a6c2-3ec4c26a9613", 0, "e6713e46-df58-44e2-a625-f3d9ec3bfd47", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "772c66af-38b8-4a0b-8579-07f32ea4336a", false, "fran" },
                    { "9fb642bb-4db3-4e2b-8955-6f3251a1f77e", 0, "3584a8e4-9063-4d92-83a3-92bc5fbd7fa3", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "26c156f3-901d-4450-baa5-0b98d4fef5e8", false, "Juan" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "95cfd66b-e737-4c9b-bf6e-bb0beea88d8f", "16099f06-e9e3-40fb-a85d-08badb58f1fe" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "abe19e28-1505-40bd-8feb-7dffbad1d4b1", "570e59e3-42df-4851-a6c2-3ec4c26a9613" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6fbde398-8b73-40c0-b770-e50c76695d70", "9fb642bb-4db3-4e2b-8955-6f3251a1f77e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_Niveles_NivelId",
                table: "Ejercicios",
                column: "NivelId",
                principalTable: "Niveles",
                principalColumn: "NivelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicios_Niveles_NivelId",
                table: "Ejercicios");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cfd66b-e737-4c9b-bf6e-bb0beea88d8f", "16099f06-e9e3-40fb-a85d-08badb58f1fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abe19e28-1505-40bd-8feb-7dffbad1d4b1", "570e59e3-42df-4851-a6c2-3ec4c26a9613" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fbde398-8b73-40c0-b770-e50c76695d70", "9fb642bb-4db3-4e2b-8955-6f3251a1f77e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fbde398-8b73-40c0-b770-e50c76695d70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95cfd66b-e737-4c9b-bf6e-bb0beea88d8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe19e28-1505-40bd-8feb-7dffbad1d4b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16099f06-e9e3-40fb-a85d-08badb58f1fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "570e59e3-42df-4851-a6c2-3ec4c26a9613");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fb642bb-4db3-4e2b-8955-6f3251a1f77e");

            migrationBuilder.AlterColumn<int>(
                name: "Titulo",
                table: "Ejercicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NivelId",
                table: "Ejercicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LinkVideo",
                table: "Ejercicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Descripcion",
                table: "Ejercicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusculoIdMusculo",
                table: "Ejercicios",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a7cac3c-f90b-425a-b077-8114b277f6d8", "0b44bb97-b9a1-497a-b1f7-399c1b9dd6a9", "Entrenador", "ENTRENADOR" },
                    { "ba64404f-beb2-4ab5-ba61-33ff840b0655", "4bf69e10-0128-4d3e-8caf-5fc2aba0a28e", "Cliente", "CLIENTE" },
                    { "ffa5d7dd-3f2c-4799-af15-e7a4cd2a5ed2", "8a9737d8-157a-4da7-9103-e3d9a8fe870b", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7b27b300-97e9-4649-add1-64331e453313", 0, "682d5a3d-3b3a-45a0-b429-43a62a7ec86a", "entrenador@gmail.com", false, false, null, "ENTRENADOR@GMAIL.COM", "JUAN", null, null, false, "fd1b2aba-cd7c-41ed-a3ef-06c0c13eb839", false, "Juan" },
                    { "949c664f-0618-4232-aca1-eb527a55d341", 0, "128601ff-303d-4dd2-a947-41a696bc587d", "usuadmin@gmail.com", false, false, null, "USUADMIN@GMAIL.COM", "SUPERUSUARIO", null, null, false, "56097a75-8d94-4a00-8ed7-c27296dfda30", false, "SuperUsuario" },
                    { "f350e04a-cb5c-4637-a845-3424af7f1cea", 0, "59027d31-7fac-40d3-b8f3-01ab5acc9a4a", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "FRAN", null, null, false, "5f9581e0-0069-4629-9dac-5403b492a20f", false, "fran" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0a7cac3c-f90b-425a-b077-8114b277f6d8", "7b27b300-97e9-4649-add1-64331e453313" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ffa5d7dd-3f2c-4799-af15-e7a4cd2a5ed2", "949c664f-0618-4232-aca1-eb527a55d341" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ba64404f-beb2-4ab5-ba61-33ff840b0655", "f350e04a-cb5c-4637-a845-3424af7f1cea" });

            migrationBuilder.CreateIndex(
                name: "IX_Ejercicios_MusculoIdMusculo",
                table: "Ejercicios",
                column: "MusculoIdMusculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_Musculos_MusculoIdMusculo",
                table: "Ejercicios",
                column: "MusculoIdMusculo",
                principalTable: "Musculos",
                principalColumn: "IdMusculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicios_Niveles_NivelId",
                table: "Ejercicios",
                column: "NivelId",
                principalTable: "Niveles",
                principalColumn: "NivelId");
        }
    }
}
