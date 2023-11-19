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

//        public IList<UsuarioAtualizacaoSaudePub> UsuarioAtualizacaoSaudePublicas { get; set; }

        // chave estrangeira para Usuario
        //public int Id { get; set; }
        // propriedade de navegação para Usuario
        //public Usuario Usuario { get; set; }
    }
}
