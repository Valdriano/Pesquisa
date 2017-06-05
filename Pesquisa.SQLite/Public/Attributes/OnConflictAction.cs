using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa.SQLite.Public.Attributes
{
    /// <summary>
    /// The action to resolve a UNIQUE constraint violation.
    /// Is used together with the <see cref="UniqueAttribute"/>.
    /// </summary>
    public enum OnConflictAction
    {
        None,
        Rollback,
        Abort,
        Fail,
        Ignore,
        Replace
    }
}
