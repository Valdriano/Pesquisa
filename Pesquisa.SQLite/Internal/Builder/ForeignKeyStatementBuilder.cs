using Pesquisa.SQLite.Internal.Statement;
using Pesquisa.SQLite.Internal.Utility;
using System.Collections.Generic;
using System.Linq;

namespace Pesquisa.SQLite.Internal.Builder
{
    internal class ForeignKeyStatementBuilder : IStatementBuilder<ColumnStatementCollection>
    {
        private readonly IEnumerable<SqliteAssociationType> associationTypes;

        public ForeignKeyStatementBuilder( IEnumerable<SqliteAssociationType> associationTypes )
        {
            this.associationTypes = associationTypes;
        }

        public ColumnStatementCollection BuildStatement()
        {
            var columnDefStatement = new ColumnStatementCollection( GetForeignKeyStatements().ToList() );
            return columnDefStatement;
        }

        private IEnumerable<ForeignKeyStatement> GetForeignKeyStatements()
        {
            foreach( var associationType in associationTypes )
            {
                yield return new ForeignKeyStatement
                {
                    ForeignKey = associationType.ForeignKey ,
                    ForeignTable = associationType.FromTableName ,
                    ForeignPrimaryKey = associationType.ForeignPrimaryKey ,
                    CascadeDelete = associationType.CascadeDelete
                };
            }
        }
    }
}
