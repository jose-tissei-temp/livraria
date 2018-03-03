using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Livraria.Aplicacao.ViewModels;
using Livraria.Dominio.Dados;
using Livraria.Dominio.Models;

namespace Livraria.Aplicacao.Services
{
    public class LivrosService : ILivrosService
    {
        private readonly IRepositorio<Livro> repositorio;

        public LivrosService(IRepositorio<Livro> repositorio)
        {
            this.repositorio = repositorio;
        }
        public IEnumerable<LivroViewModel> ObterTodos()
        {
            return repositorio.ObterTodos().ProjectTo<LivroViewModel>();
        }
    }
}