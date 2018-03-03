using System;
using System.Linq;
using Livraria.Dominio.Models;

namespace Livraria.Dominio.Dados
{
    public interface IRepositorio<TEntidade> where TEntidade: IEntidade
    {
        void Salvar(TEntidade instancia);
        TEntidade Obter(Guid id);
        IQueryable<TEntidade> ObterTodos();
        void Atualizar(TEntidade instancia);
        void Remover(Guid id);
        int Atualizar();
    }
}