using System.Collections.Generic;
using Livraria.Aplicacao.ViewModels;

namespace Livraria.Aplicacao.Services
{
    public interface ILivrosService
    {
        IEnumerable<LivroViewModel> ObterTodos();
    }
}