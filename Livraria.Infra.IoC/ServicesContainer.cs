using System;
using Livraria.CrossCutting.IoC;
using Livraria.CrossCutting.IoC.Container;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Infra.IoC
{
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
