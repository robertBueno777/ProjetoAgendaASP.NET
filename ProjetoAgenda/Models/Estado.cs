namespace ProjetoAgenda.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string NomeEstado { get; set; }
        public string Sigla { get; set; }

        public List<Cidade> Cidades { get; set; }







    }
}
