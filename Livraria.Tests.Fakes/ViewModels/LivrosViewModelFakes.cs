using Livraria.Aplicacao.ViewModels;
using Livraria.Tests.Fakes.Models;

namespace Livraria.Tests.Fakes.ViewModels
{
    public class LivrosViewModelFakes
    {
        public static LivroViewModel HarryPotter = new LivroViewModel
        {
            Id = LivrosFakes.HarryPotter.Id,
            Titulo = "Harry Potter e a Pedra Filosofal",
            Autor = "J.K. Rowling",
            Estoque = 1
        };

    }
}
