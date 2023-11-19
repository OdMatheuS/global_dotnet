using System.ComponentModel.DataAnnotations.Schema;

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

        public IList<UsuarioAtualizacaoSaudePub> UsuarioAtualizacaoSaudePublicas { get; set; }

        // propriedade de navegação para DadosSuplementaresUsr
        //public DadosSuplementaresUsr DadosSuplementares { get; set; }

    }
}
