using Pesquisa.SQLite.Public.Entities;
using System;

namespace Pesquisa.Model.Entity
{
    class CustomHistory : IHistory
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Context { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
