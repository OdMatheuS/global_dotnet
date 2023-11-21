namespace Global.Models
{
    public class DuvidasUsuario
    {
        public int Id { get; set; } 
        public string? Pergunta { get; set; }
        public string? Resposta { get; set; }

        // propriedade de navegação para Usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}
