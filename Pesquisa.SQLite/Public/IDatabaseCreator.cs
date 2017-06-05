using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Pesquisa.SQLite.Public
{
    public interface IDatabaseCreator
    {
        void Create( Database db , DbModel model );
    }
}
