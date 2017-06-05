using Pesquisa.Model.Entity;
using Pesquisa.SQLite.Public.DbInitializers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa.Model
{
    public class ModelDbInitializer : SqliteDropCreateDatabaseWhenModelChanges<ModelDbContext>
    {
        public ModelDbInitializer( DbModelBuilder modelBuilder ) : base( modelBuilder , typeof( CustomHistory ) )
        {

        }

        protected override void Seed( ModelDbContext context )
        {
            //base.Seed( context );
        }
    }
}
