using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace Global.Models
{
    public class AtualizacaoSaudePub
    {
        public int AtualizacaoSaudePubId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInfoSaude { get; set; }

        public List<Usuario> Posts { get; } = new();
        public List<UsuarioAtualizacaoSaudePub> PostTags { get; } = new();

        //        public IList<UsuarioAtualizacaoSaudePub> UsuarioAtualizacaoSaudePublicas { get; set; }

        // chave estrangeira para Usuario
        //public int Id { get; set; }
        // propriedade de navegação para Usuario
        //public Usuario Usuario { get; set; }
    }
}
