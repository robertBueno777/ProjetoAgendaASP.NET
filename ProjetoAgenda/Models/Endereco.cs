using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgenda.Models
{
    [Table("Endereco")]

    public class Endereco
    {


        [Key]
        public int EnderecoId { get; set; } //

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public string Logradouro { get; set; }//

        public string NumeroEndereco { get; set; }//

        public string Cep { get; set; } //

        public string Bairro { get; set; } // 

        public string Cidade { get; set; }//

        public string Estado { get; set; } //

        public string Complemento { get; set; }

        public string Situacao { get; set; }

        public Usuario Usuario { get; set; }


    }
}
