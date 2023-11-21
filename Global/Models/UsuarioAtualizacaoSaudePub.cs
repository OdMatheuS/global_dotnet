using Azure;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace Global.Models
{
    [Table("TB_Usuario_Atualizacao_Saude_Pub")]
    public class UsuarioAtualizacaoSaudePub
    {

        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public int AtSaudePubId { get; set; }
        
        public Usuario UsuarioObj { get; set; } = null!;
        public AtualizacaoSaudePub AtualizacaoObj { get; set; } = null!;


        //public Usuario Usuarios { get; set; }
        //public int UsuarioId { get; set; }

        //public AtualizacaoSaudePub AtualizacaoSaudePubs { get; set; }
        //public int AtualizacaoSaudePubId { get; set; }
    }
}
