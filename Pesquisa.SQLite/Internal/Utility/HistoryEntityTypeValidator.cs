﻿using Pesquisa.SQLite.Public.Entities;
using System;

namespace Pesquisa.SQLite.Internal.Utility
{
    internal class HistoryEntityTypeValidator
    {
        public static void EnsureValidType( Type historyEntityType )
        {
            if( !typeof( IHistory ).IsAssignableFrom( historyEntityType ) )
            {
                throw new InvalidOperationException( "The Type " + historyEntityType.Name + " does not implement the IHistory interface." );
            }
            if( historyEntityType.GetConstructor( Type.EmptyTypes ) == null )
            {
                throw new InvalidOperationException( "The Type " + historyEntityType.Name + " does not provide an parameterless constructor." );
            }
        }
    }
}
