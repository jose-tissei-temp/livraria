using Microsoft.EntityFrameworkCore;

namespace Livraria.Infra.Dados.Contexto
{
    public interface ILivrariaContexto
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}