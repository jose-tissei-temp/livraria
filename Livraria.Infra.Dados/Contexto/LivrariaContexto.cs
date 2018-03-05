using System;
using System.IO;
using System.Reflection;
using Livraria.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Livraria.Infra.Dados.Contexto
{
    public class LivrariaContexto : DbContext, ILivrariaContexto
    {
        private readonly string environmentName;

        public LivrariaContexto()
        {
            environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllAssemblyConfigurations(Assembly.GetExecutingAssembly().GetTypes());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}