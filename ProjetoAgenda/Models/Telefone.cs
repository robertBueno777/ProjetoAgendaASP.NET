using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgenda.Models
{
    [Table("TelefoneUsuario")]

    public class Telefone
    {
        [Key]
        public int TelefoneId { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public string NumeroTelefone { get; set; }
        public string Situacao { get; set; }

        public Usuario Usuario { get; set; }

    }
}
