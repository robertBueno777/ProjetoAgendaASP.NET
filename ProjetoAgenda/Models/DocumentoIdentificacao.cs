using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgenda.Models
{
    [Table("DocumentoIdentificacao")]

    public class DocumentoIdentificacao 
    {
        [Key]
        public int DocumentoIdentificacaoId { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }


        public Usuario Usuario { get; set; }


    }
}
