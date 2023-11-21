namespace Global.Models
{
    public class InfosSaudeUsr
    {
        public int Id { get; set; }
        public string? HabitosSaude { get; set; }
        public string? Alimentacao { get; set; }
        public decimal HorasSono{ get; set; }

        //propriedade de navegação inversa
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

    }
}
