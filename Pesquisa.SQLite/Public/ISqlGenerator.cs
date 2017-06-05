using System.Data.Entity.Core.Metadata.Edm;

namespace Pesquisa.SQLite.Public
{
    public interface ISqlGenerator
    {
        string Generate( EdmModel storeModel );
    }
}
