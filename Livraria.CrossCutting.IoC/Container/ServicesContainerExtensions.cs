using System;
using System.Linq;
using System.Reflection;
using Livraria.CrossCutting.IoC.Registros;

namespace Livraria.CrossCutting.IoC.Container
{
    public static class ServicesContainerExtensions
    {
        public static void CarregarRegistros(this IServicesContainer services)
        {
            var registros = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => 
                    type.IsClass
                    && !type.IsAbstract 
                    && typeof(IRegistroContainer).IsAssignableFrom(type)
                )
                .Select(Activator.CreateInstance)
                .Cast<IRegistroContainer>();

            foreach (var registro in registros)
            {
                registro.Registrar(services);
            }
        }
    }
}