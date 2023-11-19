using System.ComponentModel.DataAnnotations.Schema;

namespace Global.Models
{
    [Table("TB_DADOS_SUPLE_USR")]
    public class DadosSuplementaresUsr
    {

        public int DadosSuplementaresUsrId { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public char? Sexo{ get; set; }
        public int Idade { get; set; }

        // chave estrangeira para Usuario
        //public int Id { get; set; }
        // propriedade de navegação para Usuario
        //public Usuario Usuario { get; set; }
    }
}
