using System.Data.Common;
using System.Data.Entity;

namespace Pesquisa.Model
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext( string nameOrConnectionString )
            : base( nameOrConnectionString )
        {
            Configure();
        }

        public ModelDbContext( DbConnection connection , bool contextOwnsConnection )
            : base( connection , contextOwnsConnection )
        {
            Configure();
        }

        private void Configure()
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            //base.OnModelCreating( modelBuilder );
            ModelConfiguration.Configure( modelBuilder );
            ModelDbInitializer initializer = new ModelDbInitializer( modelBuilder );
            Database.SetInitializer( initializer );
        }
    }
}
