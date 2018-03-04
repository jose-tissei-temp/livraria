using System;
using Livraria.Dominio.Models;

namespace Livraria.Tests.Fakes.Models
{
    public class LivrosFakes
    {
        public static Livro HarryPotter = new Livro
        {
            Id = Guid.NewGuid(),
            Titulo = "Harry Potter e a Pedra Filosofal",
            Autor = "J.K. Rowling",
            Estoque = 1
        };

        public static Livro OHobbit = new Livro
        {
            Id = Guid.NewGuid(),
            Titulo = "O Hobbit",
            Autor = "J.R.R. Tolkien",
            Estoque = 2
        };

        public static Livro GuerraDosTronos = new Livro
        {
            Id = Guid.NewGuid(),
            Titulo = "As Crônicas de Gelo e Fogo: A Guerra dos Tronos",
            Autor = "George R.R. Martin",
            Estoque = 0
        };
    }
}