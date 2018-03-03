using System;

namespace Livraria.Dominio.Models
{
    public class Livro : IEntidade
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
    }
}