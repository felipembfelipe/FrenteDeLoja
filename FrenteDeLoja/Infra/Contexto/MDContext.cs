using System.Data.Entity;
using System.Configuration;
using FrenteDeLoja.Models;

namespace FrenteDeLoja.Infra.Contexto
{
    public class MDContext : DbContext
    {
        //public MDContext() : base("DefaultConnection") { }

        public MDContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        //private static IConfigurationBuilder builder;
        //private static IConfiguration connectionStringConfig;

        //public MDContext(DbContextOptions<MDContext> options) : base(options) { }

        //public static SqlConnection GetShadowConnection()
        //{
        //    // Configuração da conexão
        //    builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true);

        //    connectionStringConfig = builder.Build();

        //    // Obtendo a string de conexão
        //    string connectionString = connectionStringConfig.GetConnectionString("DefaultConnection");

        //    // Criando a conexão SQL Server
        //    return new SqlConnection(connectionString);
        //}

        //#region DBSets

        //public DbSet<Usuario> Usuarios { get; set; }

        //#endregion


    }
}
