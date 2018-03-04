using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Livraria.Aplicacao.Services;
using Livraria.Aplicacao.ViewModels;
using Livraria.Dominio.Dados;
using Livraria.Dominio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class LivrosController : Controller
    {
        private readonly ILivrosService servico;

        public LivrosController(ILivrosService servico)
        {
            this.servico = servico;
        }

        [HttpGet]
        public IEnumerable<LivroViewModel> Get()
        {
            return servico.ObterTodos();
        }

        [HttpGet("{id}")]
        public LivroViewModel Get(Guid id)
        {
            return servico.Obter(id);
        }

        [HttpPost]
        public void Post([FromBody]LivroViewModel livro)
        {
            servico.Salvar(livro);
        }

        [HttpPut]
        public void Put([FromBody]LivroViewModel value)
        {
            servico.Atualizar(value);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            servico.Remover(id);
        }
    }
}
