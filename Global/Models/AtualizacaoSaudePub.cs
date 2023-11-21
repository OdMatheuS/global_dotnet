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
        public List<Usuario>? ListaUsuario { get; } = new();
        public List<UsuarioAtualizacaoSaudePub>? ListaAtualizacao { get; } = new();
        public List<UsuarioAtualizacaoSaudePub>? ListaUsuarioAtualizacaoSaudePub { get; } = new();
        
        }
}
