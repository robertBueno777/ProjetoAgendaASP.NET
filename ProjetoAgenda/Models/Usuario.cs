using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAgenda.Models
{
    [Table("Usuario")]
    
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string DataNascimentoUsuario { get; set; }

    }
}
