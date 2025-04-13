using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgenda.Models
{
    [Table("Usuario")]
    
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento{ get; set; }

        public Endereco Endereco { get; set; }

        public DocumentoIdentificacao DocumentoIdentificacao { get; set; }

        public List<Telefone> Telefones { get; set; }


    }
}
