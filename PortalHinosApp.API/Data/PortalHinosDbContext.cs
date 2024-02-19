using Microsoft.EntityFrameworkCore;
using PortalHinosApp.Web.Models;
using System.Reflection;

namespace PortalHinosApp.API.Data
{
    public class PortalHinosDbContext : DbContext
    {
        public PortalHinosDbContext(DbContextOptions<PortalHinosDbContext> options) : base(options)
        {
        }

        public DbSet<HinoModel> Hino { get; set; }
        public DbSet<PautaModel> Pauta { get; set; }
        public DbSet<RelatorioModel> Relatorio { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            optionsBuilder.UseMySQL(configuration["ConnectionStrings:DefaultConnection"], options => options.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
