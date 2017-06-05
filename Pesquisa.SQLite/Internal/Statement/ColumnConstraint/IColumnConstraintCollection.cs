using System.Collections.Generic;

namespace Pesquisa.SQLite.Internal.Statement.ColumnConstraint
{
    interface IColumnConstraintCollection : ICollection<IColumnConstraint>, IColumnConstraint
    {
    }
}
