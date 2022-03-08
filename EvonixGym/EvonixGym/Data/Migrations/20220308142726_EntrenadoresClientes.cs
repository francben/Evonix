using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class EntrenadoresClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(type: "int", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechanacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    Cp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imageperfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdEntrenamiento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Entrenadores",
                columns: table => new
                {
                    IdEntrenador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    Baja = table.Column<bool>(type: "bit", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaAltaContrato = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaProxPago = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores", x => x.IdEntrenador);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioClientes",
                columns: table => new
                {
                    UsuarioClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioClientes", x => x.UsuarioClienteID);
                    table.ForeignKey(
                        name: "FK_UsuarioClientes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioClientes_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioEntrenadores",
                columns: table => new
                {
                    UsuarioEntrenadorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdEntrenador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEntrenadores", x => x.UsuarioEntrenadorID);
                    table.ForeignKey(
                        name: "FK_UsuarioEntrenadores_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioEntrenadores_Entrenadores_IdEntrenador",
                        column: x => x.IdEntrenador,
                        principalTable: "Entrenadores",
                        principalColumn: "IdEntrenador",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioClientes_IdCliente",
                table: "UsuarioClientes",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioClientes_UserId",
                table: "UsuarioClientes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEntrenadores_IdEntrenador",
                table: "UsuarioEntrenadores",
                column: "IdEntrenador");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEntrenadores_UserId",
                table: "UsuarioEntrenadores",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioClientes");

            migrationBuilder.DropTable(
                name: "UsuarioEntrenadores");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Entrenadores");

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
    }
}
