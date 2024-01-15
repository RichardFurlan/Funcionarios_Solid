using Funcionarios_Solid.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Funcionarios_Solid.Data
{
    public class SistemaContabilDBContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public SistemaContabilDBContext(DbContextOptions<SistemaContabilDBContext> options,IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<Analista> Analistas { get; set; }
        public DbSet<Tester> Testers { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Gerente> Gerente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            var connectionString = _configuration.GetConnectionString("ConexaoBanco");
            optionsBuilder.UseNpgsql(connectionString);
        }
            
    }
}
