namespace Global.Models
{
    public class DadosSuplementaresUsr
    {

        public int Id { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public char? Sexo{ get; set; }
        public int Idade { get; set; }

        // chave estrangeira para Usuario
        public int UsuarioId { get; set; }
        // propriedade de navegação para Usuario
        public Usuario Usuario { get; set; }
    }
}
