namespace ProjetoAgenda.Models
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string NomeCidade { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

    }
}
