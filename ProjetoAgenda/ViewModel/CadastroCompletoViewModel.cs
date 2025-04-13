﻿using ProjetoAgenda.Models;
namespace ProjetoAgenda.ViewModel
{
    public class CadastroCompletoViewModel
    {
        public Usuario Usuario { get; set; }
        public Endereco Endereco { get; set; }
        public List <Telefone> Telefone { get; set; }
        public DocumentoIdentificacao DocumentoIdentificacao { get; set; }

    }
}
