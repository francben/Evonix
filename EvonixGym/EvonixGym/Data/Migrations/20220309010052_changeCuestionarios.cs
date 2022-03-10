using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    public partial class changeCuestionarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Cuestionarios",
                columns: table => new
                {
                    IdCuestionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEntrenador = table.Column<int>(type: "int", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEntrenadorNavigationIdEntrenador = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuestionarios", x => x.IdCuestionario);
                    table.ForeignKey(
                        name: "FK_Cuestionarios_Entrenadores_IdEntrenadorNavigationIdEntrenador",
                        column: x => x.IdEntrenadorNavigationIdEntrenador,
                        principalTable: "Entrenadores",
                        principalColumn: "IdEntrenador");
                });

            migrationBuilder.CreateTable(
                name: "Perimetros",
                columns: table => new
                {
                    IdPerimetro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadDeMedida = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perimetros", x => x.IdPerimetro);
                });

            migrationBuilder.CreateTable(
                name: "composicionCorporals",
                columns: table => new
                {
                    IdComposicion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CueIdCuestionario = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCuestionario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CueIdCuestionarioNavigationIdCuestionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_composicionCorporals", x => x.IdComposicion);
                    table.ForeignKey(
                        name: "FK_composicionCorporals_Cuestionarios_CueIdCuestionarioNavigationIdCuestionario",
                        column: x => x.CueIdCuestionarioNavigationIdCuestionario,
                        principalTable: "Cuestionarios",
                        principalColumn: "IdCuestionario");
                });

            migrationBuilder.CreateTable(
                name: "CuestionarioClientes",
                columns: table => new
                {
                    IdCuestionarioClientes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCuestionario = table.Column<int>(type: "int", nullable: true),
                    IdCliente = table.Column<int>(type: "int", nullable: true),
                    CuestionarioIdCuestionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuestionarioClientes", x => x.IdCuestionarioClientes);
                    table.ForeignKey(
                        name: "FK_CuestionarioClientes_Cuestionarios_CuestionarioIdCuestionario",
                        column: x => x.CuestionarioIdCuestionario,
                        principalTable: "Cuestionarios",
                        principalColumn: "IdCuestionario");
                });

            migrationBuilder.CreateTable(
                name: "Preguntas",
                columns: table => new
                {
                    IdPreguntas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCuestionario = table.Column<int>(type: "int", nullable: true),
                    IdCuestionarioNavigationIdCuestionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preguntas", x => x.IdPreguntas);
                    table.ForeignKey(
                        name: "FK_Preguntas_Cuestionarios_IdCuestionarioNavigationIdCuestionario",
                        column: x => x.IdCuestionarioNavigationIdCuestionario,
                        principalTable: "Cuestionarios",
                        principalColumn: "IdCuestionario");
                });

            migrationBuilder.CreateTable(
                name: "perimetroDelClientes",
                columns: table => new
                {
                    IdPerimetroCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdPerimetro = table.Column<int>(type: "int", nullable: false),
                    MedidaDeseada = table.Column<double>(type: "float", nullable: true),
                    MedidaActual = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perimetroDelClientes", x => x.IdPerimetroCliente);
                    table.ForeignKey(
                        name: "FK_perimetroDelClientes_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_perimetroDelClientes_Perimetros_IdPerimetro",
                        column: x => x.IdPerimetro,
                        principalTable: "Perimetros",
                        principalColumn: "IdPerimetro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerimetrosCuestionarios",
                columns: table => new
                {
                    IdPerimetrosCuest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPerimetro = table.Column<int>(type: "int", nullable: false),
                    IdCuestionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerimetrosCuestionarios", x => x.IdPerimetrosCuest);
                    table.ForeignKey(
                        name: "FK_PerimetrosCuestionarios_Cuestionarios_IdCuestionario",
                        column: x => x.IdCuestionario,
                        principalTable: "Cuestionarios",
                        principalColumn: "IdCuestionario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerimetrosCuestionarios_Perimetros_IdPerimetro",
                        column: x => x.IdPerimetro,
                        principalTable: "Perimetros",
                        principalColumn: "IdPerimetro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "composicionCorporalClients",
                columns: table => new
                {
                    IdCcCliente = table.Column<int>(type: "int", nullable: false),
                    IdComposicion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_composicionCorporalClients", x => x.IdCcCliente);
                    table.ForeignKey(
                        name: "FK_composicionCorporalClients_Clientes_IdCcCliente",
                        column: x => x.IdCcCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_composicionCorporalClients_composicionCorporals_IdComposicion",
                        column: x => x.IdComposicion,
                        principalTable: "composicionCorporals",
                        principalColumn: "IdComposicion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Archivos",
                columns: table => new
                {
                    IdArchivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPreguntas = table.Column<int>(type: "int", nullable: true),
                    IdPregunta = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreguntaIdPreguntas = table.Column<int>(type: "int", nullable: true),
                    PreguntaIdPreguntas1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archivos", x => x.IdArchivo);
                    table.ForeignKey(
                        name: "FK_Archivos_Preguntas_PreguntaIdPreguntas",
                        column: x => x.PreguntaIdPreguntas,
                        principalTable: "Preguntas",
                        principalColumn: "IdPreguntas");
                    table.ForeignKey(
                        name: "FK_Archivos_Preguntas_PreguntaIdPreguntas1",
                        column: x => x.PreguntaIdPreguntas1,
                        principalTable: "Preguntas",
                        principalColumn: "IdPreguntas");
                });

            migrationBuilder.CreateTable(
                name: "Respuesta",
                columns: table => new
                {
                    IdRespuesta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPreguntas = table.Column<int>(type: "int", nullable: true),
                    Respuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPregunta = table.Column<int>(type: "int", nullable: true),
                    IdPreguntasNavigationIdPreguntas = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respuesta", x => x.IdRespuesta);
                    table.ForeignKey(
                        name: "FK_Respuesta_Preguntas_IdPreguntasNavigationIdPreguntas",
                        column: x => x.IdPreguntasNavigationIdPreguntas,
                        principalTable: "Preguntas",
                        principalColumn: "IdPreguntas");
                });

            migrationBuilder.CreateTable(
                name: "archivoresps",
                columns: table => new
                {
                    IdArchivoResp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRespuesta = table.Column<int>(type: "int", nullable: true),
                    IdPregunta = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRespuestaNavigationIdRespuesta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_archivoresps", x => x.IdArchivoResp);
                    table.ForeignKey(
                        name: "FK_archivoresps_Respuesta_IdRespuestaNavigationIdRespuesta",
                        column: x => x.IdRespuestaNavigationIdRespuesta,
                        principalTable: "Respuesta",
                        principalColumn: "IdRespuesta");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_archivoresps_IdRespuestaNavigationIdRespuesta",
                table: "archivoresps",
                column: "IdRespuestaNavigationIdRespuesta");

            migrationBuilder.CreateIndex(
                name: "IX_Archivos_PreguntaIdPreguntas",
                table: "Archivos",
                column: "PreguntaIdPreguntas");

            migrationBuilder.CreateIndex(
                name: "IX_Archivos_PreguntaIdPreguntas1",
                table: "Archivos",
                column: "PreguntaIdPreguntas1");

            migrationBuilder.CreateIndex(
                name: "IX_composicionCorporalClients_IdComposicion",
                table: "composicionCorporalClients",
                column: "IdComposicion");

            migrationBuilder.CreateIndex(
                name: "IX_composicionCorporals_CueIdCuestionarioNavigationIdCuestionario",
                table: "composicionCorporals",
                column: "CueIdCuestionarioNavigationIdCuestionario");

            migrationBuilder.CreateIndex(
                name: "IX_CuestionarioClientes_CuestionarioIdCuestionario",
                table: "CuestionarioClientes",
                column: "CuestionarioIdCuestionario");

            migrationBuilder.CreateIndex(
                name: "IX_Cuestionarios_IdEntrenadorNavigationIdEntrenador",
                table: "Cuestionarios",
                column: "IdEntrenadorNavigationIdEntrenador");

            migrationBuilder.CreateIndex(
                name: "IX_perimetroDelClientes_IdCliente",
                table: "perimetroDelClientes",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_perimetroDelClientes_IdPerimetro",
                table: "perimetroDelClientes",
                column: "IdPerimetro");

            migrationBuilder.CreateIndex(
                name: "IX_PerimetrosCuestionarios_IdCuestionario",
                table: "PerimetrosCuestionarios",
                column: "IdCuestionario");

            migrationBuilder.CreateIndex(
                name: "IX_PerimetrosCuestionarios_IdPerimetro",
                table: "PerimetrosCuestionarios",
                column: "IdPerimetro");

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_IdCuestionarioNavigationIdCuestionario",
                table: "Preguntas",
                column: "IdCuestionarioNavigationIdCuestionario");

            migrationBuilder.CreateIndex(
                name: "IX_Respuesta_IdPreguntasNavigationIdPreguntas",
                table: "Respuesta",
                column: "IdPreguntasNavigationIdPreguntas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "archivoresps");

            migrationBuilder.DropTable(
                name: "Archivos");

            migrationBuilder.DropTable(
                name: "composicionCorporalClients");

            migrationBuilder.DropTable(
                name: "CuestionarioClientes");

            migrationBuilder.DropTable(
                name: "perimetroDelClientes");

            migrationBuilder.DropTable(
                name: "PerimetrosCuestionarios");

            migrationBuilder.DropTable(
                name: "Respuesta");

            migrationBuilder.DropTable(
                name: "composicionCorporals");

            migrationBuilder.DropTable(
                name: "Perimetros");

            migrationBuilder.DropTable(
                name: "Preguntas");

            migrationBuilder.DropTable(
                name: "Cuestionarios");

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
    }
}
