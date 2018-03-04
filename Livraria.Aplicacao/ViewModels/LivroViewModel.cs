using System;

namespace Livraria.Aplicacao.ViewModels
{
    public class LivroViewModel
    {
        public Guid? Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public long Estoque { get; set; }
    }
}