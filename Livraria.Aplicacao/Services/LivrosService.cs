using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Livraria.Aplicacao.ViewModels;
using Livraria.Dominio.Dados;
using Livraria.Dominio.Models;

namespace Livraria.Aplicacao.Services
{
    public class LivrosService : ILivrosService
    {
        private readonly ILivros livros;
        private readonly IMapper mapper;

        public LivrosService(ILivros livros, IMapper mapper)
        {
            this.livros = livros;
            this.mapper = mapper;
        }
        public IEnumerable<LivroViewModel> ObterTodos()
        {
            return mapper.Map<IEnumerable<LivroViewModel>>(livros.ObterTodos());
        }

        public LivroViewModel Obter(Guid id)
        {
            return mapper.Map<LivroViewModel>(livros.Obter(id));
        }

        public void Salvar(LivroViewModel livro)
        {
            livros.Salvar(mapper.Map<Livro>(livro));
        }

        public void Atualizar(LivroViewModel livro)
        {
            livros.Atualizar(mapper.Map<Livro>(livro));
        }

        public void Remover(Guid id)
        {
            livros.Remover(id);
        }
    }
}