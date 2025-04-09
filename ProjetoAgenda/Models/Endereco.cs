using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgenda.Models
{
    [Table("Endereco")]

    public class Endereco: Usuario
    {
        [Key]
        public int EnderecoId { get; set; }

        public int UsuarioId { get; set; }

        [Required(ErrorMessage ="informar o Logradouro é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "informar o Número é obrigatório")]
        public int NumeroEndereco { get; set; }

        [Required(ErrorMessage = "informar o Cep é obrigatório")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "informar o Bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "informar a Cidade é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "informar o Estado é obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "informar o Complemento é obrigatório")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "informar a Situação é obrigatório")]
        public string Situacao { get; set; }

    }
}
