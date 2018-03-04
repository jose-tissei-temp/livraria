using System;
using Livraria.Dominio.Models;
using Livraria.Infra.Dados.Contexto;
using Livraria.Infra.Dados.Repositorios;
using Livraria.Tests.Fakes.Models;
using Microsoft.EntityFrameworkCore;
using NSubstitute;
using Xunit;

namespace Livraria.Infra.Dados.Tests.Repositorios
{
    public class RepositorioTests
    {
        private readonly ILivrariaContexto contexto;

        public RepositorioTests()
        {
            contexto = Substitute.For<ILivrariaContexto>();
        }

        [Fact]
        public void Deve_salvar_alteracoes_ao_descartar_a_classe()
        {
            using (var repositorio = new Repositorio<Livro>(contexto))
            {
                repositorio.Salvar(LivrosFakes.HarryPotter);
                contexto.Received(0).SaveChanges();
            }

            contexto.Received(1).SaveChanges();
        }
    }
}