﻿using System.Text;

namespace Pesquisa.SQLite.Internal.Statement
{
    internal class CreateTableStatement : IStatement
    {
        private const string Template = "CREATE TABLE {table-name} ({column-def});";

        public string TableName { get; set; }
        public IStatementCollection ColumnStatementCollection { get; set; }

        public string CreateStatement()
        {
            var sb = new StringBuilder( Template );

            sb.Replace( "{table-name}" , TableName );
            sb.Replace( "{column-def}" , ColumnStatementCollection.CreateStatement() );

            return sb.ToString();
        }
    }
}
