using System.Linq;
using FluentAssertions;
using Livraria.Dominio.Dados;
using Livraria.Dominio.Models;
using Livraria.Infra.Dados.Repositorios;
using Livraria.Tests.Fakes.Models;
using NSubstitute;
using Xunit;

namespace Livraria.Infra.Dados.Tests.Repositorios
{
    public class LivrosTests
    {
        private readonly ILivros livros;

        public LivrosTests()
        {
            var repositorio = Substitute.For<IRepositorio<Livro>>();
            repositorio.ObterTodos().Returns(new[]
            {
                LivrosFakes.OHobbit,
                LivrosFakes.HarryPotter,
                LivrosFakes.GuerraDosTronos
            }.AsQueryable());

            livros = new Livros(repositorio);
        }

        [Fact]
        public void Deve_retornar_livros_ordenados_por_titulo_de_forma_ascendente()
        {
            var actual = livros.ObterTodos();

            actual.Should().ContainInOrder(LivrosFakes.GuerraDosTronos, LivrosFakes.HarryPotter, LivrosFakes.OHobbit);
        }
    }
}