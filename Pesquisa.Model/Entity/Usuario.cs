using Pesquisa.SQLite.Public.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Pesquisa.Model.Entity
{
    public abstract class Usuario : IEntity
    {
        public int Id { get; set; }

        [MaxLength( 30 )]
        [Collate( CollationFunction.NoCase )]
        public string Nome { get; set; }

        [MaxLength( 30 )]
        [Collate( CollationFunction.NoCase )]
        public string NomeLogin { get; set; }

        [MaxLength( 30 )]
        [Collate( CollationFunction.NoCase )]
        public string SenhaLogin { get; set; }
    }
}
