using System;
using Microsoft.EntityFrameworkCore;

namespace Livraria.CrossCutting.IoC.Container
{
    public interface IServicesContainer
    {
        void AddScoped<TService, TImplementation>() where TService : class where TImplementation : class, TService;
        void AddDbContext<TContext>(Action<DbContextOptionsBuilder> optionsAction = null) where TContext : DbContext;
        void AddScoped(Type serviceType, Type implementationType);
    }
}