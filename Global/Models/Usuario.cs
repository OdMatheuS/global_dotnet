using System.ComponentModel.DataAnnotations.Schema;

namespace Global.Models
{
    [Table("TB_USUARIO")]
    public class Usuario 
    {
        [Column("Id")]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public decimal TempoSono { get; set; }
        public bool PraticaEsporte { get; set; }
        public string? HabitosSaude { get; set; }



    }
}
