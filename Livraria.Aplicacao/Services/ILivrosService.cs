using System;
using System.Collections.Generic;
using Livraria.Aplicacao.ViewModels;

namespace Livraria.Aplicacao.Services
{
    public interface ILivrosService
    {
        IEnumerable<LivroViewModel> ObterTodos();
        LivroViewModel Obter(Guid id);
        void Salvar(LivroViewModel livro);
        void Atualizar(LivroViewModel livro);
        void Remover(Guid id);
    }
}