using Pesquisa.Model.Entity;
using System.Data.Entity;

namespace Pesquisa.Model
{
    public class ModelConfiguration
    {
        public static void Configure( DbModelBuilder modelBuilder )
        {
            ConfigureUsuario( modelBuilder );
        }

        private static void ConfigureUsuario( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Usuario>().ToTable( "Base.Usuarios" );
        }
    }
}
