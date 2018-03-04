using FluentAssertions;
using Livraria.Infra.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Livraria.Infra.Dados.Tests.Contexto
{
    public class ModelBuilderExtensionsTests
    {
        [Fact]
        public void Deve_carregar_as_configuracoes_de_entidades()
        {
            var tipos = new []
            {
                typeof(EntityTypeConfigurationFake),
                typeof(FakeAbstractClass),
                typeof(IEntityTypeConfiguration<>)
            };

            var modelBuilder = new TestableModelBuilder();
            modelBuilder.ApplyAllAssemblyConfigurations(tipos);

            modelBuilder.ConfiguracoesCarregadas.Should().ContainSingle();
            modelBuilder.ConfiguracoesCarregadas.Should().Contain(typeof(EntityTypeConfigurationFake));
        }
    }
}