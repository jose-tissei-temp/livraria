using AutoMapper;
using FluentAssertions;
using Livraria.Aplicacao.Mapeamentos;
using Livraria.Aplicacao.ViewModels;
using Livraria.Dominio.Models;
using Livraria.Tests.Fakes.Models;
using Livraria.Tests.Fakes.ViewModels;
using Xunit;

namespace Livraria.Aplicacao.Tests.Mapeamentos
{
    public class LivroProfileTests
    {
        private readonly IMapper mapper;

        public LivroProfileTests()
        {
            mapper = new Mapper(new MapperConfiguration(exp => exp.AddProfile<LivroProfile>())).DefaultContext.Mapper;
        }

        [Fact]
        public void Deve_mapear_entidade_para_view_model()
        {
            var actual = mapper.Map<LivroViewModel>(LivrosFakes.HarryPotter);
            actual.Should().BeEquivalentTo(LivrosViewModelFakes.HarryPotter);
        }

        [Fact]
        public void Deve_mapear_view_model_para_entidade()
        {
            var actual = mapper.Map<Livro>(LivrosViewModelFakes.HarryPotter);
            actual.Should().BeEquivalentTo(LivrosFakes.HarryPotter);
        }
    }
}