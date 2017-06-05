using Pesquisa.SQLite.Internal.Statement;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace Pesquisa.SQLite.Internal.Builder
{
    internal class CompositePrimaryKeyStatementBuilder : IStatementBuilder<CompositePrimaryKeyStatement>
    {
        private readonly IEnumerable<EdmMember> keyMembers;

        public CompositePrimaryKeyStatementBuilder( IEnumerable<EdmMember> keyMembers )
        {
            this.keyMembers = keyMembers;
        }

        public CompositePrimaryKeyStatement BuildStatement()
        {
            return new CompositePrimaryKeyStatement( keyMembers.Select( km => km.Name ) );
        }
    }
}
