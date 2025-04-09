using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgenda.Models
{
    [Table("DocumentoIdentificacao")]

    public class DocumentoIdentificacao : Usuario 
    {
        [Key]
        public int DocumentoIdentificacaoId { get; set; }
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Tipo documento é obrigatório.")]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "Numero de documento é obrigatório.")]
        public string NumeroDocumento { get; set; }

    }
}
