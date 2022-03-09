using EvonixGym.Data.Modelos;
using EvonixGym.Modelos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EvonixGym.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario , Rol , string, IdentityUserClaim<string>, UsuarioRol, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Usuario>(b =>
            {
                b.HasMany(us => us.UsuarioRoles)
                .WithOne(u => u.Usuario)
                .HasForeignKey(ui => ui.UserId)
                .IsRequired();

                b.HasMany(ue => ue.UsuarioEntrenadores)
                .WithOne(u => u.Usuario)
                .HasForeignKey(ui => ui.UserId)
                .IsRequired();

                b.HasMany(uc => uc.UsuarioClientes)
                .WithOne(u => u.Usuario)
                .HasForeignKey(ui => ui.UserId)
                .IsRequired();
            });
            builder.Entity<Rol>(b =>
            {
                b.HasMany(ro => ro.UsuarioRoles)
                .WithOne(r => r.Rol)
                .HasForeignKey(ri => ri.RoleId)
                .IsRequired();
            });            
            builder.Entity<Entrenador>(b =>
            {
                b.HasMany(eu => eu.UsuarioEntrenadores)
                .WithOne(r => r.Entrenador)
                .HasForeignKey(ri => ri.IdEntrenador)
                .IsRequired();
            });            
            builder.Entity<Cliente>(b =>
            {
                b.HasMany(ro => ro.UsuarioClientes)
                .WithOne(r => r.Cliente)
                .HasForeignKey(ri => ri.IdCliente)
                .IsRequired();
                b.HasMany(ro => ro.ComposicionCorporalClient)
               .WithOne(r => r.Cliente)
               .HasForeignKey(ri => ri.IdCcCliente)
               .IsRequired();
                b.HasMany(ro => ro.PerimetroDelClientes)
              .WithOne(r => r.Cliente)
              .HasForeignKey(ri => ri.IdCliente)
              .IsRequired();

            });
            builder.Entity<ComposicionCorporal>(b =>
            {
                b.HasMany(ro => ro.ComposicionCorporalClients)
                .WithOne(r => r.IdComposicionNavigation)
                .HasForeignKey(ri => ri.IdComposicion)
                .IsRequired();
            });
            builder.Entity<Perimetro>(b =>
            {
                b.HasMany(ro => ro.PerimetroDelClientes)
                .WithOne(r => r.IdPerimetroNavigation)
                .HasForeignKey(ri => ri.IdPerimetro)
                .IsRequired();
                b.HasMany(ro => ro.PerimetrosCuestionario)
               .WithOne(r => r.Perimetro)
               .HasForeignKey(ri => ri.IdPerimetro)
               .IsRequired();

            });
            builder.Entity<Cuestionario>(b =>
            {
                b.HasMany(ro => ro.PerimetrosCuestionarios)
                .WithOne(r => r.IdCuestionarioNavigation)
                .HasForeignKey(ri => ri.IdCuestionario)
                .IsRequired();
            });






            Seed(builder);
        }
        private void Seed(ModelBuilder builder)
        {
            var Admin = new Usuario()
            {
                Email = "usuadmin@gmail.com",
                NormalizedEmail = "USUADMIN@GMAIL.COM",
                UserName = "SuperUsuario",
                NormalizedUserName = "SUPERUSUARIO"
            };
            var Entrenador = new Usuario()
            {
                Email = "entrenador@gmail.com",
                NormalizedEmail = "ENTRENADOR@GMAIL.COM",
                UserName = "Juan",
                NormalizedUserName = "JUAN"
            };
            var Cliente = new Usuario()
            {
                Email = "cliente@gmail.com",
                NormalizedEmail = "CLIENTE@GMAIL.COM",
                UserName = "fran",
                NormalizedUserName = "FRAN"
            };
            var rolAdmin = new Rol()
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            };            
            var rolEntrenador = new Rol()
            {
                Name = "Entrenador",
                NormalizedName = "ENTRENADOR"
            };
            var rolCliente = new Rol()
            {
                Name = "Cliente",
                NormalizedName = "CLIENTE"
            };
            builder.Entity<Rol>().HasData(rolAdmin, rolEntrenador, rolCliente);
            builder.Entity<Usuario>().HasData(Admin, Entrenador, Cliente);

            var userRolAdmin = new UsuarioRol()
            {
                RoleId = rolAdmin.Id,
                UserId = Admin.Id
            };            
            var userRolEntrenador = new UsuarioRol()
            {
                RoleId = rolEntrenador.Id,
                UserId = Entrenador.Id
            };            
            var userRolCliente = new UsuarioRol()
            {
                RoleId = rolCliente.Id,
                UserId = Cliente.Id
            };
            builder.Entity<UsuarioRol>().HasData(userRolAdmin, userRolEntrenador, userRolCliente);
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<UsuarioClientes> UsuarioClientes { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<UsuarioEntrenadores> UsuarioEntrenadores { get; set; }
        public DbSet<Archivo> Archivos { get; set; }
        public DbSet<Archivoresp> archivoresps { get; set; }
        public DbSet<ComposicionCorporal> composicionCorporals { get; set; }
        public DbSet<ComposicionCorporalClient> composicionCorporalClients { get; set; }
        public DbSet<Cuestionario> Cuestionarios { get; set; }
        public DbSet<CuestionarioClientes> CuestionarioClientes { get; set; }
        public DbSet<Perimetro> Perimetros { get; set; }
        public DbSet<PerimetroDelCliente> perimetroDelClientes { get; set; }
        public DbSet<PerimetrosCuestionario> PerimetrosCuestionarios { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Respuestum> Respuesta { get; set; }





    }
}