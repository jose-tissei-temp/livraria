using System;
using System.Linq;
using Livraria.Dominio.Dados;
using Livraria.Dominio.Models;
using Livraria.Infra.Dados.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infra.Dados.Repositorios
{
    public class Repositorio<TEntidade> : IRepositorio<TEntidade> where TEntidade : class, IEntidade
    {
        private readonly DbSet<TEntidade> set;
        private readonly DbContext contexto;

        public Repositorio(LivrariaContexto contexto)
        {
            this.contexto = contexto;
            set = contexto.Set<TEntidade>();
        }

        public void Salvar(TEntidade instancia)
        {
            set.Add(instancia);
        }

        public TEntidade Obter(Guid id)
        {
            return set.Find(id);
        }

        public IQueryable<TEntidade> ObterTodos()
        {
            return set;
        }

        public void Atualizar(TEntidade instancia)
        {
            set.Update(instancia);
        }

        public void Remover(Guid id)
        {
            set.Remove(set.Find(id));
        }

        public int Atualizar()
        {
            return contexto.SaveChanges();
        }
    }
}