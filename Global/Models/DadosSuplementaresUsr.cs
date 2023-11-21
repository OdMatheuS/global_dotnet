using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace Global.Models
{
    [Table("TB_DADOS_SUPLE_USR")]
    public class DadosSuplementaresUsr
    {

        public int DadosSuplementaresUsrId { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public Sexo Sexo{ get; set; }
        public int Idade { get; set; }

        [JsonIgnore]
        public virtual Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }

        public string CalcularIMC()
        {
            decimal imc = Peso / (Altura * Altura);
            return imc.ToString("N2");
        }

        public string ClassificarIMC()
        {
            decimal imc = Peso / (Altura * Altura);

            string classificacao;
            if (imc < 18)
            {
                classificacao = "Magreza";
            }
            else if (imc >= 18 && imc <= 24)
            {
                classificacao = "Normal";
            }
            else if (imc > 24 && imc <= 30)
            {
                classificacao = "Sobrepeso";
            }
            else
            {
                classificacao = "Obesidade";
            }

            return classificacao;
        }

    }
    public enum Sexo
    {
        Feminino, Masculino
    }

    

}
