using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Global.Models
{
    public class AtualizacaoSaudePub
    {
        public int AtualizacaoSaudePubId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInfoSaude { get; set; }

        [NotMapped]
        public List<Usuario> ListaUsuario { get; } = new();
        public List<UsuarioAtualizacaoSaudePub> ListaAtualizacao { get; } = new();

        //        public IList<UsuarioAtualizacaoSaudePub> UsuarioAtualizacaoSaudePublicas { get; set; }

        // chave estrangeira para Usuario
        //public int Id { get; set; }
        // propriedade de navegação para Usuario
        //public Usuario Usuario { get; set; }
    }
}
