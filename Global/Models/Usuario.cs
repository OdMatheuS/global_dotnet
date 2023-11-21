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
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public decimal TempoSono { get; set; }
        public bool PraticaEsporte { get; set; }
        public string? HabitosSaude { get; set; }
        public virtual DadosSuplementaresUsr? DadosSuplementares { get; set; }
                
        public List<AtualizacaoSaudePub>? ListaAtualizacaoPub { get; } = new();

        public List<UsuarioAtualizacaoSaudePub>? ListaUsuarioAtPub { get; } = new();

        public AtualizacaoSaudePub? AtSaudePub { get; set; }
        public int AtSaudePubId { get; set; }
        public List<UsuarioAtualizacaoSaudePub>? ListaUsuarioAtualizacaoSaudePub { get; } = new();



        //public IList<UsuarioAtualizacaoSaudePub> UsuarioAtualizacaoSaudePublicas { get; set; }

        // propriedade de navegação para DadosSuplementaresUsr
        //public DadosSuplementaresUsr DadosSuplementares { get; set; }

    }
}
