﻿// <auto-generated />
using System;
using EvonixGym.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvonixGym.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220308164833_changestringnombrecliente")]
    partial class changestringnombrecliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EvonixGym.Data.Modelos.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Fechanacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdEntrenamiento")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Imageperfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Entrenador", b =>
                {
                    b.Property<int>("IdEntrenador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEntrenador"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Baja")
                        .HasColumnType("bit");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaAltaContrato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FechaProxPago")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEntrenador");

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Rol", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7c6aca4a-ffd7-4a35-acc5-9aa177e10f3c",
                            ConcurrencyStamp = "913b9498-7092-4bf2-96d8-4d42fa28fcbd",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "4de63080-92f2-4166-9809-1ea2193545b2",
                            ConcurrencyStamp = "9b2864fd-9a7b-46dc-9030-972df6a30ede",
                            Name = "Entrenador",
                            NormalizedName = "ENTRENADOR"
                        },
                        new
                        {
                            Id = "3a6b6fc7-b833-4622-b63b-bee412604a5d",
                            ConcurrencyStamp = "3ac06ac8-1065-419b-b72b-cfe7e2da2c5f",
                            Name = "Cliente",
                            NormalizedName = "CLIENTE"
                        });
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "30408596-f3ac-4bd0-9088-079551582b16",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4d6d2311-0566-4a54-8971-3171febaa31a",
                            Email = "usuadmin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "USUADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERUSUARIO",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3ce68d52-65d9-462a-a255-a6087f627d59",
                            TwoFactorEnabled = false,
                            UserName = "SuperUsuario"
                        },
                        new
                        {
                            Id = "e5064d70-9595-4629-941a-0bd424f9dd67",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f37ae1eb-87e2-4465-8064-61f5b3abacf4",
                            Email = "entrenador@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ENTRENADOR@GMAIL.COM",
                            NormalizedUserName = "JUAN",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "633f9d10-06ae-45fa-b7a6-2c48af0b82c1",
                            TwoFactorEnabled = false,
                            UserName = "Juan"
                        },
                        new
                        {
                            Id = "9ba1a001-d1ed-4646-8463-72d9a51e2bb0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "201dc20a-21f9-43a6-8196-8534f5390cca",
                            Email = "cliente@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENTE@GMAIL.COM",
                            NormalizedUserName = "FRAN",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f621028c-9ee0-49e9-8184-5c3f3d50f936",
                            TwoFactorEnabled = false,
                            UserName = "fran"
                        });
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioClientes", b =>
                {
                    b.Property<int>("UsuarioClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioClienteID"), 1L, 1);

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UsuarioClienteID");

                    b.HasIndex("IdCliente");

                    b.HasIndex("UserId");

                    b.ToTable("UsuarioClientes");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioEntrenadores", b =>
                {
                    b.Property<int>("UsuarioEntrenadorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioEntrenadorID"), 1L, 1);

                    b.Property<int>("IdEntrenador")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UsuarioEntrenadorID");

                    b.HasIndex("IdEntrenador");

                    b.HasIndex("UserId");

                    b.ToTable("UsuarioEntrenadores");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioRol", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "30408596-f3ac-4bd0-9088-079551582b16",
                            RoleId = "7c6aca4a-ffd7-4a35-acc5-9aa177e10f3c"
                        },
                        new
                        {
                            UserId = "e5064d70-9595-4629-941a-0bd424f9dd67",
                            RoleId = "4de63080-92f2-4166-9809-1ea2193545b2"
                        },
                        new
                        {
                            UserId = "9ba1a001-d1ed-4646-8463-72d9a51e2bb0",
                            RoleId = "3a6b6fc7-b833-4622-b63b-bee412604a5d"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioClientes", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Cliente", "Cliente")
                        .WithMany("UsuarioClientes")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Data.Modelos.Usuario", "Usuario")
                        .WithMany("UsuarioClientes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioEntrenadores", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Entrenador", "Entrenador")
                        .WithMany("UsuarioEntrenadores")
                        .HasForeignKey("IdEntrenador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Data.Modelos.Usuario", "Usuario")
                        .WithMany("UsuarioEntrenadores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrenador");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.UsuarioRol", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Rol", "Rol")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvonixGym.Data.Modelos.Usuario", "Usuario")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EvonixGym.Data.Modelos.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Cliente", b =>
                {
                    b.Navigation("UsuarioClientes");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Entrenador", b =>
                {
                    b.Navigation("UsuarioEntrenadores");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Rol", b =>
                {
                    b.Navigation("UsuarioRoles");
                });

            modelBuilder.Entity("EvonixGym.Data.Modelos.Usuario", b =>
                {
                    b.Navigation("UsuarioClientes");

                    b.Navigation("UsuarioEntrenadores");

                    b.Navigation("UsuarioRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
