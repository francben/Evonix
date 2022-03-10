using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class ModuloEjercicio : Migration
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

            migrationBuilder.CreateTable(
                name: "Equipamientos",
                columns: table => new
                {
                    IdEquipamiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamientos", x => x.IdEquipamiento);
                });

            migrationBuilder.CreateTable(
                name: "Musculos",
                columns: table => new
                {
                    IdMusculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musculos", x => x.IdMusculo);
                });

            migrationBuilder.CreateTable(
                name: "Niveles",
                columns: table => new
                {
                    NivelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveles", x => x.NivelId);
                });

            migrationBuilder.CreateTable(
                name: "Ejercicios",
                columns: table => new
                {
                    IdEjercicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<int>(type: "int", nullable: true),
                    LinkVideo = table.Column<int>(type: "int", nullable: true),
                    NivelId = table.Column<int>(type: "int", nullable: true),
                    Geard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aparato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoEjecucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusculoIdMusculo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejercicios", x => x.IdEjercicio);
                    table.ForeignKey(
                        name: "FK_Ejercicios_Musculos_MusculoIdMusculo",
                        column: x => x.MusculoIdMusculo,
                        principalTable: "Musculos",
                        principalColumn: "IdMusculo");
                    table.ForeignKey(
                        name: "FK_Ejercicios_Niveles_NivelId",
                        column: x => x.NivelId,
                        principalTable: "Niveles",
                        principalColumn: "NivelId");
                });

            migrationBuilder.CreateTable(
                name: "EquipamientoEjercicios",
                columns: table => new
                {
                    IdEquipamientoEjercicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEquipamiento = table.Column<int>(type: "int", nullable: false),
                    IdEjercicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamientoEjercicios", x => x.IdEquipamientoEjercicio);
                    table.ForeignKey(
                        name: "FK_EquipamientoEjercicios_Ejercicios_IdEjercicio",
                        column: x => x.IdEjercicio,
                        principalTable: "Ejercicios",
                        principalColumn: "IdEjercicio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipamientoEjercicios_Equipamientos_IdEquipamiento",
                        column: x => x.IdEquipamiento,
                        principalTable: "Equipamientos",
                        principalColumn: "IdEquipamiento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusculoEjercicios",
                columns: table => new
                {
                    IdMusculoEjercicios = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMusculo = table.Column<int>(type: "int", nullable: false),
                    IdEjercicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusculoEjercicios", x => x.IdMusculoEjercicios);
                    table.ForeignKey(
                        name: "FK_MusculoEjercicios_Ejercicios_IdEjercicio",
                        column: x => x.IdEjercicio,
                        principalTable: "Ejercicios",
                        principalColumn: "IdEjercicio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusculoEjercicios_Musculos_IdMusculo",
                        column: x => x.IdMusculo,
                        principalTable: "Musculos",
                        principalColumn: "IdMusculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PasosEjercicios",
                columns: table => new
                {
                    IdPasos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEjercicio = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEjercicioNavigationIdEjercicio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasosEjercicios", x => x.IdPasos);
                    table.ForeignKey(
                        name: "FK_PasosEjercicios_Ejercicios_IdEjercicioNavigationIdEjercicio",
                        column: x => x.IdEjercicioNavigationIdEjercicio,
                        principalTable: "Ejercicios",
                        principalColumn: "IdEjercicio");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Ejercicios_NivelId",
                table: "Ejercicios",
                column: "NivelId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamientoEjercicios_IdEjercicio",
                table: "EquipamientoEjercicios",
                column: "IdEjercicio");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamientoEjercicios_IdEquipamiento",
                table: "EquipamientoEjercicios",
                column: "IdEquipamiento");

            migrationBuilder.CreateIndex(
                name: "IX_MusculoEjercicios_IdEjercicio",
                table: "MusculoEjercicios",
                column: "IdEjercicio");

            migrationBuilder.CreateIndex(
                name: "IX_MusculoEjercicios_IdMusculo",
                table: "MusculoEjercicios",
                column: "IdMusculo");

            migrationBuilder.CreateIndex(
                name: "IX_PasosEjercicios_IdEjercicioNavigationIdEjercicio",
                table: "PasosEjercicios",
                column: "IdEjercicioNavigationIdEjercicio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipamientoEjercicios");

            migrationBuilder.DropTable(
                name: "MusculoEjercicios");

            migrationBuilder.DropTable(
                name: "PasosEjercicios");

            migrationBuilder.DropTable(
                name: "Equipamientos");

            migrationBuilder.DropTable(
                name: "Ejercicios");

            migrationBuilder.DropTable(
                name: "Musculos");

            migrationBuilder.DropTable(
                name: "Niveles");

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
