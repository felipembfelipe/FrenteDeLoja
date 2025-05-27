using System.Data.Entity;
using System.Configuration;
using FrenteDeLoja.Models;

namespace FrenteDeLoja.Infra.Contexto
{
    public class MDContext : DbContext
    {
        public MDContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
    }

}
