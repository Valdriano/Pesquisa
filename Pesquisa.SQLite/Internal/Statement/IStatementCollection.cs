using System.Collections.Generic;

namespace Pesquisa.SQLite.Internal.Statement
{
    public interface IStatementCollection : IStatement, ICollection<IStatement>
    {
    }
}
