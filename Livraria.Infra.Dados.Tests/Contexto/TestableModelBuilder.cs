using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Livraria.Infra.Dados.Tests.Contexto
{
    public class TestableModelBuilder : ModelBuilder
    {
        public IList<Type> ConfiguracoesCarregadas { get; }

        public TestableModelBuilder() : base(new ConventionSet())
        {
            ConfiguracoesCarregadas = new List<Type>();
        }

        public override ModelBuilder ApplyConfiguration<TEntity>(IEntityTypeConfiguration<TEntity> configuration)
        {
            ConfiguracoesCarregadas.Add(configuration.GetType());

            return this;
        }
    }
}