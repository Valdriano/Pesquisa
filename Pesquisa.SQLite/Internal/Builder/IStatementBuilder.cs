using Pesquisa.SQLite.Internal.Statement;

namespace Pesquisa.SQLite.Internal.Builder
{
    internal interface IStatementBuilder<out TStatement>
         where TStatement : IStatement
    {
        TStatement BuildStatement();
    }
}
