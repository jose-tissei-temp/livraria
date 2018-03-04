using System;
using Livraria.CrossCutting.IoC;
using Livraria.CrossCutting.IoC.Container;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Infra.IoC
{
    // A ideia aqui é que como o aspnet core vem com seu proprio
    // container de injeção de dependências, ao desacoplar
    // sua implementação se torna mais facil substitui-lo
    // posteriormente caso alguma limitação seja encontrada
    public class ServicesContainer : IServicesContainer
    {
        private readonly IServiceCollection services;

        public ServicesContainer(IServiceCollection services)
        {
            this.services = services;
        }

        public void AddScoped<TService, TImplementation>() where TService : class where TImplementation : class, TService
        {
            services.AddScoped<TService, TImplementation>();
        }

        public void AddDbContext<TContext>(Action<DbContextOptionsBuilder> optionsAction = null) where TContext : DbContext
        {
            services.AddDbContext<TContext>(optionsAction);
        }

        public void AddScoped(Type serviceType, Type implementationType)
        {
            services.AddScoped(serviceType, implementationType);
        }
    }
}
