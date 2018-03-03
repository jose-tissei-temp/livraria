using Livraria.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infra.Dados.Mapeamentos
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.Property(m => m.Id);
            builder.Property(c => c.Titulo).HasMaxLength(100).IsRequired();
        }
    }
}