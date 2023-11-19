using System.ComponentModel.DataAnnotations;

namespace Global.Models
{
    public class SugestoesSaude
    {
        public int Id { get; set; } 
        public string Sugestao { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataSugestao { get; set; }
    }
}
