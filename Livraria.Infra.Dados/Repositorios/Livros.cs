using System;
using System.Linq;
using Livraria.Dominio.Dados;
using Livraria.Dominio.Models;

namespace Livraria.Infra.Dados.Repositorios
{
    // A ideia aqui é usar composição para não acoplar o repositorio
    // de livros ao repositorio base através de herança.
    public class Livros : ILivros
    {
        private readonly IRepositorio<Livro> repositorio;

        public Livros(IRepositorio<Livro> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Salvar(Livro instancia)
        {
            repositorio.Salvar(instancia);
        }

        public Livro Obter(Guid id)
        {
            return repositorio.Obter(id);
        }

        public IQueryable<Livro> ObterTodos()
        {
            return repositorio.ObterTodos().OrderBy(livro => livro.Titulo);
        }

        public void Atualizar(Livro instancia)
        {
            repositorio.Atualizar(instancia);
        }

        public void Remover(Guid id)
        {
            repositorio.Remover(id);
        }

        public int Atualizar()
        {
            return repositorio.Atualizar();
        }
    }
}