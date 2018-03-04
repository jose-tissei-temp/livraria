using Livraria.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infra.Dados.Tests.Contexto
{
    public class EntityTypeConfigurationFake : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
        }
    }
}