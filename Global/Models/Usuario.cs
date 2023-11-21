using Azure;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Global.Models
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
                
        public bool PraticaEsporte { get; set; }
        public string? HabitosSaude { get; set; }
        public virtual DadosSuplementaresUsr? DadosSuplementares { get; set; }
                
        public List<AtualizacaoSaudePub>? ListaAtualizacaoPub { get; } = new();

        public List<UsuarioAtualizacaoSaudePub>? ListaUsuarioAtPub { get; } = new();

        public AtualizacaoSaudePub? AtSaudePub { get; set; }
        public int AtSaudePubId { get; set; }
        public List<UsuarioAtualizacaoSaudePub>? ListaUsuarioAtualizacaoSaudePub { get; } = new();

        // propriedade de navegação para a relação One-to-Many
        public List<InfosSaudeUsr>? ListaInfosSaude { get; } = new();

        public List<DuvidasUsuario> ListaDuvidasUsuario { get; } = new();        

    }
}
