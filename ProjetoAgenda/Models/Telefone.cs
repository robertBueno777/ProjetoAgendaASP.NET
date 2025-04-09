using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgenda.Models
{
    [Table("TelefoneUsuario")]

    public class Telefone : Usuario
    {
        public int TelefoneId { get; set; }
        public int UsuarioId { get; set; }
        public string NumeroTelefone { get; set; }
        public string Situacao { get; set; }

    }
}
