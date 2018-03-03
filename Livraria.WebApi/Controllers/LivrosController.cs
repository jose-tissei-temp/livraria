using System;
using System.Collections.Generic;
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

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
