using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infra.Dados.Contexto
{
    public static class ModelBuilderExtensions
    {
        public static void ApplyAllAssemblyConfigurations(this ModelBuilder modelBuilder, Assembly assembly)
        {
            var methodInfo = typeof(ModelBuilder).GetMethod(
                nameof(ModelBuilder.ApplyConfiguration),
                BindingFlags.Instance | BindingFlags.Public
            );
            var mapeamentos = assembly.GetTypes().Where(ClasseImplementaEntityConfiguration);

            foreach (var mapeamento in mapeamentos)
            {
                var entidadeMapeada = mapeamento.GetInterfaces().Single().GenericTypeArguments.Single();
                var metodo = methodInfo.MakeGenericMethod(entidadeMapeada);
                metodo.Invoke(modelBuilder, new[] { Activator.CreateInstance(mapeamento) });
            }
        }

        private static bool ClasseImplementaEntityConfiguration(Type type)
        {
            return type.IsClass
                   && !type.IsAbstract
                   && type.GetInterfaces().Any(i => 
                       i.IsGenericType 
                       && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>
                   ));
        }
    }
}